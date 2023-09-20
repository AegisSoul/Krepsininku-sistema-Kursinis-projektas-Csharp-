
namespace Krepsininku_sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegUsername = new System.Windows.Forms.TextBox();
            this.RegPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RegPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Reg_RegisterButton = new System.Windows.Forms.Button();
            this.Reg_ClearFields = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RegBackToLOGIN = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Registration_ExitButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(283, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registracija";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(287, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vartotojo vardas";
            // 
            // RegUsername
            // 
            this.RegUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegUsername.Location = new System.Drawing.Point(290, 94);
            this.RegUsername.Multiline = true;
            this.RegUsername.Name = "RegUsername";
            this.RegUsername.Size = new System.Drawing.Size(181, 27);
            this.RegUsername.TabIndex = 2;
            this.RegUsername.TextChanged += new System.EventHandler(this.RegUsername_TextChanged);
            // 
            // RegPassword
            // 
            this.RegPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPassword.Location = new System.Drawing.Point(290, 154);
            this.RegPassword.Multiline = true;
            this.RegPassword.Name = "RegPassword";
            this.RegPassword.PasswordChar = '*';
            this.RegPassword.Size = new System.Drawing.Size(181, 27);
            this.RegPassword.TabIndex = 4;
            this.RegPassword.UseSystemPasswordChar = true;
            this.RegPassword.TextChanged += new System.EventHandler(this.RegPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(287, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Slaptažodis";
            // 
            // RegPasswordConfirm
            // 
            this.RegPasswordConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPasswordConfirm.Location = new System.Drawing.Point(290, 216);
            this.RegPasswordConfirm.Multiline = true;
            this.RegPasswordConfirm.Name = "RegPasswordConfirm";
            this.RegPasswordConfirm.PasswordChar = '*';
            this.RegPasswordConfirm.Size = new System.Drawing.Size(181, 27);
            this.RegPasswordConfirm.TabIndex = 6;
            this.RegPasswordConfirm.UseSystemPasswordChar = true;
            this.RegPasswordConfirm.TextChanged += new System.EventHandler(this.RegPasswordConfirm_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(287, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pakartoti slaptažodį";
            // 
            // Reg_RegisterButton
            // 
            this.Reg_RegisterButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Reg_RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reg_RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reg_RegisterButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg_RegisterButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Reg_RegisterButton.Location = new System.Drawing.Point(290, 274);
            this.Reg_RegisterButton.Name = "Reg_RegisterButton";
            this.Reg_RegisterButton.Size = new System.Drawing.Size(181, 35);
            this.Reg_RegisterButton.TabIndex = 7;
            this.Reg_RegisterButton.Text = "Registruotis";
            this.Reg_RegisterButton.UseVisualStyleBackColor = false;
            this.Reg_RegisterButton.Click += new System.EventHandler(this.Reg_RegisterButton_Click);
            // 
            // Reg_ClearFields
            // 
            this.Reg_ClearFields.BackColor = System.Drawing.SystemColors.Window;
            this.Reg_ClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reg_ClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reg_ClearFields.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg_ClearFields.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Reg_ClearFields.Location = new System.Drawing.Point(290, 315);
            this.Reg_ClearFields.Name = "Reg_ClearFields";
            this.Reg_ClearFields.Size = new System.Drawing.Size(181, 35);
            this.Reg_ClearFields.TabIndex = 8;
            this.Reg_ClearFields.Text = "Išvalyti laukus";
            this.Reg_ClearFields.UseVisualStyleBackColor = false;
            this.Reg_ClearFields.Click += new System.EventHandler(this.Reg_ClearFields_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(286, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jau turi susikūręs paskyrą?";
            // 
            // RegBackToLOGIN
            // 
            this.RegBackToLOGIN.AutoSize = true;
            this.RegBackToLOGIN.BackColor = System.Drawing.Color.Transparent;
            this.RegBackToLOGIN.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBackToLOGIN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RegBackToLOGIN.Location = new System.Drawing.Point(310, 394);
            this.RegBackToLOGIN.Name = "RegBackToLOGIN";
            this.RegBackToLOGIN.Size = new System.Drawing.Size(146, 21);
            this.RegBackToLOGIN.TabIndex = 10;
            this.RegBackToLOGIN.Text = "Grįžti į prisijungimą";
            this.RegBackToLOGIN.Click += new System.EventHandler(this.RegBackToLOGIN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1057, 592);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Registration_ExitButton
            // 
            this.Registration_ExitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Registration_ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration_ExitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_ExitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.Registration_ExitButton.Location = new System.Drawing.Point(607, 384);
            this.Registration_ExitButton.Name = "Registration_ExitButton";
            this.Registration_ExitButton.Size = new System.Drawing.Size(181, 34);
            this.Registration_ExitButton.TabIndex = 14;
            this.Registration_ExitButton.Text = "&Išeiti";
            this.Registration_ExitButton.UseVisualStyleBackColor = false;
            this.Registration_ExitButton.Click += new System.EventHandler(this.Registration_ExitButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkBox1.Location = new System.Drawing.Point(290, 248);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 21);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Paslėpti";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Registration_ExitButton);
            this.Controls.Add(this.RegBackToLOGIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Reg_ClearFields);
            this.Controls.Add(this.Reg_RegisterButton);
            this.Controls.Add(this.RegPasswordConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RegUsername;
        private System.Windows.Forms.TextBox RegPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegPasswordConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reg_RegisterButton;
        private System.Windows.Forms.Button Reg_ClearFields;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RegBackToLOGIN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Registration_ExitButton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}