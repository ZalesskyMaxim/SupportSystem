using Model.Users.UsersModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Users.UsersModel
{
    public interface IRepository
    {
        #region User
        IQueryable<tbl_1_User> Users { get; }
        bool CreateUser(tbl_1_User instance);
        bool UpdateUser(tbl_1_User instance);
        bool RemoveUser(int idUser);
        tbl_1_User GetUser(string email);
        tbl_1_User Login(string email, string password);
        #endregion

        #region Roles
        IQueryable<tbl_2_Role> Roles { get; }
        bool CreateRole(tbl_2_Role instance);
        bool UpdateRole(tbl_2_Role instance);
        bool RemoveRole(int idRole);
        #endregion

        #region UserRoles
        IQueryable<UserRole> UserRoles { get; }
        bool CreateUserRole(UserRole instance);
        bool UpdateUserRole(UserRole instance);
        bool RemoveUserRole(int idUserRole);
        #endregion
    }
}
