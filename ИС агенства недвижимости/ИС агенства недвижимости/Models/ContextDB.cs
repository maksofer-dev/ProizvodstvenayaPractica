using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИС_агенства_недвижимости.Models
{
    class ContextDB : DbContext
    {
        public ContextDB() : base("DefaultConnection")
        {

        }
        public DbSet<ClientsInfo> clientsInfo { get; set; }
        public DbSet<RentsInfo> rentsInfo { get; set; }
        public DbSet<SellingInfo> sellingInfo { get; set; }


    }
}
