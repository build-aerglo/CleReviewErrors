namespace CleReview.Errors.Domain;

public class BusinessAlreadyExistsException(string? details = null)
    : AppException(ErrorCode.BusinessAlreadyExists, details);