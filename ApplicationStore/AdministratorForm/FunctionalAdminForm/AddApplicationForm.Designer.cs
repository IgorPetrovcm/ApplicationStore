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
            // 
            // AddApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 409);
            this.Controls.Add(this.btnAddIcon);
            this.Controls.Add(this.iconBox1);
            this.Name = "AddApplicationForm";
            this.Text = "AddApplicationForm";
            ((System.ComponentModel.ISupportInitialize)(this.iconBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconBox1;
        private System.Windows.Forms.Button btnAddIcon;
    }
}