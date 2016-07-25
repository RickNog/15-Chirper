using System.ComponentModel.DataAnnotations;


namespace Chirper.WebApi.Models
{
    public class RegistrationModel
    {
        [Required]  //Value must be provided
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ConfirmPasswrod { get; set; }
    }
}