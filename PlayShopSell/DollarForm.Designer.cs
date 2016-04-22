namespace PlayShopSell
{
    partial class DollarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DollarForm));
            this.textBox_Dollar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_DollarUpdute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Dollar
            // 
            this.textBox_Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Dollar.Location = new System.Drawing.Point(115, 12);
            this.textBox_Dollar.Name = "textBox_Dollar";
            this.textBox_Dollar.Size = new System.Drawing.Size(100, 23);
            this.textBox_Dollar.TabIndex = 0;
            this.textBox_Dollar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Dollar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Курс Долара:";
            // 
            // button_DollarUpdute
            // 
            this.button_DollarUpdute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_DollarUpdute.Location = new System.Drawing.Point(14, 41);
            this.button_DollarUpdute.Name = "button_DollarUpdute";
            this.button_DollarUpdute.Size = new System.Drawing.Size(200, 23);
            this.button_DollarUpdute.TabIndex = 2;
            this.button_DollarUpdute.Text = "Оновити";
            this.button_DollarUpdute.UseVisualStyleBackColor = true;
            this.button_DollarUpdute.Click += new System.EventHandler(this.button_DollarUpdute_Click);
            // 
            // DollarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 77);
            this.Controls.Add(this.button_DollarUpdute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Dollar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(242, 116);
            this.Name = "DollarForm";
            this.Text = "Оновлення";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Dollar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_DollarUpdute;
    }
}