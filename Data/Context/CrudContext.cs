using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class CrudContext : DbContext
    {
        public DbSet<Teacher> Teacher { get; set; }
        public CrudContext() : base("Data Source=192.168.0.161;Initial Catalog=MVCAlex;User ID=Adilson;Password=123321@")
        {
        }
    }
}
