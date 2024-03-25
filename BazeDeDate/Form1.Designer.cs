using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BazeDeDate
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

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
            this.LogIn = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.Parola = new System.Windows.Forms.Label();
            this.user_email = new System.Windows.Forms.TextBox();
            this.user_password = new System.Windows.Forms.TextBox();
            this.MaxiPet = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogIn
            // 
            this.LogIn.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.Location = new System.Drawing.Point(633, 357);
            this.LogIn.Margin = new System.Windows.Forms.Padding(6);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(116, 45);
            this.LogIn.TabIndex = 0;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // Email
            // 
            this.Email.AccessibleName = "Email";
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(448, 251);
            this.Email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(60, 23);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email";
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parola.Location = new System.Drawing.Point(451, 298);
            this.Parola.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(64, 23);
            this.Parola.TabIndex = 2;
            this.Parola.Text = "Parola";
            // 
            // user_email
            // 
            this.user_email.Location = new System.Drawing.Point(553, 246);
            this.user_email.Margin = new System.Windows.Forms.Padding(6);
            this.user_email.Name = "user_email";
            this.user_email.Size = new System.Drawing.Size(196, 31);
            this.user_email.TabIndex = 3;
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(553, 298);
            this.user_password.Margin = new System.Windows.Forms.Padding(6);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(196, 31);
            this.user_password.TabIndex = 4;
            // 
            // MaxiPet
            // 
            this.MaxiPet.AutoSize = true;
            this.MaxiPet.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxiPet.Location = new System.Drawing.Point(508, 119);
            this.MaxiPet.Name = "MaxiPet";
            this.MaxiPet.Size = new System.Drawing.Size(188, 49);
            this.MaxiPet.TabIndex = 5;
            this.MaxiPet.Text = "Maxi Pet";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(452, 357);
            this.Clear.Margin = new System.Windows.Forms.Padding(6);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(116, 45);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(150, 465);
            this.Exit.Margin = new System.Windows.Forms.Padding(6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(139, 51);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 746);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.MaxiPet);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_email);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LogIn);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Parola;
        private System.Windows.Forms.TextBox user_email;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Label MaxiPet;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;





    }
}

