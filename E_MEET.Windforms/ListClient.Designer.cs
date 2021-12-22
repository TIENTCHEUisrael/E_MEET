
namespace E_MEET.Windforms
{
    partial class ListClient
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
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Mybutton1 = new E_MEET.Windforms.OutilsWindforms.Mybutton();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(12, 56);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(322, 290);
            this.ListBox1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Location = new System.Drawing.Point(69, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(216, 39);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "List Of Client";
            // 
            // Mybutton1
            // 
            this.Mybutton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Mybutton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Mybutton1.Bordercolor = System.Drawing.Color.DodgerBlue;
            this.Mybutton1.BorderRadius = 40;
            this.Mybutton1.BorderSize = 0;
            this.Mybutton1.FlatAppearance.BorderSize = 0;
            this.Mybutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mybutton1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mybutton1.ForeColor = System.Drawing.Color.White;
            this.Mybutton1.Location = new System.Drawing.Point(103, 352);
            this.Mybutton1.Name = "Mybutton1";
            this.Mybutton1.Size = new System.Drawing.Size(150, 50);
            this.Mybutton1.TabIndex = 2;
            this.Mybutton1.Text = "Back";
            this.Mybutton1.TextColor = System.Drawing.Color.White;
            this.Mybutton1.UseVisualStyleBackColor = false;
            this.Mybutton1.Click += new System.EventHandler(this.Mybutton1_Click);
            // 
            // ListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 404);
            this.Controls.Add(this.Mybutton1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListClient";
            this.Load += new System.EventHandler(this.ListClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Label Label1;
        private OutilsWindforms.Mybutton Mybutton1;
    }
}