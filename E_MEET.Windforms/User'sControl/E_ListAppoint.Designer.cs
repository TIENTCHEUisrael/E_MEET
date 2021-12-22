
namespace E_MEET.Windforms.User_sControl
{
    partial class E_ListAppoint
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mybutton1 = new E_MEET.Windforms.OutilsWindforms.Mybutton();
            this.SuspendLayout();
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
            this.Mybutton1.Location = new System.Drawing.Point(24, 382);
            this.Mybutton1.Name = "Mybutton1";
            this.Mybutton1.Size = new System.Drawing.Size(150, 53);
            this.Mybutton1.TabIndex = 0;
            this.Mybutton1.Text = "Set Appoint";
            this.Mybutton1.TextColor = System.Drawing.Color.White;
            this.Mybutton1.UseVisualStyleBackColor = false;
            this.Mybutton1.Click += new System.EventHandler(this.Mybutton1_Click);
            // 
            // E_ListAppoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Mybutton1);
            this.Name = "E_ListAppoint";
            this.Size = new System.Drawing.Size(996, 451);
            this.Load += new System.EventHandler(this.E_ListAppoint_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private OutilsWindforms.Mybutton Mybutton1;
    }
}
