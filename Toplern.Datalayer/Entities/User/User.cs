using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplern.Datalayer.Entities.User
{
    public class User
    {
        public User()
        {
            
        }

        [Key]
        public int UserId { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیش از {1}کاراکتر باشد  ")]

        public string UserName { get; set; }
        [Display(Name = "ایمل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیش از {1}کاراکتر باشد  ")]
        [EmailAddress(ErrorMessage ="ایمل وارد شده درست نمیباشد ")]
        public string Email { get; set; }
        [Display(Name = "رمز ورود")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیش از {1}کاراکتر باشد  ")]

        public string password { get; set; }
        [Display(Name = "کد فعال سازی")]
       
        public string ActiveCode { get; set; }
        [Display(Name = "وضعیت")]
      
        public bool IsActive { get; set; }
        [Display(Name = "آواتار")]
        public string UserAvatar { get; set; }
        [Display(Name = "تاریخ ثبت نام ")]
        public DateTime RegisterDate { get; set; }


        #region Relation 
        
        public virtual List<UserRole> UserRoles { get; set; }
        #endregion

    }
}
