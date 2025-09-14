namespace CashFlow.Communication.Responses;

public class ProblemDetailsResponse
{
    public List<string> ErrorMessages { get; init; }

    public ProblemDetailsResponse(string errorMessage)
    {
        ErrorMessages = [errorMessage];
    }

    public ProblemDetailsResponse(List<string> errorMessages)
    {
        ErrorMessages = errorMessages;
    }
}
