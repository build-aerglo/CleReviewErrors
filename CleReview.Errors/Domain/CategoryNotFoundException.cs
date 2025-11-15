namespace CleReview.Errors.Domain;

public class CategoryNotFoundException(string? details = null) : AppException(ErrorCode.CategoryNotFound, details);