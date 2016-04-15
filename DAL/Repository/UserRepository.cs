using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UserRepository : AbstractRepository, IModelRepository<DAL.Models.User, Model.DBModel.tbl_1_User>
    {
        private Model.DBModel.tbl_1_User ToEntity(DAL.Models.User source)
        {
            return new Model.DBModel.tbl_1_User()
            {
                UserFirstName = source.UserFirstName,
                UserLastName = source.UserLastName,
                UserMiddleName = source.UserMiddleName,
                UserMobilePhoneNumber = source.UserMobilePhoneNumber,
                
            };
        }

        private DAL.Models.User ToObject(Model.DBModel.tbl_1_User source)
        {
            return new DAL.Models.User()
            {
                UserFirstName = source.UserFirstName,
                UserLastName = source.UserLastName,
                UserMiddleName = source.UserMiddleName,
                UserMobilePhoneNumber = source.UserMobilePhoneNumber,
            };
        }

        public Model.DBModel.tbl_1_User GetEntity(DAL.Models.User source)
        {
            ///TODO add full attributes
            var entity = this.dbArtWorkContext.tbl_1_User.FirstOrDefault(x => x.UserFirstName == source.UserFirstName);
            return entity;
        }

        public Model.DBModel.tbl_1_User GetEntityNameById(int id)
        {
            var entity = this.dbArtWorkContext.tbl_1_User.FirstOrDefault(x => x.IDUser == id);
            return entity;
        }

        public Model.DBModel.tbl_1_User GetEntityIDByName(string name)
        {
            var entity = this.dbArtWorkContext.tbl_1_User.FirstOrDefault(x => x.UserFirstName == name);
            return entity;
        }

        public void Add(DAL.Models.User item)
        {
            var entity = this.ToEntity(item);
            dbArtWorkContext.tbl_1_User.Add(entity);
        }

        public void Remove(DAL.Models.User item)
        {
            var entity = this.dbArtWorkContext.tbl_1_User.FirstOrDefault(x => x.IDUser == item.IDUser);
            if (entity != null)
            {
                dbArtWorkContext.tbl_1_User.Remove(entity);
                SaveChanges();
            }
            else
            {
                throw new ArgumentException("Incorrect argument!!!");
            }
        }

        public void Remove(int id)
        {
            var entity = this.dbArtWorkContext.tbl_1_User.FirstOrDefault(x => x.IDUser == id);
            if (entity != null)
            {
                dbArtWorkContext.tbl_1_User.Remove(entity);
                SaveChanges();
            }
            else
            {
                throw new ArgumentException("Incorrect argument!!!");
            }
        }

        public void Update(DAL.Models.User item)
        {
            var entity = this.dbArtWorkContext.tbl_1_User.FirstOrDefault(x => x.IDUser == item.IDUser);
            if (entity != null)
            {
                entity.UserFirstName = item.UserFirstName;
                SaveChanges();
            }
            else
            {
                throw new ArgumentException("Incorrect argument!!!");
            }
        }

        public IEnumerable<DAL.Models.User> Items
        {
            get
            {
                var b = new List<DAL.Models.User>();
                foreach (var a in dbArtWorkContext.tbl_1_User.Select(x => x))
                {
                    b.Add(ToObject(a));
                }

                return b;
            }
        }

        public void SaveChanges()
        {
            dbArtWorkContext.SaveChanges();
        }
    }
}
