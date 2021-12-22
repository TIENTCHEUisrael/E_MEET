
namespace E_MEET.Windforms.OutilsWindforms
{
    partial class MyMessageBox
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ButtonNon = new E_MEET.Windforms.OutilsWindforms.Mybutton();
            this.ButtonOui = new E_MEET.Windforms.OutilsWindforms.Mybutton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Have you account?";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Panel2
            // 
            this.Panel2.Location = new System.Drawing.Point(12, 219);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(319, 10);
            this.Panel2.TabIndex = 3;
            // 
            // ButtonNon
            // 
            this.ButtonNon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonNon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonNon.Bordercolor = System.Drawing.Color.DodgerBlue;
            this.ButtonNon.BorderRadius = 40;
            this.ButtonNon.BorderSize = 0;
            this.ButtonNon.FlatAppearance.BorderSize = 0;
            this.ButtonNon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNon.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNon.ForeColor = System.Drawing.Color.White;
            this.ButtonNon.Location = new System.Drawing.Point(181, 142);
            this.ButtonNon.Name = "ButtonNon";
            this.ButtonNon.Size = new System.Drawing.Size(150, 62);
            this.ButtonNon.TabIndex = 2;
            this.ButtonNon.Text = "Non";
            this.ButtonNon.TextColor = System.Drawing.Color.White;
            this.ButtonNon.UseVisualStyleBackColor = false;
            this.ButtonNon.Click += new System.EventHandler(this.ButtonNon_Click);
            // 
            // ButtonOui
            // 
            this.ButtonOui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonOui.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonOui.Bordercolor = System.Drawing.Color.DodgerBlue;
            this.ButtonOui.BorderRadius = 40;
            this.ButtonOui.BorderSize = 0;
            this.ButtonOui.FlatAppearance.BorderSize = 0;
            this.ButtonOui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOui.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOui.ForeColor = System.Drawing.Color.White;
            this.ButtonOui.Location = new System.Drawing.Point(12, 142);
            this.ButtonOui.Name = "ButtonOui";
            this.ButtonOui.Size = new System.Drawing.Size(150, 62);
            this.ButtonOui.TabIndex = 1;
            this.ButtonOui.Text = "Oui";
            this.ButtonOui.TextColor = System.Drawing.Color.White;
            this.ButtonOui.UseVisualStyleBackColor = false;
            this.ButtonOui.Click += new System.EventHandler(this.ButtonOui_Click);
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 241);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.ButtonNon);
            this.Controls.Add(this.ButtonOui);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyMessageBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Mybutton ButtonOui;
        private Mybutton ButtonNon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Panel2;
    }
}