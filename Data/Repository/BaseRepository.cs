using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> where T : BaseModel
    {
        public void Create(T model)
        {
            using (var context = new CrudContext())
            { 
            }
        }
        public void Read()
        {
        }
        public void Read(int id)
        {
        }
        public void Update()
        {
        }
        public void Delete()
        {
        }

    }
}
