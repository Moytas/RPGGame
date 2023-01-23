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
  public partial class Combat : Form
  {
    public Combat()
    {
      InitializeComponent();

    }

    public Combat(string filePath)
    {
      InitializeComponent();
      if(File.Exists(filePath))
      {
        using(StreamReader sr = new StreamReader(filePath))
        {
          string txt = sr.ReadToEnd();
          txt = txt.Split(':')[1];
          lb_Spells.Items.Add(txt);
          sr.Close();
        }
      }
    }


        private void button2_Click(object sender, EventArgs e)
        {

      //if(lb_Spells.Enabled == true)
      //{
      //  lb_Spells.Enabled = false;
      //}  
      //else
      //{
      //  lb_Spells.Enabled = true;
      //}
          lb_Spells.Visible = !lb_Spells.Visible;
      if(lb_Spells.Visible)
      {
        button2.Text = "Cast Spell";
        if(lb_Spells.SelectedItem != null)
        {
          lb_Spells.Items.Remove(lb_Spells.Text);
        }
      }
      else
      {
        button2.Text = "Spells";
      }

        }

    private void button1_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      int roll = rand.Next(1, 21);

      if (roll == 1)
      {
        label1.Text = "Critical Miss!";
      } else if (roll == 20)
      {
        label1.Text = "Critical Hit!";
      }
      else
      {
        label1.Text = String.Format("You rolled a {0}!! vs Armor Class {1} = ", roll, 10);
        
        string x = 10 - roll < 0 ? "Hit" : "Miss";
        
        if (10 - roll < 0)
        { 
          x = "Hit"; 
        }
        else
        {
          x = "Miss";
        } 
      }
    }
  }
}
