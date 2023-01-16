namespace RPGGame
{
  partial class MageSpells
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lb_Description = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lb_Available
      // 
      this.lb_Available.FormattingEnabled = true;
      this.lb_Available.ItemHeight = 15;
      this.lb_Available.Location = new System.Drawing.Point(62, 71);
      this.lb_Available.Name = "lb_Available";
      this.lb_Available.Size = new System.Drawing.Size(229, 199);
      this.lb_Available.TabIndex = 0;
      this.lb_Available.SelectedIndexChanged += new System.EventHandler(this.lb_Available_SelectedIndexChanged);
      // 
      // lb_Learned
      // 
      this.lb_Learned.FormattingEnabled = true;
      this.lb_Learned.ItemHeight = 15;
      this.lb_Learned.Location = new System.Drawing.Point(485, 71);
      this.lb_Learned.Name = "lb_Learned";
      this.lb_Learned.Size = new System.Drawing.Size(171, 199);
      this.lb_Learned.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(363, 140);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(363, 197);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 3;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(93, 42);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 15);
      this.label1.TabIndex = 4;
      this.label1.Text = "Available";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(547, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(49, 15);
      this.label2.TabIndex = 5;
      this.label2.Text = "Learned";
      // 
      // lb_Description
      // 
      this.lb_Description.AutoSize = true;
      this.lb_Description.Location = new System.Drawing.Point(84, 296);
      this.lb_Description.Name = "lb_Description";
      this.lb_Description.Size = new System.Drawing.Size(70, 15);
      this.lb_Description.TabIndex = 6;
      this.lb_Description.Text = "Description:";
      // 
      // MageSpells
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lb_Description);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.lb_Learned);
      this.Controls.Add(this.lb_Available);
      this.Name = "MageSpells";
      this.Text = "MageSpells";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private ListBox lb_Available;
        private ListBox lb_Learned;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label lb_Description;
    }
}