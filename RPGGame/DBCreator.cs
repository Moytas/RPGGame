using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
  public class DBCreator : DbContext
  {
    public DBCreator() : base()
    {
      
    }

    public DbSet<Fighter> Fighters { get; set; }
  }
}
