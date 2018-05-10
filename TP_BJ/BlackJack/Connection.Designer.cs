namespace Partie
{
    partial class Connection
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
            this.imgConnection = new System.Windows.Forms.PictureBox();
            this.lblConnection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // imgConnection
            // 
            this.imgConnection.Image = global::BlackJack.RessImages.rideau;
            this.imgConnection.Location = new System.Drawing.Point(-6, -4);
            this.imgConnection.Name = "imgConnection";
            this.imgConnection.Size = new System.Drawing.Size(1225, 581);
            this.imgConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgConnection.TabIndex = 0;
            this.imgConnection.TabStop = false;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.BackColor = System.Drawing.Color.Transparent;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.ForeColor = System.Drawing.Color.Yellow;
            this.lblConnection.Location = new System.Drawing.Point(384, 176);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(412, 69);
            this.lblConnection.TabIndex = 1;
            this.lblConnection.Text = "Connection ...";
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.RessImages.rideau;
            this.ClientSize = new System.Drawing.Size(1215, 572);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.imgConnection);
            this.Name = "Connection";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgConnection;
        private System.Windows.Forms.Label lblConnection;
    }
}