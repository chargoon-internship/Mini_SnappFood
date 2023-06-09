using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes.Repositories
{
    public interface IRepositoryManager<Tentity> where Tentity : class
    {
        public bool Insert(Tentity entity);


        public bool Update(Tentity entity);

        public bool Delete(Tentity entity);

        public IEnumerable<Tentity> GetAll();

        public Tentity GetById(int id);

        public bool Delete(int id);

        public void Save();
    }
}
