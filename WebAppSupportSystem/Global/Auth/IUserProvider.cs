using Model.Users.UsersModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSupportSystem.Global.Auth
{
    public interface IUserProvider
    {
        tbl_1_User User { get; set; }
    }
}