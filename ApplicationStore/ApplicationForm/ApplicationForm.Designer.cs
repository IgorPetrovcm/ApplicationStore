namespace ApplicationStore_ApplicationForm
{
    partial class ApplicationForm
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
            this.icon_appBox = new System.Windows.Forms.PictureBox();
            this.nameText = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.restrictionChkBox = new System.Windows.Forms.CheckBox();
            this.text1 = new System.Windows.Forms.Label();
            this.roleText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_nameText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon_appBox)).BeginInit();
            this.SuspendLayout();
            // 
            // icon_appBox
            // 
            this.icon_appBox.Location = new System.Drawing.Point(12, 53);
            this.icon_appBox.Name = "icon_appBox";
            this.icon_appBox.Size = new System.Drawing.Size(130, 130);
            this.icon_appBox.TabIndex = 0;
            this.icon_appBox.TabStop = false;
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameText.Location = new System.Drawing.Point(22, 9);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(0, 20);
            this.nameText.TabIndex = 1;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.Location = new System.Drawing.Point(12, 186);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(95, 20);
            this.text2.TabIndex = 2;
            this.text2.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 226);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 215);
            this.textBox1.TabIndex = 3;
            // 
            // restrictionChkBox
            // 
            this.restrictionChkBox.AutoSize = true;
            this.restrictionChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restrictionChkBox.Location = new System.Drawing.Point(148, 159);
            this.restrictionChkBox.Name = "restrictionChkBox";
            this.restrictionChkBox.Size = new System.Drawing.Size(121, 24);
            this.restrictionChkBox.TabIndex = 4;
            this.restrictionChkBox.Text = "Restrictions";
            this.restrictionChkBox.UseVisualStyleBackColor = true;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.Location = new System.Drawing.Point(148, 124);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(131, 20);
            this.text1.TabIndex = 5;
            this.text1.Text = "Access to roles:";
            // 
            // roleText
            // 
            this.roleText.AutoSize = true;
            this.roleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleText.Location = new System.Drawing.Point(285, 124);
            this.roleText.Name = "roleText";
            this.roleText.Size = new System.Drawing.Size(53, 20);
            this.roleText.TabIndex = 6;
            this.roleText.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(148, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Uploaded:";
            // 
            // user_nameText
            // 
            this.user_nameText.AutoSize = true;
            this.user_nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_nameText.Location = new System.Drawing.Point(238, 95);
            this.user_nameText.Name = "user_nameText";
            this.user_nameText.Size = new System.Drawing.Size(53, 20);
            this.user_nameText.TabIndex = 8;
            this.user_nameText.Text = "label3";
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 453);
            this.Controls.Add(this.user_nameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roleText);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.restrictionChkBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.icon_appBox);
            this.Name = "ApplicationForm";
            this.Text = "ApplicationForm";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon_appBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icon_appBox;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox restrictionChkBox;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label roleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label user_nameText;
    }
}