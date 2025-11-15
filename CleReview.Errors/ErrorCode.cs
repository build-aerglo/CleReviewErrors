namespace CleReview.Errors;

public enum ErrorCode
{
    BusinessAlreadyExists = 1001,
    BusinessNotFound = 1002,
    CategoryNotFound = 1003,
    ValidationFailed = 1004,
    Unauthorized = 2001,
    Forbidden = 2002,
    Conflict = 3001,
    InternalServerError = 5000
}