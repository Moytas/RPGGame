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

    public MageSpells()
    {
      InitializeComponent();
      storage = new Storage();

      //for(int i = 0; i < storage.MageSpells.Count; i++)
      //{
      //  lb_Available.Items.Add(storage.MageSpells[i].Name);
      //}

      foreach(Spell s in storage.MageSpells)
      {
        lb_Available.Items.Add(s.Name);
      }


    }

    private void lb_Available_SelectedIndexChanged(object sender, EventArgs e)
    {
      foreach(Spell s in storage.MageSpells)
      {
        if(lb_Available.Text == s.Name)
        {
          lb_Description.Text = String.Format("Description:{0}",s.Description);
          return;
        }
      }
    }

    
  }
}
