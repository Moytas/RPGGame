using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
  public class Player
  {
    public string Name;
    private int STRENGTH, DEXTERITY, CONSTITUTION, INTELLIGENCE, WISDOM, CHARISMA;

    public Player(string name,int str,int dex,int con,int intl,int wis,int cha)
    {
      Name = name;
      STRENGTH = str;
      DEXTERITY = dex;
      CONSTITUTION = con;
      INTELLIGENCE = intl;
      WISDOM = wis;
      CHARISMA = cha;
    }

  }
}
