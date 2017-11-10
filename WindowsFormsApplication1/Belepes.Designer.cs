namespace WindowsFormsApplication1
{
    partial class Belepes
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_felhasznalonev = new System.Windows.Forms.Label();
            this.lbl_jelszo = new System.Windows.Forms.Label();
            this.btn_belepes = new System.Windows.Forms.Button();
            this.btn_vissza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 1;
            // 
            // lbl_felhasznalonev
            // 
            this.lbl_felhasznalonev.AutoSize = true;
            this.lbl_felhasznalonev.Location = new System.Drawing.Point(12, 46);
            this.lbl_felhasznalonev.Name = "lbl_felhasznalonev";
            this.lbl_felhasznalonev.Size = new System.Drawing.Size(81, 13);
            this.lbl_felhasznalonev.TabIndex = 2;
            this.lbl_felhasznalonev.Text = "Felhasználónév";
            // 
            // lbl_jelszo
            // 
            this.lbl_jelszo.AutoSize = true;
            this.lbl_jelszo.Location = new System.Drawing.Point(12, 72);
            this.lbl_jelszo.Name = "lbl_jelszo";
            this.lbl_jelszo.Size = new System.Drawing.Size(36, 13);
            this.lbl_jelszo.TabIndex = 3;
            this.lbl_jelszo.Text = "Jelszó";
            // 
            // btn_belepes
            // 
            this.btn_belepes.Location = new System.Drawing.Point(99, 121);
            this.btn_belepes.Name = "btn_belepes";
            this.btn_belepes.Size = new System.Drawing.Size(135, 42);
            this.btn_belepes.TabIndex = 4;
            this.btn_belepes.Text = "Belépés";
            this.btn_belepes.UseVisualStyleBackColor = true;
            // 
            // btn_vissza
            // 
            this.btn_vissza.Location = new System.Drawing.Point(99, 169);
            this.btn_vissza.Name = "btn_vissza";
            this.btn_vissza.Size = new System.Drawing.Size(135, 42);
            this.btn_vissza.TabIndex = 5;
            this.btn_vissza.Text = "Vissza";
            this.btn_vissza.UseVisualStyleBackColor = true;
            this.btn_vissza.Click += new System.EventHandler(this.btn_vissza_Click);
            // 
            // Belepes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 261);
            this.Controls.Add(this.btn_vissza);
            this.Controls.Add(this.btn_belepes);
            this.Controls.Add(this.lbl_jelszo);
            this.Controls.Add(this.lbl_felhasznalonev);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Belepes";
            this.Text = "Belepes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_felhasznalonev;
        private System.Windows.Forms.Label lbl_jelszo;
        private System.Windows.Forms.Button btn_belepes;
        private System.Windows.Forms.Button btn_vissza;
    }
}