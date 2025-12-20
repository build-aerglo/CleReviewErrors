namespace CleReview.Errors;

public static class ErrorCatalog
{
    private static readonly Dictionary<ErrorCode, string> Messages = new()
    {
        { ErrorCode.BusinessAlreadyExists, "Business with this name already exists." },
        { ErrorCode.BusinessNotFound, "The specified business could not be found." },
        { ErrorCode.CategoryNotFound, "One or more categories were not found." },
        { ErrorCode.ValidationFailed, "The request failed validation." },
        { ErrorCode.Unauthorized, "You are not authorized." },
        { ErrorCode.Forbidden, "Access denied." },
        { ErrorCode.Conflict, "The request could not be completed due to a conflict." },
        { ErrorCode.InternalServerError, "An unexpected server error occurred." }
    };

    public static string GetMessage(ErrorCode code)
        => Messages.GetValueOrDefault(code, $"Unknown error. Error code {(int)code} ({code}) is not defined in the error catalog.");
}
