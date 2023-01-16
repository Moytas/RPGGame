namespace RPGGame
{
  partial class Weapons
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lb_Available = new System.Windows.Forms.ListBox();
      this.lb_Learned = new System.Windows.Forms.ListBox();
      this.lb_Mastered = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lb_Available
      // 
      this.lb_Available.FormattingEnabled = true;
      this.lb_Available.ItemHeight = 15;
      this.lb_Available.Items.AddRange(new object[] {
            "Sword",
            "Spear",
            "Axe",
            "Knife",
            "Mace",
            "Claymore"});
      this.lb_Available.Location = new System.Drawing.Point(38, 166);
      this.lb_Available.Name = "lb_Available";
      this.lb_Available.Size = new System.Drawing.Size(120, 94);
      this.lb_Available.TabIndex = 0;
      // 
      // lb_Learned
      // 
      this.lb_Learned.FormattingEnabled = true;
      this.lb_Learned.ItemHeight = 15;
      this.lb_Learned.Location = new System.Drawing.Point(279, 166);
      this.lb_Learned.Name = "lb_Learned";
      this.lb_Learned.Size = new System.Drawing.Size(120, 94);
      this.lb_Learned.TabIndex = 1;
      // 
      // lb_Mastered
      // 
      this.lb_Mastered.FormattingEnabled = true;
      this.lb_Mastered.ItemHeight = 15;
      this.lb_Mastered.Location = new System.Drawing.Point(524, 166);
      this.lb_Mastered.Name = "lb_Mastered";
      this.lb_Mastered.Size = new System.Drawing.Size(120, 94);
      this.lb_Mastered.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(297, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(136, 15);
      this.label1.TabIndex = 3;
      this.label1.Text = "Select weapon masteries";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(51, 134);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(107, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "Available Weapons";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(297, 134);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(49, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "Learned";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(540, 134);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(56, 15);
      this.label4.TabIndex = 6;
      this.label4.Text = "Mastered";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(185, 176);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 7;
      this.button1.Text = ">>";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(185, 224);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 8;
      this.button2.Text = "<<";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(424, 176);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 9;
      this.button3.Text = ">>";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(424, 224);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 23);
      this.button4.TabIndex = 10;
      this.button4.Text = "<<";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // Weapons
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(668, 334);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lb_Mastered);
      this.Controls.Add(this.lb_Learned);
      this.Controls.Add(this.lb_Available);
      this.Name = "Weapons";
      this.Text = "Weapons";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private ListBox lb_Available;
        private ListBox lb_Learned;
        private ListBox lb_Mastered;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}