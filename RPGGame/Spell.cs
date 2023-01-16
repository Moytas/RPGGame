using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
  public class Spell
  {
    public string Name;
    public string Description;
    public int CastingTime;
    public int MinDamage,MaxDamage;
  
    public Spell(string name, string description, int castingTime, int minDamage, int maxDamage)
    {
      Name = name;
      Description = description;
      CastingTime = castingTime;
      MinDamage = minDamage;
      MaxDamage = maxDamage;
    }
  }
}
