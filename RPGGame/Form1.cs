using System.Security.Cryptography.X509Certificates;

namespace RPGGame
{
  public partial class Form1 : Form
  {
    int index = 0;
    int _str, _dex, _con, _int, _wis, _cha;

    public Form1()
    {
      InitializeComponent();
      InitialSettings();      
    }

    void InitialSettings()
    {
      panel1.Visible = false;
      btn_Roll.Enabled = false;
    }

    private void Btn_Start_Click(object sender, EventArgs e)
    {
      panel1.Visible = true;
    }

    private void btn_Accept_Click(object sender, EventArgs e)
    {
      btn_Roll.Enabled = true;
    }

    private void btn_Roll_Click(object sender, EventArgs e)
    {
      switch(index)
      {
        case 0:
          _str = RollStat();
          lbl_Str.Text = String.Format("Strength:{0}", _str);
          break;
        case 1:
          _dex = RollStat();
          lbl_Dex.Text = String.Format("Dexterity:{0}", _dex);
          break;
        case 2:
          _con = RollStat();
          lbl_Con.Text = String.Format("Constitution:{0}",_con);
          break;
        case 3:
          _int = RollStat();
          lbl_Int.Text = String.Format("Intelligence:{0}", _int);
          break;
        case 4:
          _wis = RollStat();
          lbl_Wis.Text = String.Format("Wisdom:{0}",_wis);
          break;
        case 5:
          _cha = RollStat();
          lbl_Cha.Text = String.Format("Charisma:{0}", _cha);
          break;
      }
      if (index < 6)
      {
        index++;
      }
      else
      {
        Player p = new Player()
      }
    }

    int RollStat()
    {
      int returnValue = 0;
      Random rand = new Random();
      for (int i = 0; i < 3; i++)
      {
        returnValue += rand.Next(1, 6);
      }
      return returnValue;
    }
}

}
