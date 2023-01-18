using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
  public class Storage
  {
    public List<Spell> MageSpells = new List<Spell>();
    public List<Spell> PriestSpells = new List<Spell>();
    DatabaseConnector connector;

    public Storage()
    {
      //PopulateSpellList_Mage();
      connector = new DatabaseConnector();
      GetAllMageSpells();
      PopulateSpellList_Priest();
    }

    public void GetAllMageSpells()
    {
      MageSpells = connector.GetMageSpell();
    }

    void PopulateSpellList_Mage()
    {

     // connector = new DatabaseConnector();
      connector.AddSpellMage("Spell a", "blah blah");
      //MageSpells.Add(new Spell("Spell 1", "A simple spell", 1, 1, 3));
      //MageSpells.Add(new Spell("Spell 2","a more complicated spell",3,2,8));
      //MageSpells.Add(new Spell("Spell 3", "A complex spell", 1, 1, 3));
      //MageSpells.Add(new Spell("Spell 4", "A fire spell", 1, 1, 3));
      //MageSpells.Add(new Spell("Spell 5", "A water spell", 1, 1, 3));

    }

    void PopulateSpellList_Priest()
    {

    }

  }
}
