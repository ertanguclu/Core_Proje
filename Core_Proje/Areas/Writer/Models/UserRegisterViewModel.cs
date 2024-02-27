﻿using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı girin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen resim url değeri girin")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi tekrar girin")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen mail adresinizi girin")]
        public string Mail { get; set; }
    }
}
