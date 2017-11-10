namespace penztargep
{
    partial class Form2
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
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.tb_felhasznalonev = new System.Windows.Forms.TextBox();
            this.tb_jelszo = new System.Windows.Forms.TextBox();
            this.tb_jelszoujra = new System.Windows.Forms.TextBox();
            this.lbl_nev = new System.Windows.Forms.Label();
            this.lbl_felhasznalonev = new System.Windows.Forms.Label();
            this.lbl_jelszo = new System.Windows.Forms.Label();
            this.lbl_jelszoujra = new System.Windows.Forms.Label();
            this.btn_regisztracio = new System.Windows.Forms.Button();
            this.btn_vissza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(117, 13);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(172, 20);
            this.tb_nev.TabIndex = 0;
            // 
            // tb_felhasznalonev
            // 
            this.tb_felhasznalonev.Location = new System.Drawing.Point(117, 39);
            this.tb_felhasznalonev.Name = "tb_felhasznalonev";
            this.tb_felhasznalonev.Size = new System.Drawing.Size(172, 20);
            this.tb_felhasznalonev.TabIndex = 1;
            // 
            // tb_jelszo
            // 
            this.tb_jelszo.Location = new System.Drawing.Point(117, 65);
            this.tb_jelszo.Name = "tb_jelszo";
            this.tb_jelszo.Size = new System.Drawing.Size(172, 20);
            this.tb_jelszo.TabIndex = 2;
            // 
            // tb_jelszoujra
            // 
            this.tb_jelszoujra.Location = new System.Drawing.Point(117, 91);
            this.tb_jelszoujra.Name = "tb_jelszoujra";
            this.tb_jelszoujra.Size = new System.Drawing.Size(172, 20);
            this.tb_jelszoujra.TabIndex = 3;
            // 
            // lbl_nev
            // 
            this.lbl_nev.AutoSize = true;
            this.lbl_nev.Location = new System.Drawing.Point(12, 16);
            this.lbl_nev.Name = "lbl_nev";
            this.lbl_nev.Size = new System.Drawing.Size(27, 13);
            this.lbl_nev.TabIndex = 4;
            this.lbl_nev.Text = "Név";
            // 
            // lbl_felhasznalonev
            // 
            this.lbl_felhasznalonev.AutoSize = true;
            this.lbl_felhasznalonev.Location = new System.Drawing.Point(11, 42);
            this.lbl_felhasznalonev.Name = "lbl_felhasznalonev";
            this.lbl_felhasznalonev.Size = new System.Drawing.Size(81, 13);
            this.lbl_felhasznalonev.TabIndex = 5;
            this.lbl_felhasznalonev.Text = "Felhasználónév";
            // 
            // lbl_jelszo
            // 
            this.lbl_jelszo.AutoSize = true;
            this.lbl_jelszo.Location = new System.Drawing.Point(11, 68);
            this.lbl_jelszo.Name = "lbl_jelszo";
            this.lbl_jelszo.Size = new System.Drawing.Size(36, 13);
            this.lbl_jelszo.TabIndex = 6;
            this.lbl_jelszo.Text = "Jelszó";
            // 
            // lbl_jelszoujra
            // 
            this.lbl_jelszoujra.AutoSize = true;
            this.lbl_jelszoujra.Location = new System.Drawing.Point(11, 94);
            this.lbl_jelszoujra.Name = "lbl_jelszoujra";
            this.lbl_jelszoujra.Size = new System.Drawing.Size(56, 13);
            this.lbl_jelszoujra.TabIndex = 7;
            this.lbl_jelszoujra.Text = "Jelszó újra";
            // 
            // btn_regisztracio
            // 
            this.btn_regisztracio.Location = new System.Drawing.Point(117, 133);
            this.btn_regisztracio.Name = "btn_regisztracio";
            this.btn_regisztracio.Size = new System.Drawing.Size(172, 39);
            this.btn_regisztracio.TabIndex = 8;
            this.btn_regisztracio.Text = "Regisztráció";
            this.btn_regisztracio.UseVisualStyleBackColor = true;
            this.btn_regisztracio.Click += new System.EventHandler(this.btn_regisztracio_Click);
            // 
            // btn_vissza
            // 
            this.btn_vissza.Location = new System.Drawing.Point(117, 178);
            this.btn_vissza.Name = "btn_vissza";
            this.btn_vissza.Size = new System.Drawing.Size(172, 39);
            this.btn_vissza.TabIndex = 9;
            this.btn_vissza.Text = "Vissza";
            this.btn_vissza.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 255);
            this.Controls.Add(this.btn_vissza);
            this.Controls.Add(this.btn_regisztracio);
            this.Controls.Add(this.lbl_jelszoujra);
            this.Controls.Add(this.lbl_jelszo);
            this.Controls.Add(this.lbl_felhasznalonev);
            this.Controls.Add(this.lbl_nev);
            this.Controls.Add(this.tb_jelszoujra);
            this.Controls.Add(this.tb_jelszo);
            this.Controls.Add(this.tb_felhasznalonev);
            this.Controls.Add(this.tb_nev);
            this.Name = "Form2";
            this.Text = "Regisztracio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.TextBox tb_felhasznalonev;
        private System.Windows.Forms.TextBox tb_jelszo;
        private System.Windows.Forms.TextBox tb_jelszoujra;
        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.Label lbl_felhasznalonev;
        private System.Windows.Forms.Label lbl_jelszo;
        private System.Windows.Forms.Label lbl_jelszoujra;
        private System.Windows.Forms.Button btn_regisztracio;
        private System.Windows.Forms.Button btn_vissza;
    }
}