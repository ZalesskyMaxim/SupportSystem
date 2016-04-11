using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Users.UsersModel
{
    public partial class SqlRepository
    {
        public IQueryable<tbl_2_Role> Roles
        {
            get
            {
                return Db.tbl_2_Roles;
            }
        }

        public bool CreateRole(tbl_2_Role instance)
        {
            if (instance.IDRole == 0)
            {
                Db.tbl_2_Roles.InsertOnSubmit(instance);
                Db.tbl_2_Roles.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateRole(tbl_2_Role instance)
        {
            tbl_2_Role cache = Db.tbl_2_Roles.FirstOrDefault(p => p.IDRole == instance.IDRole);
            if (instance.IDRole == 0)
            {
                cache.Name = instance.Name;
                cache.Code = instance.Code;
                Db.tbl_2_Roles.Context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool RemoveRole(int idRole)
        {
            tbl_2_Role instance = Db.tbl_2_Roles.FirstOrDefault(p => p.IDRole == idRole);
            if (instance != null)
            {
                Db.tbl_2_Roles.DeleteOnSubmit(instance);
                Db.tbl_2_Roles.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
}
