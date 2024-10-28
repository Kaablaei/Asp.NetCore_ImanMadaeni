using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopLern.Core.DTOs
{
    public class RegisterViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیش از {1}کاراکتر باشد  ")]

        public string UserName { get; set; }
        [Display(Name = "ایمل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیش از {1}کاراکتر باشد  ")]
        [EmailAddress(ErrorMessage = "ایمل وارد شده درست نمیباشد ")]
        public string Email { get; set; }
        [Display(Name = "رمز ورود")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیش از {1}کاراکتر باشد  ")]

        public string password { get; set; }

        [Display(Name = "تکرار کلمه عبود ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [Compare(nameof(password) ,ErrorMessage = "کلمه عبور و تکرار آن صحیح نیست")]
        public string Repassword { get; set; }
     


    }
}
