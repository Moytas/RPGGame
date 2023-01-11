namespace RPGGame
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.Btn_Start = new System.Windows.Forms.Button();
      this.btn_Exit = new System.Windows.Forms.Button();
      this.lbl_Name = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cb_ClassChoise = new System.Windows.Forms.ComboBox();
      this.lbl_Cha = new System.Windows.Forms.Label();
      this.lbl_Wis = new System.Windows.Forms.Label();
      this.lbl_Int = new System.Windows.Forms.Label();
      this.lbl_Con = new System.Windows.Forms.Label();
      this.lbl_Dex = new System.Windows.Forms.Label();
      this.btn_Roll = new System.Windows.Forms.Button();
      this.lbl_Str = new System.Windows.Forms.Label();
      this.btn_Accept = new System.Windows.Forms.Button();
      this.tb_Name = new System.Windows.Forms.TextBox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Btn_Start
      // 
      this.Btn_Start.Location = new System.Drawing.Point(325, 95);
      this.Btn_Start.Name = "Btn_Start";
      this.Btn_Start.Size = new System.Drawing.Size(75, 23);
      this.Btn_Start.TabIndex = 0;
      this.Btn_Start.Text = "Start";
      this.Btn_Start.UseVisualStyleBackColor = true;
      this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
      // 
      // btn_Exit
      // 
      this.btn_Exit.Location = new System.Drawing.Point(374, 305);
      this.btn_Exit.Name = "btn_Exit";
      this.btn_Exit.Size = new System.Drawing.Size(75, 23);
      this.btn_Exit.TabIndex = 1;
      this.btn_Exit.Text = "Exit";
      this.btn_Exit.UseVisualStyleBackColor = true;
      // 
      // lbl_Name
      // 
      this.lbl_Name.AutoSize = true;
      this.lbl_Name.Location = new System.Drawing.Point(22, 21);
      this.lbl_Name.Name = "lbl_Name";
      this.lbl_Name.Size = new System.Drawing.Size(39, 15);
      this.lbl_Name.TabIndex = 2;
      this.lbl_Name.Text = "Name";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Tomato;
      this.panel1.Controls.Add(this.cb_ClassChoise);
      this.panel1.Controls.Add(this.lbl_Cha);
      this.panel1.Controls.Add(this.lbl_Wis);
      this.panel1.Controls.Add(this.lbl_Int);
      this.panel1.Controls.Add(this.lbl_Con);
      this.panel1.Controls.Add(this.lbl_Dex);
      this.panel1.Controls.Add(this.btn_Roll);
      this.panel1.Controls.Add(this.lbl_Str);
      this.panel1.Controls.Add(this.btn_Accept);
      this.panel1.Controls.Add(this.tb_Name);
      this.panel1.Controls.Add(this.lbl_Name);
      this.panel1.Location = new System.Drawing.Point(49, 23);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(643, 305);
      this.panel1.TabIndex = 3;
      this.panel1.Visible = false;
      // 
      // cb_ClassChoise
      // 
      this.cb_ClassChoise.FormattingEnabled = true;
      this.cb_ClassChoise.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
      this.cb_ClassChoise.Location = new System.Drawing.Point(424, 38);
      this.cb_ClassChoise.Name = "cb_ClassChoise";
      this.cb_ClassChoise.Size = new System.Drawing.Size(121, 23);
      this.cb_ClassChoise.TabIndex = 12;
      this.cb_ClassChoise.Visible = false;
      // 
      // lbl_Cha
      // 
      this.lbl_Cha.AutoSize = true;
      this.lbl_Cha.Location = new System.Drawing.Point(23, 243);
      this.lbl_Cha.Name = "lbl_Cha";
      this.lbl_Cha.Size = new System.Drawing.Size(57, 15);
      this.lbl_Cha.TabIndex = 11;
      this.lbl_Cha.Text = "Charisma";
      // 
      // lbl_Wis
      // 
      this.lbl_Wis.AutoSize = true;
      this.lbl_Wis.Location = new System.Drawing.Point(23, 214);
      this.lbl_Wis.Name = "lbl_Wis";
      this.lbl_Wis.Size = new System.Drawing.Size(51, 15);
      this.lbl_Wis.TabIndex = 10;
      this.lbl_Wis.Text = "Wisdom";
      // 
      // lbl_Int
      // 
      this.lbl_Int.AutoSize = true;
      this.lbl_Int.Location = new System.Drawing.Point(23, 181);
      this.lbl_Int.Name = "lbl_Int";
      this.lbl_Int.Size = new System.Drawing.Size(68, 15);
      this.lbl_Int.TabIndex = 9;
      this.lbl_Int.Text = "Intelligence";
      // 
      // lbl_Con
      // 
      this.lbl_Con.AutoSize = true;
      this.lbl_Con.Location = new System.Drawing.Point(23, 151);
      this.lbl_Con.Name = "lbl_Con";
      this.lbl_Con.Size = new System.Drawing.Size(73, 15);
      this.lbl_Con.TabIndex = 8;
      this.lbl_Con.Text = "Constitution";
      // 
      // lbl_Dex
      // 
      this.lbl_Dex.AutoSize = true;
      this.lbl_Dex.Location = new System.Drawing.Point(23, 120);
      this.lbl_Dex.Name = "lbl_Dex";
      this.lbl_Dex.Size = new System.Drawing.Size(54, 15);
      this.lbl_Dex.TabIndex = 7;
      this.lbl_Dex.Text = "Dexterity";
      // 
      // btn_Roll
      // 
      this.btn_Roll.Location = new System.Drawing.Point(227, 88);
      this.btn_Roll.Name = "btn_Roll";
      this.btn_Roll.Size = new System.Drawing.Size(75, 23);
      this.btn_Roll.TabIndex = 6;
      this.btn_Roll.Text = "Roll";
      this.btn_Roll.UseVisualStyleBackColor = true;
      this.btn_Roll.Click += new System.EventHandler(this.btn_Roll_Click);
      // 
      // lbl_Str
      // 
      this.lbl_Str.AutoSize = true;
      this.lbl_Str.Location = new System.Drawing.Point(22, 92);
      this.lbl_Str.Name = "lbl_Str";
      this.lbl_Str.Size = new System.Drawing.Size(52, 15);
      this.lbl_Str.TabIndex = 5;
      this.lbl_Str.Text = "Strength";
      // 
      // btn_Accept
      // 
      this.btn_Accept.Location = new System.Drawing.Point(249, 21);
      this.btn_Accept.Name = "btn_Accept";
      this.btn_Accept.Size = new System.Drawing.Size(75, 23);
      this.btn_Accept.TabIndex = 4;
      this.btn_Accept.Text = "Accept";
      this.btn_Accept.UseVisualStyleBackColor = true;
      this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
      // 
      // tb_Name
      // 
      this.tb_Name.Location = new System.Drawing.Point(89, 18);
      this.tb_Name.Name = "tb_Name";
      this.tb_Name.Size = new System.Drawing.Size(100, 23);
      this.tb_Name.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.btn_Exit);
      this.Controls.Add(this.Btn_Start);
      this.Name = "Form1";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private Button Btn_Start;
        private Button btn_Exit;
        private Label lbl_Name;
        private Panel panel1;
        private Button btn_Accept;
        private TextBox tb_Name;
    private Label lbl_Str;
    private Button btn_Roll;
    private Label lbl_Cha;
    private Label lbl_Wis;
    private Label lbl_Int;
    private Label lbl_Con;
    private Label lbl_Dex;
    private ComboBox cb_ClassChoise;
  }
}