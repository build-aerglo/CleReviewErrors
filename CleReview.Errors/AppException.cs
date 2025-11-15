namespace CleReview.Errors;

public abstract class AppException(ErrorCode code, string? message = null)
    : Exception(message ?? ErrorCatalog.GetMessage(code))
{
    public ErrorCode Code { get; } = code;
}