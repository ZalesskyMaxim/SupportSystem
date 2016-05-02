using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class AuthorPicturesRepository : AbstractRepository, IModelRepository<DAL.Models.AuthorPictures, Model.DBModel.tbl_11_AuthorPictures>
    {
        private Model.DBModel.tbl_11_AuthorPictures ToEntity(DAL.Models.AuthorPictures source)
        {
            return new Model.DBModel.tbl_11_AuthorPictures()
            {
                AuthorFirstName = source.AuthorFirstName,
                AuthorLastName = source.AuthorLastName,
                AuthorMiddleName = source.AuthorMiddleName,
                AuthorDate_of_birth = source.AuthorDate_of_birth,
                AuthorOtherDates = source.AuthorOtherDates,
                AuthorBiography = source.AuthorBiography
            };
        }

        private DAL.Models.AuthorPictures ToObject(Model.DBModel.tbl_11_AuthorPictures source)
        {
            return new DAL.Models.AuthorPictures()
            {
                AuthorFirstName = source.AuthorFirstName,
                AuthorLastName = source.AuthorLastName,
                AuthorMiddleName = source.AuthorMiddleName,
                AuthorDate_of_birth = source.AuthorDate_of_birth,
                AuthorOtherDates = source.AuthorOtherDates,
                AuthorBiography = source.AuthorBiography
            };
        }

        public Model.DBModel.tbl_11_AuthorPictures GetEntity(DAL.Models.AuthorPictures source)
        {
            ///TODO add full attributes
            var entity = this.dbArtWorkContext.tbl_11_AuthorPictures.FirstOrDefault(x => x.AuthorFirstName == source.AuthorFirstName);
            return entity;
        }

        public Model.DBModel.tbl_11_AuthorPictures GetEntityNameById(int id)
        {
            var entity = this.dbArtWorkContext.tbl_11_AuthorPictures.FirstOrDefault(x => x.AuthorPicturesId == id);
            return entity;
        }

        public Model.DBModel.tbl_11_AuthorPictures GetEntityIDByName(string name)
        {
            var entity = this.dbArtWorkContext.tbl_11_AuthorPictures.FirstOrDefault(x => x.AuthorFirstName == name);
            return entity;
        }

        public void Add(DAL.Models.AuthorPictures item)
        {
            var entity = this.ToEntity(item);
            dbArtWorkContext.tbl_11_AuthorPictures.Add(entity);
            SaveChanges();
        }

        public void Remove(DAL.Models.AuthorPictures item)
        {
            var entity = this.dbArtWorkContext.tbl_11_AuthorPictures.FirstOrDefault(x => x.AuthorPicturesId == item.AuthorPicturesId);
            if (entity != null)
            {
                dbArtWorkContext.tbl_11_AuthorPictures.Remove(entity);
                SaveChanges();
            }
            else
            {
                throw new ArgumentException("Incorrect argument!!!");
            }
        }

        public void Remove(int id)
        {
            var entity = this.dbArtWorkContext.tbl_11_AuthorPictures.FirstOrDefault(x => x.AuthorPicturesId == id);
            if (entity != null)
            {
                dbArtWorkContext.tbl_11_AuthorPictures.Remove(entity);
                SaveChanges();
            }
            else
            {
                throw new ArgumentException("Incorrect argument!!!");
            }
        }

        public void Update(DAL.Models.AuthorPictures item)
        {
            var entity = this.dbArtWorkContext.tbl_11_AuthorPictures.FirstOrDefault(x => x.AuthorPicturesId == item.AuthorPicturesId);
            if (entity != null)
            {
                //entity.AuthorFirstName = item.AuthorFirstName;
                entity.AuthorFirstName = item.AuthorFirstName;
                entity.AuthorLastName = item.AuthorLastName;
                entity.AuthorMiddleName = item.AuthorMiddleName;
                entity.AuthorDate_of_birth = item.AuthorDate_of_birth;
                entity.AuthorOtherDates = item.AuthorOtherDates;
                entity.AuthorBiography = item.AuthorBiography;
                SaveChanges();
            }
            else
            {
                throw new ArgumentException("Incorrect argument!!!");
            }
        }

        public IEnumerable<DAL.Models.AuthorPictures> Items
        {
            get
            {
                var b = new List<DAL.Models.AuthorPictures>();
                foreach (var a in dbArtWorkContext.tbl_11_AuthorPictures.Select(x => x))
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
