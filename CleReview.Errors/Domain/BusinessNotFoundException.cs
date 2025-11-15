namespace CleReview.Errors.Domain;

public class BusinessNotFoundException(string? details = null) : AppException(ErrorCode.BusinessNotFound, details);