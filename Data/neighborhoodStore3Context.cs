using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace neighborhoodStore3.Data
{
    public class neighborhoodStore3Context : DbContext
    {

        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public neighborhoodStore3Context() : base("name=neighborhoodStore3Context")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public System.Data.Entity.DbSet<neighborhoodStore3.Models.User> Users { get; set; }


        public System.Data.Entity.DbSet<neighborhoodStore3.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<neighborhoodStore3.Models.Sales> Sales { get; set; }
    }
}
