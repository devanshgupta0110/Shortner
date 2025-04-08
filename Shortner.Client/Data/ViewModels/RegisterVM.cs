using System.ComponentModel.DataAnnotations;

namespace Shortner.Client.Data.ViewModels
{
	public class RegisterVM
	{
		[Required(ErrorMessage = "Full Name is required.")]
		public string FullName { get; set; }

		[Required(ErrorMessage = "Email address is required")]
		[RegularExpression(@"^\S+@\S+\.\S+$", ErrorMessage = "Invalid email address")]
		public string EmailAddress { get; set; }

		[Required(ErrorMessage = "Password is required")]
		[MinLength(5, ErrorMessage = "Password must be at least 5 characters")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Confirm Password is required")]
		[Compare("Password",ErrorMessage="Passwords do not match")]
		public string ConfirmPassword { get; set; }

	}
}
