namespace BlackJack
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
			this.btnRejoindre = new System.Windows.Forms.Button();
			this.btnCreer = new System.Windows.Forms.Button();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.lblNom = new System.Windows.Forms.Label();
			this.btnConnection = new System.Windows.Forms.Button();
			this.btnHeberger = new System.Windows.Forms.Button();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.cmbJoueur = new System.Windows.Forms.ComboBox();
			this.picMenu = new System.Windows.Forms.PictureBox();
			this.btnOption = new System.Windows.Forms.Button();
			this.grpMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
			this.SuspendLayout();
			// 
			// grpMenu
			// 
			this.grpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.grpMenu.Controls.Add(this.btnOption);
			this.grpMenu.Controls.Add(this.btnRejoindre);
			this.grpMenu.Controls.Add(this.btnCreer);
			this.grpMenu.Controls.Add(this.txtIP);
			this.grpMenu.Controls.Add(this.lblNom);
			this.grpMenu.Controls.Add(this.btnConnection);
			this.grpMenu.Controls.Add(this.btnHeberger);
			this.grpMenu.Controls.Add(this.txtNom);
			this.grpMenu.Controls.Add(this.cmbJoueur);
			this.grpMenu.Location = new System.Drawing.Point(35, 513);
			this.grpMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grpMenu.Name = "grpMenu";
			this.grpMenu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grpMenu.Size = new System.Drawing.Size(827, 196);
			this.grpMenu.TabIndex = 3;
			this.grpMenu.TabStop = false;
			// 
			// btnRejoindre
			// 
			this.btnRejoindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRejoindre.Location = new System.Drawing.Point(423, 70);
			this.btnRejoindre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRejoindre.Name = "btnRejoindre";
			this.btnRejoindre.Size = new System.Drawing.Size(160, 60);
			this.btnRejoindre.TabIndex = 7;
			this.btnRejoindre.Text = "Rejoindre";
			this.btnRejoindre.UseVisualStyleBackColor = true;
			this.btnRejoindre.Click += new System.EventHandler(this.btnRejoindre_Click);
			// 
			// btnCreer
			// 
			this.btnCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreer.Location = new System.Drawing.Point(243, 70);
			this.btnCreer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCreer.Name = "btnCreer";
			this.btnCreer.Size = new System.Drawing.Size(160, 60);
			this.btnCreer.TabIndex = 6;
			this.btnCreer.Text = "Créer";
			this.btnCreer.UseVisualStyleBackColor = true;
			this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
			// 
			// txtIP
			// 
			this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIP.Location = new System.Drawing.Point(332, 55);
			this.txtIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(160, 30);
			this.txtIP.TabIndex = 5;
			this.txtIP.Text = "127.0.0.1";
			this.txtIP.Visible = false;
			// 
			// lblNom
			// 
			this.lblNom.AutoSize = true;
			this.lblNom.Location = new System.Drawing.Point(268, 23);
			this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNom.Name = "lblNom";
			this.lblNom.Size = new System.Drawing.Size(49, 17);
			this.lblNom.TabIndex = 4;
			this.lblNom.Text = "Nom : ";
			// 
			// btnConnection
			// 
			this.btnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConnection.Location = new System.Drawing.Point(292, 105);
			this.btnConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnConnection.Name = "btnConnection";
			this.btnConnection.Size = new System.Drawing.Size(236, 60);
			this.btnConnection.TabIndex = 3;
			this.btnConnection.Text = "Connection";
			this.btnConnection.UseVisualStyleBackColor = true;
			this.btnConnection.Visible = false;
			this.btnConnection.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnHeberger
			// 
			this.btnHeberger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHeberger.Location = new System.Drawing.Point(292, 105);
			this.btnHeberger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnHeberger.Name = "btnHeberger";
			this.btnHeberger.Size = new System.Drawing.Size(236, 60);
			this.btnHeberger.TabIndex = 2;
			this.btnHeberger.Text = "Héberger";
			this.btnHeberger.UseVisualStyleBackColor = true;
			this.btnHeberger.Visible = false;
			this.btnHeberger.Click += new System.EventHandler(this.btnHeberger_Click);
			// 
			// txtNom
			// 
			this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNom.Location = new System.Drawing.Point(332, 16);
			this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(160, 30);
			this.txtNom.TabIndex = 1;
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
			this.cmbJoueur.Location = new System.Drawing.Point(332, 55);
			this.cmbJoueur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbJoueur.Name = "cmbJoueur";
			this.cmbJoueur.Size = new System.Drawing.Size(160, 33);
			this.cmbJoueur.TabIndex = 0;
			this.cmbJoueur.Visible = false;
			// 
			// picMenu
			// 
			this.picMenu.BackgroundImage = global::BlackJack.RessImages.menu_blackjack;
			this.picMenu.InitialImage = global::BlackJack.RessImages.menu_blackjack;
			this.picMenu.Location = new System.Drawing.Point(-3, 0);
			this.picMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picMenu.Name = "picMenu";
			this.picMenu.Size = new System.Drawing.Size(899, 487);
			this.picMenu.TabIndex = 0;
			this.picMenu.TabStop = false;
			// 
			// btnOption
			// 
			this.btnOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOption.Location = new System.Drawing.Point(591, 105);
			this.btnOption.Margin = new System.Windows.Forms.Padding(4);
			this.btnOption.Name = "btnOption";
			this.btnOption.Size = new System.Drawing.Size(113, 61);
			this.btnOption.TabIndex = 8;
			this.btnOption.Text = "Option";
			this.btnOption.UseVisualStyleBackColor = true;
			this.btnOption.Visible = false;
			// 
			// MenuPartie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(895, 736);
			this.Controls.Add(this.grpMenu);
			this.Controls.Add(this.picMenu);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
		private System.Windows.Forms.Button btnOption;
	}
}