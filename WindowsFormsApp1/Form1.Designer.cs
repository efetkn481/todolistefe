namespace WindowsFormsApp1
{
    partial class todolist
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
            this.TxtMessage1 = new System.Windows.Forms.TextBox();
            this.TxtMessage2 = new System.Windows.Forms.TextBox();
            this.TxtMessage3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ChcEkle1 = new System.Windows.Forms.CheckBox();
            this.ChcEkle2 = new System.Windows.Forms.CheckBox();
            this.ChcEkle3 = new System.Windows.Forms.CheckBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtMessage1
            // 
            this.TxtMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMessage1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtMessage1.Location = new System.Drawing.Point(36, 12);
            this.TxtMessage1.Multiline = true;
            this.TxtMessage1.Name = "TxtMessage1";
            this.TxtMessage1.Size = new System.Drawing.Size(124, 28);
            this.TxtMessage1.TabIndex = 1;
            // 
            // TxtMessage2
            // 
            this.TxtMessage2.Location = new System.Drawing.Point(36, 82);
            this.TxtMessage2.Multiline = true;
            this.TxtMessage2.Name = "TxtMessage2";
            this.TxtMessage2.Size = new System.Drawing.Size(124, 29);
            this.TxtMessage2.TabIndex = 2;
            // 
            // TxtMessage3
            // 
            this.TxtMessage3.Location = new System.Drawing.Point(36, 156);
            this.TxtMessage3.Multiline = true;
            this.TxtMessage3.Name = "TxtMessage3";
            this.TxtMessage3.Size = new System.Drawing.Size(124, 23);
            this.TxtMessage3.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(520, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 228);
            this.listBox1.TabIndex = 5;
            // 
            // ChcEkle1
            // 
            this.ChcEkle1.AutoSize = true;
            this.ChcEkle1.Location = new System.Drawing.Point(183, 20);
            this.ChcEkle1.Name = "ChcEkle1";
            this.ChcEkle1.Size = new System.Drawing.Size(56, 20);
            this.ChcEkle1.TabIndex = 6;
            this.ChcEkle1.Text = "Ekle";
            this.ChcEkle1.UseVisualStyleBackColor = true;
            this.ChcEkle1.CheckedChanged += new System.EventHandler(this.ChcEkle1_CheckedChanged);
            // 
            // ChcEkle2
            // 
            this.ChcEkle2.AutoSize = true;
            this.ChcEkle2.Location = new System.Drawing.Point(183, 91);
            this.ChcEkle2.Name = "ChcEkle2";
            this.ChcEkle2.Size = new System.Drawing.Size(56, 20);
            this.ChcEkle2.TabIndex = 7;
            this.ChcEkle2.Text = "Ekle";
            this.ChcEkle2.UseVisualStyleBackColor = true;
            this.ChcEkle2.CheckedChanged += new System.EventHandler(this.ChcEkle2_CheckedChanged);
            // 
            // ChcEkle3
            // 
            this.ChcEkle3.AutoSize = true;
            this.ChcEkle3.Location = new System.Drawing.Point(183, 159);
            this.ChcEkle3.Name = "ChcEkle3";
            this.ChcEkle3.Size = new System.Drawing.Size(56, 20);
            this.ChcEkle3.TabIndex = 8;
            this.ChcEkle3.Text = "Ekle";
            this.ChcEkle3.UseVisualStyleBackColor = true;
            this.ChcEkle3.CheckedChanged += new System.EventHandler(this.ChcEkle3_CheckedChanged);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(545, 259);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(117, 23);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Temizle";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // todolist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.ChcEkle3);
            this.Controls.Add(this.ChcEkle2);
            this.Controls.Add(this.ChcEkle1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TxtMessage3);
            this.Controls.Add(this.TxtMessage2);
            this.Controls.Add(this.TxtMessage1);
            this.Name = "todolist";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.todolist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtMessage1;
        private System.Windows.Forms.TextBox TxtMessage2;
        private System.Windows.Forms.TextBox TxtMessage3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox ChcEkle1;
        private System.Windows.Forms.CheckBox ChcEkle2;
        private System.Windows.Forms.CheckBox ChcEkle3;
        private System.Windows.Forms.Button BtnClear;
    }
}

