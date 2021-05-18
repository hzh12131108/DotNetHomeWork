using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderContext:DbContext
    {

        public OrderContext()
           : base("name=OrderDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OrderContext>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}