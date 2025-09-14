using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        // validacoes
        Validate(request);

        // persistir

        // retorno
        var expense = new ResponseRegisterExpenseJson
        {
            Title = "Conta de Luz"
        };
        return expense;
    }

    private void Validate(RequestRegisterExpenseJson request)
    {
        var titleIsEmpty = string.IsNullOrWhiteSpace(request.Title);
        if (titleIsEmpty) throw new ArgumentException("The title is required");

        if (request.Amount <= 0) throw new ArgumentException("The value must be grater than 0");

        var dateCompareResult = DateTime.Compare(request.Date, DateTime.UtcNow);
        if(dateCompareResult > 0) throw new ArgumentException("The date must be in the present");

        var paymentTypeIsValid = Enum.IsDefined(typeof(PaymentType), request.PaymentType);
        if (!paymentTypeIsValid) throw new ArgumentException("Payment Type is not valid");
    }
}

