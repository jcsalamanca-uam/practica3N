namespace practica3N
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbPass = new System.Windows.Forms.TextBox();
            this.TbName = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TbConfirmPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo electronico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // TbLastName
            // 
            this.TbLastName.Location = new System.Drawing.Point(271, 71);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(263, 26);
            this.TbLastName.TabIndex = 4;
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(271, 132);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(263, 26);
            this.TbEmail.TabIndex = 5;
            // 
            // TbPass
            // 
            this.TbPass.Location = new System.Drawing.Point(271, 204);
            this.TbPass.Name = "TbPass";
            this.TbPass.PasswordChar = '*';
            this.TbPass.Size = new System.Drawing.Size(263, 26);
            this.TbPass.TabIndex = 6;
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(271, 23);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(263, 26);
            this.TbName.TabIndex = 7;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(271, 348);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(100, 40);
            this.BtnRegister.TabIndex = 8;
            this.BtnRegister.Text = "Registrar";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirmar contraseña";
            // 
            // TbConfirmPass
            // 
            this.TbConfirmPass.Location = new System.Drawing.Point(271, 278);
            this.TbConfirmPass.Name = "TbConfirmPass";
            this.TbConfirmPass.PasswordChar = '*';
            this.TbConfirmPass.Size = new System.Drawing.Size(263, 26);
            this.TbConfirmPass.TabIndex = 10;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbConfirmPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.TbPass);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TbLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbPass;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbConfirmPass;
    }
}