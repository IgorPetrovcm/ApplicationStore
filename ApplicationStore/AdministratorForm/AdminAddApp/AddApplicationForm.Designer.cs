namespace ApplicationStore_AdministratorForm
{
    partial class AddApplicationForm
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
            this.iconBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddIcon = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.cmbRolesBox = new System.Windows.Forms.ComboBox();
            this.labelRoleAccess = new System.Windows.Forms.Label();
            this.checkRestrictionsOfAge = new System.Windows.Forms.CheckBox();
            this.btnAddApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconBox1
            // 
            this.iconBox1.Location = new System.Drawing.Point(12, 12);
            this.iconBox1.Name = "iconBox1";
            this.iconBox1.Size = new System.Drawing.Size(86, 82);
            this.iconBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBox1.TabIndex = 0;
            this.iconBox1.TabStop = false;
            // 
            // btnAddIcon
            // 
            this.btnAddIcon.Location = new System.Drawing.Point(12, 100);
            this.btnAddIcon.Name = "btnAddIcon";
            this.btnAddIcon.Size = new System.Drawing.Size(86, 27);
            this.btnAddIcon.TabIndex = 1;
            this.btnAddIcon.Text = "Add icon";
            this.btnAddIcon.UseVisualStyleBackColor = true;
            this.btnAddIcon.Click += new System.EventHandler(this.btnAddIcon_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(12, 151);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(339, 205);
            this.descriptionBox.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(104, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(168, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(185, 22);
            this.nameBox.TabIndex = 4;
            // 
            // cmbRolesBox
            // 
            this.cmbRolesBox.FormattingEnabled = true;
            this.cmbRolesBox.Location = new System.Drawing.Point(230, 58);
            this.cmbRolesBox.Name = "cmbRolesBox";
            this.cmbRolesBox.Size = new System.Drawing.Size(121, 24);
            this.cmbRolesBox.TabIndex = 5;
            // 
            // labelRoleAccess
            // 
            this.labelRoleAccess.AutoSize = true;
            this.labelRoleAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoleAccess.Location = new System.Drawing.Point(104, 62);
            this.labelRoleAccess.Name = "labelRoleAccess";
            this.labelRoleAccess.Size = new System.Drawing.Size(107, 20);
            this.labelRoleAccess.TabIndex = 6;
            this.labelRoleAccess.Text = "Role access:";
            // 
            // checkRestrictionsOfAge
            // 
            this.checkRestrictionsOfAge.AutoSize = true;
            this.checkRestrictionsOfAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkRestrictionsOfAge.Location = new System.Drawing.Point(12, 367);
            this.checkRestrictionsOfAge.Name = "checkRestrictionsOfAge";
            this.checkRestrictionsOfAge.Size = new System.Drawing.Size(166, 24);
            this.checkRestrictionsOfAge.TabIndex = 7;
            this.checkRestrictionsOfAge.Text = "restrictions of age";
            this.checkRestrictionsOfAge.UseVisualStyleBackColor = true;
            // 
            // btnAddApp
            // 
            this.btnAddApp.Location = new System.Drawing.Point(283, 362);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(68, 35);
            this.btnAddApp.TabIndex = 8;
            this.btnAddApp.Text = "Add app";
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // AddApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 409);
            this.Controls.Add(this.btnAddApp);
            this.Controls.Add(this.checkRestrictionsOfAge);
            this.Controls.Add(this.labelRoleAccess);
            this.Controls.Add(this.cmbRolesBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.btnAddIcon);
            this.Controls.Add(this.iconBox1);
            this.Name = "AddApplicationForm";
            this.Text = "AddApplicationForm";
            ((System.ComponentModel.ISupportInitialize)(this.iconBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconBox1;
        private System.Windows.Forms.Button btnAddIcon;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox cmbRolesBox;
        private System.Windows.Forms.Label labelRoleAccess;
        private System.Windows.Forms.CheckBox checkRestrictionsOfAge;
        private System.Windows.Forms.Button btnAddApp;
    }
}