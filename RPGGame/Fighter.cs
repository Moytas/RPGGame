using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
  public class Fighter : Player
  {
    //public Fighter()
    //{

    //}

    public Fighter(string name,int str,int dex,int con,int intl,int wis,
      int cha)
    {
      Name = name;
      STRENGTH = str;
      DEXTERITY = dex;
      CONSTITUTION = con;
      INTELLIGENCE = intl;
      CHARISMA = cha;
    }
  }
}
