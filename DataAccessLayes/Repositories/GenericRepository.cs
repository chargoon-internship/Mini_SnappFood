using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes.Repositories
{
    public class GenericRepository<Tentity> : IRepositoryManager<Tentity> where Tentity : class
    {
        private DB db;
        private DbSet<Tentity> dbSet;
        public GenericRepository(DB db)
        {
            this.db = db;
            dbSet = db.Set<Tentity>();
        }

        public virtual bool Insert(Tentity entity)
        {
            try
            {
                dbSet.Add(entity);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public virtual bool Update(Tentity entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Modified;
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual bool Delete(Tentity entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Deleted;
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual bool Delete(int id)
        {
            try
            {
                var result=GetById(id);
                Delete(result);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual IEnumerable<Tentity> GetAll()
        {
            return dbSet;
        }

        public virtual Tentity GetById(int id)
        {
            return dbSet.Find(id)!;
        }

        public virtual void Save()
        {
            db.SaveChanges();
        }


    }
}
