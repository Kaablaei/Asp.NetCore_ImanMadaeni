using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopLern.Core.Services.InterFaces
{
    public interface IUserServices
    {
        public bool IsExistUserName(string UserName);
        public bool IsExistEmai(string Email);
    }
}
