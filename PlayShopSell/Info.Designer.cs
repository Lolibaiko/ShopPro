namespace PlayShopSell
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.richTextBox_Main = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Admin = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox_Main
            // 
            this.richTextBox_Main.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_Main.Name = "richTextBox_Main";
            this.richTextBox_Main.ReadOnly = true;
            this.richTextBox_Main.Size = new System.Drawing.Size(436, 349);
            this.richTextBox_Main.TabIndex = 0;
            this.richTextBox_Main.Text = resources.GetString("richTextBox_Main.Text");
            this.richTextBox_Main.Visible = false;
            // 
            // richTextBox_Admin
            // 
            this.richTextBox_Admin.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_Admin.MaximumSize = new System.Drawing.Size(436, 349);
            this.richTextBox_Admin.MinimumSize = new System.Drawing.Size(436, 349);
            this.richTextBox_Admin.Name = "richTextBox_Admin";
            this.richTextBox_Admin.ReadOnly = true;
            this.richTextBox_Admin.Size = new System.Drawing.Size(436, 349);
            this.richTextBox_Admin.TabIndex = 1;
            this.richTextBox_Admin.Text = resources.GetString("richTextBox_Admin.Text");
            this.richTextBox_Admin.Visible = false;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 373);
            this.Controls.Add(this.richTextBox_Admin);
            this.Controls.Add(this.richTextBox_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(476, 412);
            this.MinimumSize = new System.Drawing.Size(476, 412);
            this.Name = "Info";
            this.Text = "Довідка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Main;
        private System.Windows.Forms.RichTextBox richTextBox_Admin;
    }
}