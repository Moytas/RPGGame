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
  public partial class ThiefSkills : Form
  {
    int pointsPool = 60;
    int limit = 30;

    int ol_valueInit,pp_valueInit;
    int pp_value, ol_value, cw_value, hs_value, frt_value, rl_value;

    private void button3_Click(object sender, EventArgs e)
    {
      if (pointsPool < 60)
      {

        if (pp_value > pp_valueInit)
        {
          pointsPool++;
          pp_value--;
        }
        lbl_pp.Text = "Open locks: " + pp_value;
        ShowPoints();
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (pointsPool > 0 && pp_value < pp_valueInit + limit)
      {
        pointsPool--;
        pp_value++;
        lbl_pp.Text = "Pick pockets: " + pp_value;
        ShowPoints();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if(pointsPool < 60)
      {
        
        if(ol_value > ol_valueInit)
        {
          pointsPool++;
          ol_value--;
        }
        lbl_ol.Text = "Open locks: " + ol_value;
        ShowPoints();
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if(pointsPool > 0 && ol_value < ol_valueInit + limit)
      {
        pointsPool--;
        ol_value++;
        lbl_ol.Text = "Open locks: " + ol_value;
        ShowPoints();
      }
    }

    public ThiefSkills()
    {
      InitializeComponent();
      InitializeValues();
      ShowPoints();
    }

    void InitializeValues()
    {
      pp_valueInit = 10;
      pp_value = pp_valueInit;
      ol_valueInit = 10;
      ol_value = ol_valueInit;
      cw_value = 10;
      hs_value = 20;
      frt_value = 30;
      rl_value = 30;

      lbl_cw.Text = String.Format("Climb walls:{0}",cw_value);
      lbl_frt.Text = String.Format("Find/Remove traps:{0}",frt_value);
      lbl_hs.Text = String.Format("Hide in Shadows:{0}",hs_value);

    }

    void ShowPoints()
    {
      label1.Text = "Remaining points: " + pointsPool;
    }
  }
}
