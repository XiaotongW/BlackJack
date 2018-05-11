namespace BlackJack
{
    partial class MenuOption
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
            this.txtArgent = new System.Windows.Forms.TextBox();
            this.txtMiseMin = new System.Windows.Forms.TextBox();
            this.txtMiseMax = new System.Windows.Forms.TextBox();
            this.txtNbPaquet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtArgent
            // 
            this.txtArgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArgent.Location = new System.Drawing.Point(203, 16);
            this.txtArgent.Name = "txtArgent";
            this.txtArgent.Size = new System.Drawing.Size(137, 30);
            this.txtArgent.TabIndex = 0;
            this.txtArgent.Text = "1000";
            this.txtArgent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArgent_KeyPress);
            // 
            // txtMiseMin
            // 
            this.txtMiseMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiseMin.Location = new System.Drawing.Point(203, 52);
            this.txtMiseMin.Name = "txtMiseMin";
            this.txtMiseMin.Size = new System.Drawing.Size(137, 30);
            this.txtMiseMin.TabIndex = 1;
            this.txtMiseMin.Text = "1";
            this.txtMiseMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiseMin_KeyPress);
            // 
            // txtMiseMax
            // 
            this.txtMiseMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiseMax.Location = new System.Drawing.Point(203, 88);
            this.txtMiseMax.Name = "txtMiseMax";
            this.txtMiseMax.Size = new System.Drawing.Size(137, 30);
            this.txtMiseMax.TabIndex = 2;
            this.txtMiseMax.Text = "500";
            this.txtMiseMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiseMax_KeyPress);
            // 
            // txtNbPaquet
            // 
            this.txtNbPaquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbPaquet.Location = new System.Drawing.Point(203, 121);
            this.txtNbPaquet.Name = "txtNbPaquet";
            this.txtNbPaquet.Size = new System.Drawing.Size(31, 30);
            this.txtNbPaquet.TabIndex = 3;
            this.txtNbPaquet.Text = "2";
            this.txtNbPaquet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNbPaquet_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Argent de départ :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mise minimum :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mise maximum :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre de paquets :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Location = new System.Drawing.Point(97, 157);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(149, 44);
            this.btnAppliquer.TabIndex = 8;
            this.btnAppliquer.Text = "Appliquer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            // 
            // MenuOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(357, 203);
            this.Controls.Add(this.btnAppliquer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNbPaquet);
            this.Controls.Add(this.txtMiseMax);
            this.Controls.Add(this.txtMiseMin);
            this.Controls.Add(this.txtArgent);
            this.MaximumSize = new System.Drawing.Size(375, 250);
            this.MinimumSize = new System.Drawing.Size(375, 250);
            this.Name = "MenuOption";
            this.Text = "Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArgent;
        private System.Windows.Forms.TextBox txtMiseMin;
        private System.Windows.Forms.TextBox txtMiseMax;
        private System.Windows.Forms.TextBox txtNbPaquet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAppliquer;
    }
}