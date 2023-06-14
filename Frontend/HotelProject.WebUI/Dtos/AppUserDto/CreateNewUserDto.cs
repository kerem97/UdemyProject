using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;


namespace HotelProject.WebUI.Dtos.AppUser
{
    public class CreateNewUserDto
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bu Alan Boş Geçilemez")]

        public string Surname { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string UserName { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string Mail { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string Password { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
       
        public string City { get; set; }
      
    }
}
