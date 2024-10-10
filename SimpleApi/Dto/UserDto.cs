using System.ComponentModel.DataAnnotations;

namespace BlogApp.Dto;

// DTO class for the request
public class CreateUserRequest
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(
        100,
        MinimumLength = 3,
        ErrorMessage = "Name must be between 3 and 100 characters."
    )]
    public required string Name { get; set; }
}
