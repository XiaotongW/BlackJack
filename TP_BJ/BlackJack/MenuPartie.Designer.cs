namespace Partie
{
   partial class MenuPartie
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
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.cmbJoueur = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnHeberger = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnRejoindre = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpMenu.Controls.Add(this.btnRejoindre);
            this.grpMenu.Controls.Add(this.btnCreer);
            this.grpMenu.Controls.Add(this.txtIP);
            this.grpMenu.Controls.Add(this.lblNom);
            this.grpMenu.Controls.Add(this.btnConnection);
            this.grpMenu.Controls.Add(this.btnHeberger);
            this.grpMenu.Controls.Add(this.txtNom);
            this.grpMenu.Controls.Add(this.cmbJoueur);
            this.grpMenu.Location = new System.Drawing.Point(26, 417);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(620, 159);
            this.grpMenu.TabIndex = 3;
            this.grpMenu.TabStop = false;
            // 
            // cmbJoueur
            // 
            this.cmbJoueur.AutoCompleteCustomSource.AddRange(new string[] {
            "1 Joueur",
            "2 Joueurs",
            "3 Joueurs",
            "4 Joueurs"});
            this.cmbJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJoueur.FormattingEnabled = true;
            this.cmbJoueur.Location = new System.Drawing.Point(249, 45);
            this.cmbJoueur.Name = "cmbJoueur";
            this.cmbJoueur.Size = new System.Drawing.Size(121, 28);
            this.cmbJoueur.TabIndex = 0;
            this.cmbJoueur.Visible = false;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(249, 13);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 26);
            this.txtNom.TabIndex = 1;
            // 
            // btnHeberger
            // 
            this.btnHeberger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeberger.Location = new System.Drawing.Point(219, 85);
            this.btnHeberger.Name = "btnHeberger";
            this.btnHeberger.Size = new System.Drawing.Size(177, 49);
            this.btnHeberger.TabIndex = 2;
            this.btnHeberger.Text = "Héberger";
            this.btnHeberger.UseVisualStyleBackColor = true;
            this.btnHeberger.Visible = false;
            this.btnHeberger.Click += new System.EventHandler(this.btnHeberger_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(219, 85);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(177, 49);
            this.btnConnection.TabIndex = 3;
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Visible = false;
            this.btnConnection.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(201, 19);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom : ";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(249, 45);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(121, 26);
            this.txtIP.TabIndex = 5;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.Visible = false;
            // 
            // btnCreer
            // 
            this.btnCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreer.Location = new System.Drawing.Point(182, 57);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(120, 49);
            this.btnCreer.TabIndex = 6;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnRejoindre
            // 
            this.btnRejoindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejoindre.Location = new System.Drawing.Point(317, 57);
            this.btnRejoindre.Name = "btnRejoindre";
            this.btnRejoindre.Size = new System.Drawing.Size(120, 49);
            this.btnRejoindre.TabIndex = 7;
            this.btnRejoindre.Text = "Rejoindre";
            this.btnRejoindre.UseVisualStyleBackColor = true;
            this.btnRejoindre.Click += new System.EventHandler(this.btnRejoindre_Click);
            // 
            // picMenu
            // 
            this.picMenu.BackgroundImage = global::Partie.RessImages.menu_blackjack;
            this.picMenu.InitialImage = global::Partie.RessImages.menu_blackjack;
            this.picMenu.Location = new System.Drawing.Point(-2, 0);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(674, 396);
            this.picMenu.TabIndex = 0;
            this.picMenu.TabStop = false;
            // 
            // MenuPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(671, 598);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.picMenu);
            this.Name = "MenuPartie";
            this.Text = "MenuPartie";
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnHeberger;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cmbJoueur;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnRejoindre;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.TextBox txtIP;
    }
}