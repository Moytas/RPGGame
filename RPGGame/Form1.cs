using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text;

namespace RPGGame
{

  public partial class Form1 : Form
  {
    int index = 0;
    int _str, _dex, _con, _int, _wis, _cha;
    string filePath;

    public Form1()
    {
      InitializeComponent();
      InitialSettings();
      filePath = @"C:\Test\";
    }

    void InitialSettings()
    {
      panel1.Visible = false;
      btn_Roll.Enabled = false;
    }

        private void cb_ClassChoise_SelectedIndexChanged(object sender, EventArgs e)
        {
      switch (cb_ClassChoise.Text)
      {
        case "Fighter":
          Fighter f = new Fighter(tb_Name.Text, _str, _dex, _con, _int, _wis, _cha);
          filePath += @"Fighter\";
          if(File.Exists(filePath))
          {
            using (FileStream fs = File.Create(filePath))
            {
              byte[] info = new UTF8Encoding(true).GetBytes(f.Name);
              // Add some information to the file.
              fs.Write(info, 0, info.Length);
            }
          }
          else
          {
            Directory.CreateDirectory(filePath);
            filePath += "fighter.txt";
                        using (FileStream fs = File.Create(filePath))
            {
              byte[] info = new UTF8Encoding(true).GetBytes(string.Format("Name:{0} str:{1} ... ",f.Name,f.STRENGTH));
              // Add some information to the file.
              fs.Write(info, 0, info.Length);
            }
          }
          break;
        case "Thief":
          Thief t = new Thief(tb_Name.Text, _str, _dex, _con, _int, _wis, _cha);
          break;
        case "Priest":
          Priest p = new Priest(tb_Name.Text, _str, _dex, _con, _int, _wis, _cha);
          break;
        case "Mage":
          Mage m = new Mage(tb_Name.Text, _str, _dex, _con, _int, _wis, _cha);
          break;
          //default:
          //  Fighter f = new Fighter(tb_Name.Text, _str, _dex, _con, _int, _wis, _cha);
          //  index = -1;
          //  break;
      }

      btn_Accept.Location = new Point(cb_ClassChoise.Location.X,cb_ClassChoise.Location.Y + 30);
        }

        private void Btn_Start_Click(object sender, EventArgs e)
    {
      panel1.Visible = true;
    }

    private void btn_Accept_Click(object sender, EventArgs e)
    {
      btn_Roll.Enabled = true;

      if(cb_ClassChoise.Visible)
      {
        switch(cb_ClassChoise.Text)
        {
          case "Fighter":
            //using (var ctx = new DBCreator())
            //{
            //  var fighter = new Fighter() { Name = "Test" };
              
            //  ctx.Fighters.Add(fighter);
            //  ctx.SaveChanges();
            //}

            Weapons weaponsForm = new Weapons();
            weaponsForm.Show();
            break;
          case "Wizard":
            MageSpells mageForm = new MageSpells();
            mageForm.Show();
            break;
          case "Thief":
            ThiefSkills thiefForm = new ThiefSkills();
            thiefForm.Show();
            break;
        }
        
      }
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
        //Player p = new Player(tb_Name.Text, _str, _dex, _con, _int, _wis, _cha);

        //**************************************
        //FOR TESTING DELETE LATER!!!!!
        if(_int < 9)
        {
          _int = 10;
        }
        //****************************************

        cb_ClassChoise.Visible = true;
        btn_Roll.Visible = false;

        cb_ClassChoise.Items.Clear();
        

        if(_str >= 9)
        {
          cb_ClassChoise.Items.Add("Fighter");
        }

        if (_dex >= 9)
        {
          cb_ClassChoise.Items.Add("Thief");
        }
        if (_wis >= 9)
        {
          cb_ClassChoise.Items.Add("Priest");
        }

        if (_int >= 9)
        {
          cb_ClassChoise.Items.Add("Wizard");
        }

        if(cb_ClassChoise.Items.Count == 0)
        {
          Reset();
        }
      }
    }

    void Reset()
    {
      if(btn_Roll.Visible == false)
      {
        btn_Roll.Visible = true;
      }
      index = 0;
      lbl_Str.Text = "Str";
      lbl_Dex.Text = "Dex";
      lbl_Con.Text = "Con";
      lbl_Int.Text = "Int";
      lbl_Wis.Text = "Wis";
      lbl_Cha.Text = "char";
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
