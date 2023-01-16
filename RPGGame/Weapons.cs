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
  public partial class Weapons : Form
  {
    public Weapons()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      if (lb_Available.Text != "" && lb_Available.Text != string.Empty)
      {
        lb_Learned.Items.Add(lb_Available.Text);
        lb_Available.Items.Remove(lb_Available.Text);
      }

    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (lb_Learned.Text != "" && lb_Learned.Text != string.Empty)
      {
        lb_Available.Items.Add(lb_Learned.Text);
        lb_Learned.Items.Remove(lb_Learned.Text);
      }
    }
  }
}
