namespace ApplicationStore
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelRoleAccess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconBox1
            // 
            this.iconBox1.Location = new System.Drawing.Point(12, 12);
            this.iconBox1.Name = "iconBox1";
            this.iconBox1.Size = new System.Drawing.Size(70, 70);
            this.iconBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBox1.TabIndex = 0;
            this.iconBox1.TabStop = false;
            // 
            // btnAddIcon
            // 
            this.btnAddIcon.Location = new System.Drawing.Point(12, 88);
            this.btnAddIcon.Name = "btnAddIcon";
            this.btnAddIcon.Size = new System.Drawing.Size(70, 27);
            this.btnAddIcon.TabIndex = 1;
            this.btnAddIcon.Text = "Add icon";
            this.btnAddIcon.UseVisualStyleBackColor = true;
            this.btnAddIcon.Click += new System.EventHandler(this.btnAddIcon_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 192);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 205);
            this.textBox1.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(88, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(150, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(201, 22);
            this.nameBox.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // labelRoleAccess
            // 
            this.labelRoleAccess.AutoSize = true;
            this.labelRoleAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoleAccess.Location = new System.Drawing.Point(88, 62);
            this.labelRoleAccess.Name = "labelRoleAccess";
            this.labelRoleAccess.Size = new System.Drawing.Size(107, 20);
            this.labelRoleAccess.TabIndex = 6;
            this.labelRoleAccess.Text = "Role access:";
            // 
            // AddApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 409);
            this.Controls.Add(this.labelRoleAccess);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelRoleAccess;
    }
}