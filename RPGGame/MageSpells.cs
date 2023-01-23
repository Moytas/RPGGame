using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGame
{
  public partial class MageSpells : Form
  {
    Storage storage;
    List<Spell> Spells;
    public MageSpells()
    {
      InitializeComponent();
      DatabaseConnector db = new DatabaseConnector();
      Spells = db.GetMageSpell();
      
      foreach(Spell spell in Spells)
      {
        lb_Available.Items.Add(spell.Name);
      }

      //storage = new Storage();

      //for(int i = 0; i < storage.MageSpells.Count; i++)
      //{
      //  lb_Available.Items.Add(storage.MageSpells[i].Name);
      //}

      //foreach(Spell s in storage.MageSpells)
      //{
      //  lb_Available.Items.Add(s.Name);
      //}


    }

    private void lb_Available_SelectedIndexChanged(object sender, EventArgs e)
    {
      foreach(Spell s in Spells)
      {
        if(lb_Available.Text == s.Name)
        {
          lb_Description.Text = String.Format("Description:{0}",s.Description);
          return;
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      lb_Learned.Items.Add(lb_Available.Text);
      lb_Available.Items.Remove(lb_Available.Text);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      string path = "C:\\Test\\Wizard";
      if(Directory.Exists(path))
      {
        path += string.Format("\\{0}", "Test");
        using (FileStream fs = File.Create(path))
        {
          if (lb_Learned.Text == "")
          {
            byte[] info = new UTF8Encoding(true).GetBytes(string.Format("Spell:{0} ", lb_Learned.Items[0].ToString()));
            // Add some information to the file.
            fs.Write(info, 0, info.Length);
            fs.Close();
            this.Close();
            //****************************************************
            // TESTING AREA DELETE LATER
            Combat combatForm = new Combat(path);
            combatForm.Show();
          }
        }
      }
      else
      {
        Directory.CreateDirectory(path);
        path += string.Format("\\{0}", "Test");
        using (FileStream fs = File.Create(path))
        {
          byte[] info = new UTF8Encoding(true).GetBytes(string.Format("Spell:{0} ", lb_Available.Text));
          // Add some information to the file.
          fs.Write(info, 0, info.Length);
        }
      }
      
    }
  }
}
