using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Users.UsersModel
{
    public partial class SqlRepository
    {

        public IQueryable<tbl_1_User> Users
        {
            get
            {
                return Db.tbl_1_Users;
            }
        }

        public bool CreateUser(tbl_1_User instance)
        {
            if (instance.IDUser == 0)
            {
                instance.AddedDate = DateTime.Now;
                ///TODO Refctor this code!!!!!!!!
                #region hardcode CityId, PrivilegeId, OrganizationId.
                instance.CityId = 1;
                instance.PrivilegeId = 1;
                instance.OrganizationId = 1;
                #endregion
                instance.ActivatedLink = tbl_1_User.GetActivateUrl();
                Db.tbl_1_Users.InsertOnSubmit(instance);
                Db.tbl_1_Users.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool UpdateUser(tbl_1_User instance)
        {
            tbl_1_User cache = Db.tbl_1_Users.Where(p => p.IDUser == instance.IDUser).FirstOrDefault();
            if (cache != null)
            {
                cache.Birthdate = instance.Birthdate;
                cache.AvatarPath = instance.AvatarPath;
                cache.Email = instance.Email;
                Db.tbl_1_Users.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveUser(int idUser)
        {
            tbl_1_User instance = Db.tbl_1_Users.Where(p => p.IDUser == idUser).FirstOrDefault();
            if (instance != null)
            {
                Db.tbl_1_Users.DeleteOnSubmit(instance);
                Db.tbl_1_Users.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public tbl_1_User GetUser(string email)
        {
            return Db.tbl_1_Users.FirstOrDefault(p => string.Compare(p.Email, email, true) == 0);
        }

        public tbl_1_User Login(string email, string password)
        {
            return Db.tbl_1_Users.FirstOrDefault(p => string.Compare(p.Email, email, true) == 0 && p.Password == password);
        }

    }
}
