namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btn_regisztracio = new System.Windows.Forms.Button();
            this.btn_belepes = new System.Windows.Forms.Button();
            this.btn_adatmodositas = new System.Windows.Forms.Button();
            this.btn_kilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_regisztracio
            // 
            this.btn_regisztracio.Location = new System.Drawing.Point(94, 33);
            this.btn_regisztracio.Name = "btn_regisztracio";
            this.btn_regisztracio.Size = new System.Drawing.Size(149, 52);
            this.btn_regisztracio.TabIndex = 0;
            this.btn_regisztracio.Text = "Regisztráció";
            this.btn_regisztracio.UseVisualStyleBackColor = true;
            this.btn_regisztracio.Click += new System.EventHandler(this.btn_regisztracio_Click);
            // 
            // btn_belepes
            // 
            this.btn_belepes.Location = new System.Drawing.Point(94, 91);
            this.btn_belepes.Name = "btn_belepes";
            this.btn_belepes.Size = new System.Drawing.Size(149, 52);
            this.btn_belepes.TabIndex = 1;
            this.btn_belepes.Text = "Belépés";
            this.btn_belepes.UseVisualStyleBackColor = true;
            this.btn_belepes.Click += new System.EventHandler(this.btn_belepes_Click);
            // 
            // btn_adatmodositas
            // 
            this.btn_adatmodositas.Location = new System.Drawing.Point(94, 149);
            this.btn_adatmodositas.Name = "btn_adatmodositas";
            this.btn_adatmodositas.Size = new System.Drawing.Size(149, 52);
            this.btn_adatmodositas.TabIndex = 2;
            this.btn_adatmodositas.Text = "Adatmódosítás";
            this.btn_adatmodositas.UseVisualStyleBackColor = true;
            // 
            // btn_kilepes
            // 
            this.btn_kilepes.Location = new System.Drawing.Point(94, 207);
            this.btn_kilepes.Name = "btn_kilepes";
            this.btn_kilepes.Size = new System.Drawing.Size(149, 52);
            this.btn_kilepes.TabIndex = 3;
            this.btn_kilepes.Text = "Kilépés";
            this.btn_kilepes.UseVisualStyleBackColor = true;
            this.btn_kilepes.Click += new System.EventHandler(this.btn_kilepes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 294);
            this.Controls.Add(this.btn_kilepes);
            this.Controls.Add(this.btn_adatmodositas);
            this.Controls.Add(this.btn_belepes);
            this.Controls.Add(this.btn_regisztracio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_regisztracio;
        private System.Windows.Forms.Button btn_belepes;
        private System.Windows.Forms.Button btn_adatmodositas;
        private System.Windows.Forms.Button btn_kilepes;
    }
}

