
namespace E_MEET.Windforms.User_sControl
{
    partial class E_AddAppoint
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
            this.ListView1 = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sexe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Localisation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mybutton3 = new E_MEET.Windforms.OutilsWindforms.Mybutton();
            this.Mybutton2 = new E_MEET.Windforms.OutilsWindforms.Mybutton();
            this.Mybutton1 = new E_MEET.Windforms.OutilsWindforms.Mybutton();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Prenom,
            this.Email,
            this.Contact,
            this.Sexe,
            this.Localisation});
            this.ListView1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.GridLines = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(35, 76);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(769, 343);
            this.ListView1.TabIndex = 0;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 113;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.Width = 116;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 133;
            // 
            // Contact
            // 
            this.Contact.Text = "Contact";
            this.Contact.Width = 118;
            // 
            // Sexe
            // 
            this.Sexe.Text = "Sexe";
            this.Sexe.Width = 79;
            // 
            // Localisation
            // 
            this.Localisation.Text = "Localisation";
            this.Localisation.Width = 213;
            // 
            // Mybutton3
            // 
            this.Mybutton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Mybutton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Mybutton3.Bordercolor = System.Drawing.Color.DodgerBlue;
            this.Mybutton3.BorderRadius = 40;
            this.Mybutton3.BorderSize = 0;
            this.Mybutton3.FlatAppearance.BorderSize = 0;
            this.Mybutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mybutton3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mybutton3.ForeColor = System.Drawing.Color.White;
            this.Mybutton3.Location = new System.Drawing.Point(822, 333);
            this.Mybutton3.Name = "Mybutton3";
            this.Mybutton3.Size = new System.Drawing.Size(150, 52);
            this.Mybutton3.TabIndex = 3;
            this.Mybutton3.Text = "Set";
            this.Mybutton3.TextColor = System.Drawing.Color.White;
            this.Mybutton3.UseVisualStyleBackColor = false;
            this.Mybutton3.Click += new System.EventHandler(this.Mybutton3_Click);
            // 
            // Mybutton2
            // 
            this.Mybutton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Mybutton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Mybutton2.Bordercolor = System.Drawing.Color.DodgerBlue;
            this.Mybutton2.BorderRadius = 40;
            this.Mybutton2.BorderSize = 0;
            this.Mybutton2.FlatAppearance.BorderSize = 0;
            this.Mybutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mybutton2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mybutton2.ForeColor = System.Drawing.Color.White;
            this.Mybutton2.Location = new System.Drawing.Point(822, 214);
            this.Mybutton2.Name = "Mybutton2";
            this.Mybutton2.Size = new System.Drawing.Size(150, 52);
            this.Mybutton2.TabIndex = 2;
            this.Mybutton2.Text = "Delete";
            this.Mybutton2.TextColor = System.Drawing.Color.White;
            this.Mybutton2.UseVisualStyleBackColor = false;
            // 
            // Mybutton1
            // 
            this.Mybutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Mybutton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Mybutton1.Bordercolor = System.Drawing.Color.DodgerBlue;
            this.Mybutton1.BorderRadius = 40;
            this.Mybutton1.BorderSize = 0;
            this.Mybutton1.FlatAppearance.BorderSize = 0;
            this.Mybutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mybutton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mybutton1.ForeColor = System.Drawing.Color.White;
            this.Mybutton1.Location = new System.Drawing.Point(822, 103);
            this.Mybutton1.Name = "Mybutton1";
            this.Mybutton1.Size = new System.Drawing.Size(150, 55);
            this.Mybutton1.TabIndex = 1;
            this.Mybutton1.Text = "Add Appoint";
            this.Mybutton1.TextColor = System.Drawing.Color.White;
            this.Mybutton1.UseVisualStyleBackColor = false;
            this.Mybutton1.Click += new System.EventHandler(this.Mybutton1_Click);
            // 
            // E_AddAppoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Mybutton3);
            this.Controls.Add(this.Mybutton2);
            this.Controls.Add(this.Mybutton1);
            this.Controls.Add(this.ListView1);
            this.Name = "E_AddAppoint";
            this.Size = new System.Drawing.Size(996, 451);
            this.Load += new System.EventHandler(this.E_AddAppoint_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListView1;
        private OutilsWindforms.Mybutton Mybutton1;
        private OutilsWindforms.Mybutton Mybutton2;
        private OutilsWindforms.Mybutton Mybutton3;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Contact;
        private System.Windows.Forms.ColumnHeader Sexe;
        private System.Windows.Forms.ColumnHeader Localisation;
    }
}
