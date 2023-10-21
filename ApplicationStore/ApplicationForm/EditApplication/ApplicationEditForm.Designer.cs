namespace ApplicationStore_ApplicationForm
{
    partial class ApplicationEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.restrictionChkBox = new System.Windows.Forms.CheckBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.btnSaveNewApp = new System.Windows.Forms.Button();
            this.user_nameText = new System.Windows.Forms.Label();
            this.cmbRolesBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon_appBox)).BeginInit();
            this.SuspendLayout();
            // 
            // icon_appBox
            // 
            this.icon_appBox.Location = new System.Drawing.Point(12, 53);
            this.icon_appBox.Name = "icon_appBox";
            this.icon_appBox.Size = new System.Drawing.Size(130, 130);
            this.icon_appBox.TabIndex = 1;
            this.icon_appBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(148, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Uploaded:";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.Location = new System.Drawing.Point(148, 124);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(131, 20);
            this.text1.TabIndex = 10;
            this.text1.Text = "Access to roles:";
            // 
            // restrictionChkBox
            // 
            this.restrictionChkBox.AutoSize = true;
            this.restrictionChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restrictionChkBox.Location = new System.Drawing.Point(148, 159);
            this.restrictionChkBox.Name = "restrictionChkBox";
            this.restrictionChkBox.Size = new System.Drawing.Size(121, 24);
            this.restrictionChkBox.TabIndex = 9;
            this.restrictionChkBox.Text = "Restrictions";
            this.restrictionChkBox.UseVisualStyleBackColor = true;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(16, 226);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(454, 215);
            this.descriptionBox.TabIndex = 14;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.Location = new System.Drawing.Point(12, 203);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(95, 20);
            this.text2.TabIndex = 15;
            this.text2.Text = "Description";
            // 
            // btnSaveNewApp
            // 
            this.btnSaveNewApp.Location = new System.Drawing.Point(412, 423);
            this.btnSaveNewApp.Name = "btnSaveNewApp";
            this.btnSaveNewApp.Size = new System.Drawing.Size(73, 28);
            this.btnSaveNewApp.TabIndex = 16;
            this.btnSaveNewApp.Text = "Save";
            this.btnSaveNewApp.UseVisualStyleBackColor = true;
            // 
            // user_nameText
            // 
            this.user_nameText.AutoSize = true;
            this.user_nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_nameText.Location = new System.Drawing.Point(238, 95);
            this.user_nameText.Name = "user_nameText";
            this.user_nameText.Size = new System.Drawing.Size(53, 20);
            this.user_nameText.TabIndex = 13;
            this.user_nameText.Text = "label3";
            // 
            // cmbRolesBox
            // 
            this.cmbRolesBox.FormattingEnabled = true;
            this.cmbRolesBox.Location = new System.Drawing.Point(285, 124);
            this.cmbRolesBox.Name = "cmbRolesBox";
            this.cmbRolesBox.Size = new System.Drawing.Size(153, 24);
            this.cmbRolesBox.TabIndex = 17;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(220, 22);
            this.nameBox.TabIndex = 18;
            // 
            // ApplicationEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 453);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.cmbRolesBox);
            this.Controls.Add(this.btnSaveNewApp);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.user_nameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.restrictionChkBox);
            this.Controls.Add(this.icon_appBox);
            this.Name = "ApplicationEditForm";
            this.Text = "ApplicationEditForm";
            this.Load += new System.EventHandler(this.ApplicationEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon_appBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icon_appBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.CheckBox restrictionChkBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Button btnSaveNewApp;
        private System.Windows.Forms.Label user_nameText;
        private System.Windows.Forms.ComboBox cmbRolesBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}