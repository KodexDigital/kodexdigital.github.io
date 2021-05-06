
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Resume.My.Persistence.ViewModel
{
    public class AuthModel
    {

        [Required(ErrorMessage ="Username required.")]
        [DataType(DataType.Password)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Access key required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
