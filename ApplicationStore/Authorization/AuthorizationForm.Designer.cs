namespace ApplicationStore_AuthorizationForm
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginlabel = new System.Windows.Forms.Label();
            this.passwordlable = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(12, 86);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(339, 33);
            this.loginTextBox.TabIndex = 0;
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Location = new System.Drawing.Point(12, 54);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(40, 16);
            this.loginlabel.TabIndex = 1;
            this.loginlabel.Text = "Login";
            // 
            // passwordlable
            // 
            this.passwordlable.AutoSize = true;
            this.passwordlable.Location = new System.Drawing.Point(12, 164);
            this.passwordlable.Name = "passwordlable";
            this.passwordlable.Size = new System.Drawing.Size(67, 16);
            this.passwordlable.TabIndex = 3;
            this.passwordlable.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(12, 196);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(339, 33);
            this.passwordTextBox.TabIndex = 2;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(15, 280);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(98, 31);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 409);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.passwordlable);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.loginTextBox);
            this.Name = "AuthorizationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Label passwordlable;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button btnLogIn;
    }
}

