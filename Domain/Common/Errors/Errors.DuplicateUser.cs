using ErrorOr;

namespace Domain.Common.Errors;

public static partial class Errors {
    public static class User {
        public static Error DuplicateEmail => Error.Conflict(
            code: "User.DuplicateEmail", 
            description: "An account with same email already exists. Please see login instead"
        );
    }
}