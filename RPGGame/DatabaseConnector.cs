using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
  public class DatabaseConnector
  {
    SqlConnection cnn;
    string ConnectionString;
    int id = 0;

    public DatabaseConnector()
    {
      ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\Datalabs Student\\source\\repos\\RPGGame\\RPGGame\\RpgDB.mdf\"; Integrated Security = True";
      cnn = new SqlConnection(ConnectionString);
    }

    public void AddSpellMage(string name,string desc)
    {
      cnn = new SqlConnection(ConnectionString);
      cnn.Open();
      SqlCommand add = new SqlCommand(string.Format("INSERT INTO MageSpells VALUES(\'{0}\',\'{1}\')",name, desc),cnn);
      add.ExecuteNonQuery();
      id++;
      cnn.Close();
    }

    public List<Spell> GetMageSpell()
    {
      cnn = new SqlConnection(ConnectionString);
      List<Spell> list = new List<Spell>();
      cnn.Open();
      SqlCommand getMax = new SqlCommand("Select Max(id) From MageSpells",cnn);
      int max = (int)getMax.ExecuteScalar();
      
      for(int i =0; i < max;i++)
      {
        SqlCommand getName = new SqlCommand("Select Name from MageSpells where id = " + i,cnn);
        string spellName = (string)getName.ExecuteScalar();
        SqlCommand getDescription = new SqlCommand("Select Description from MageSpells where id = " + i, cnn);
        string spellDesc = (string)getDescription.ExecuteScalar();
        list.Add(new Spell(spellName,spellDesc,1,1,1));
      }

      cnn.Close();
      return list;
    }

  }
}
