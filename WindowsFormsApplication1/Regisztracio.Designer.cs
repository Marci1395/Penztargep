namespace WindowsFormsApplication1
{
    partial class Regisztracio
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
            this.txt_nev = new System.Windows.Forms.TextBox();
            this.txt_szuletesi_ido = new System.Windows.Forms.TextBox();
            this.txt_lakcim = new System.Windows.Forms.TextBox();
            this.txt_felhasznalonev = new System.Windows.Forms.TextBox();
            this.lbl_nev = new System.Windows.Forms.Label();
            this.lbl_szuletesi_ido = new System.Windows.Forms.Label();
            this.lbl_lakcim = new System.Windows.Forms.Label();
            this.lbl_felhasznalonev = new System.Windows.Forms.Label();
            this.btn_felvitel = new System.Windows.Forms.Button();
            this.btn_vissza = new System.Windows.Forms.Button();
            this.txt_jelszo = new System.Windows.Forms.TextBox();
            this.lbl_jelszo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nev
            // 
            this.txt_nev.Location = new System.Drawing.Point(159, 57);
            this.txt_nev.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nev.Name = "txt_nev";
            this.txt_nev.Size = new System.Drawing.Size(251, 22);
            this.txt_nev.TabIndex = 0;
            // 
            // txt_szuletesi_ido
            // 
            this.txt_szuletesi_ido.Location = new System.Drawing.Point(159, 89);
            this.txt_szuletesi_ido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_szuletesi_ido.Name = "txt_szuletesi_ido";
            this.txt_szuletesi_ido.Size = new System.Drawing.Size(251, 22);
            this.txt_szuletesi_ido.TabIndex = 1;
            // 
            // txt_lakcim
            // 
            this.txt_lakcim.Location = new System.Drawing.Point(159, 121);
            this.txt_lakcim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lakcim.Name = "txt_lakcim";
            this.txt_lakcim.Size = new System.Drawing.Size(251, 22);
            this.txt_lakcim.TabIndex = 2;
            // 
            // txt_felhasznalonev
            // 
            this.txt_felhasznalonev.Location = new System.Drawing.Point(159, 153);
            this.txt_felhasznalonev.Margin = new System.Windows.Forms.Padding(4);
            this.txt_felhasznalonev.Name = "txt_felhasznalonev";
            this.txt_felhasznalonev.Size = new System.Drawing.Size(251, 22);
            this.txt_felhasznalonev.TabIndex = 3;
            // 
            // lbl_nev
            // 
            this.lbl_nev.AutoSize = true;
            this.lbl_nev.Location = new System.Drawing.Point(43, 60);
            this.lbl_nev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nev.Name = "lbl_nev";
            this.lbl_nev.Size = new System.Drawing.Size(33, 17);
            this.lbl_nev.TabIndex = 4;
            this.lbl_nev.Text = "Név";
            // 
            // lbl_szuletesi_ido
            // 
            this.lbl_szuletesi_ido.AutoSize = true;
            this.lbl_szuletesi_ido.Location = new System.Drawing.Point(43, 92);
            this.lbl_szuletesi_ido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_szuletesi_ido.Name = "lbl_szuletesi_ido";
            this.lbl_szuletesi_ido.Size = new System.Drawing.Size(88, 17);
            this.lbl_szuletesi_ido.TabIndex = 5;
            this.lbl_szuletesi_ido.Text = "Születési idő";
            // 
            // lbl_lakcim
            // 
            this.lbl_lakcim.AutoSize = true;
            this.lbl_lakcim.Location = new System.Drawing.Point(43, 124);
            this.lbl_lakcim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lakcim.Name = "lbl_lakcim";
            this.lbl_lakcim.Size = new System.Drawing.Size(52, 17);
            this.lbl_lakcim.TabIndex = 6;
            this.lbl_lakcim.Text = "Lakcím";
            // 
            // lbl_felhasznalonev
            // 
            this.lbl_felhasznalonev.AutoSize = true;
            this.lbl_felhasznalonev.Location = new System.Drawing.Point(43, 156);
            this.lbl_felhasznalonev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_felhasznalonev.Name = "lbl_felhasznalonev";
            this.lbl_felhasznalonev.Size = new System.Drawing.Size(107, 17);
            this.lbl_felhasznalonev.TabIndex = 7;
            this.lbl_felhasznalonev.Text = "Felhasználónév";
            // 
            // btn_felvitel
            // 
            this.btn_felvitel.Location = new System.Drawing.Point(184, 249);
            this.btn_felvitel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_felvitel.Name = "btn_felvitel";
            this.btn_felvitel.Size = new System.Drawing.Size(205, 48);
            this.btn_felvitel.TabIndex = 8;
            this.btn_felvitel.Text = "Felvitel";
            this.btn_felvitel.UseVisualStyleBackColor = true;
            this.btn_felvitel.Click += new System.EventHandler(this.btn_felvitel_Click);
            // 
            // btn_vissza
            // 
            this.btn_vissza.Location = new System.Drawing.Point(184, 305);
            this.btn_vissza.Margin = new System.Windows.Forms.Padding(4);
            this.btn_vissza.Name = "btn_vissza";
            this.btn_vissza.Size = new System.Drawing.Size(205, 48);
            this.btn_vissza.TabIndex = 9;
            this.btn_vissza.Text = "Vissza";
            this.btn_vissza.UseVisualStyleBackColor = true;
            this.btn_vissza.Click += new System.EventHandler(this.btn_vissza_Click);
            // 
            // txt_jelszo
            // 
            this.txt_jelszo.Location = new System.Drawing.Point(159, 183);
            this.txt_jelszo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jelszo.Name = "txt_jelszo";
            this.txt_jelszo.Size = new System.Drawing.Size(251, 22);
            this.txt_jelszo.TabIndex = 10;
            // 
            // lbl_jelszo
            // 
            this.lbl_jelszo.AutoSize = true;
            this.lbl_jelszo.Location = new System.Drawing.Point(43, 188);
            this.lbl_jelszo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_jelszo.Name = "lbl_jelszo";
            this.lbl_jelszo.Size = new System.Drawing.Size(48, 17);
            this.lbl_jelszo.TabIndex = 12;
            this.lbl_jelszo.Text = "Jelszó";
            // 
            // Regisztracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 458);
            this.Controls.Add(this.lbl_jelszo);
            this.Controls.Add(this.txt_jelszo);
            this.Controls.Add(this.btn_vissza);
            this.Controls.Add(this.btn_felvitel);
            this.Controls.Add(this.lbl_felhasznalonev);
            this.Controls.Add(this.lbl_lakcim);
            this.Controls.Add(this.lbl_szuletesi_ido);
            this.Controls.Add(this.lbl_nev);
            this.Controls.Add(this.txt_felhasznalonev);
            this.Controls.Add(this.txt_lakcim);
            this.Controls.Add(this.txt_szuletesi_ido);
            this.Controls.Add(this.txt_nev);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Regisztracio";
            this.Text = "Regisztracio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nev;
        private System.Windows.Forms.TextBox txt_szuletesi_ido;
        private System.Windows.Forms.TextBox txt_lakcim;
        private System.Windows.Forms.TextBox txt_felhasznalonev;
        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.Label lbl_szuletesi_ido;
        private System.Windows.Forms.Label lbl_lakcim;
        private System.Windows.Forms.Label lbl_felhasznalonev;
        private System.Windows.Forms.Button btn_felvitel;
        private System.Windows.Forms.Button btn_vissza;
        private System.Windows.Forms.TextBox txt_jelszo;
        private System.Windows.Forms.Label lbl_jelszo;
    }
}