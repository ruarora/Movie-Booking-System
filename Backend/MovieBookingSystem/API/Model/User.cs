using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public string PhoneNumber { set; get; }
        [Required(ErrorMessage = "Passwored is required")]
        public string Password { set; get; }
    }
}
