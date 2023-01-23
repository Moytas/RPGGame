namespace RPGGame
{
  partial class Combat
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.lb_Spells = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(49, 184);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Weapon Attack";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(147, 184);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Spell";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(49, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 15);
      this.label1.TabIndex = 2;
      this.label1.Text = "label1";
      // 
      // lb_Spells
      // 
      this.lb_Spells.FormattingEnabled = true;
      this.lb_Spells.ItemHeight = 15;
      this.lb_Spells.Location = new System.Drawing.Point(327, 43);
      this.lb_Spells.Name = "lb_Spells";
      this.lb_Spells.Size = new System.Drawing.Size(75, 124);
      this.lb_Spells.TabIndex = 3;
      this.lb_Spells.Visible = false;
      // 
      // Combat
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(470, 262);
      this.Controls.Add(this.lb_Spells);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Combat";
      this.Text = "Combat";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private ListBox lb_Spells;
    }
}