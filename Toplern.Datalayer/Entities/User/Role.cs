using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplern.Datalayer.Entities.User
{
    public class Role
    {
        public Role()
        {
            
        }
        [Key]
        public int RoleId { get; set; }

        [Display (Name ="نقش")]
        [Required (ErrorMessage ="لطفا {0} را وارد کنید ")]
        [MaxLength(200,ErrorMessage ="{0}نمیتواند بیش از {1}کاراکتر باشد  ")]

        public string RoleTitle { get; set; }

        #region Relation
        public virtual List<UserRole> UserRole { get; set; }
        #endregion

    }
}
