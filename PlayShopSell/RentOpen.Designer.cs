namespace PlayShopSell
{
    partial class RentOpen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentOpen));
            this.dataGridView_RentOpen = new System.Windows.Forms.DataGridView();
            this.Column_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_secondDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_RentClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RentOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_RentOpen
            // 
            this.dataGridView_RentOpen.AllowUserToAddRows = false;
            this.dataGridView_RentOpen.AllowUserToDeleteRows = false;
            this.dataGridView_RentOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RentOpen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Number,
            this.Column_Name,
            this.Column_secondDate,
            this.Column_Amount,
            this.Column_Price});
            this.dataGridView_RentOpen.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_RentOpen.Name = "dataGridView_RentOpen";
            this.dataGridView_RentOpen.ReadOnly = true;
            this.dataGridView_RentOpen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_RentOpen.Size = new System.Drawing.Size(399, 429);
            this.dataGridView_RentOpen.TabIndex = 1;
            // 
            // Column_Number
            // 
            this.Column_Number.Frozen = true;
            this.Column_Number.HeaderText = "#";
            this.Column_Number.Name = "Column_Number";
            this.Column_Number.ReadOnly = true;
            this.Column_Number.Width = 30;
            // 
            // Column_Name
            // 
            this.Column_Name.Frozen = true;
            this.Column_Name.HeaderText = "Назва";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            this.Column_Name.Width = 120;
            // 
            // Column_secondDate
            // 
            this.Column_secondDate.Frozen = true;
            this.Column_secondDate.HeaderText = "До";
            this.Column_secondDate.Name = "Column_secondDate";
            this.Column_secondDate.ReadOnly = true;
            // 
            // Column_Amount
            // 
            this.Column_Amount.Frozen = true;
            this.Column_Amount.HeaderText = "Кількість";
            this.Column_Amount.Name = "Column_Amount";
            this.Column_Amount.ReadOnly = true;
            this.Column_Amount.Width = 55;
            // 
            // Column_Price
            // 
            this.Column_Price.Frozen = true;
            this.Column_Price.HeaderText = "Ціна";
            this.Column_Price.Name = "Column_Price";
            this.Column_Price.ReadOnly = true;
            this.Column_Price.Width = 50;
            // 
            // button_RentClose
            // 
            this.button_RentClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_RentClose.Location = new System.Drawing.Point(12, 447);
            this.button_RentClose.Name = "button_RentClose";
            this.button_RentClose.Size = new System.Drawing.Size(399, 30);
            this.button_RentClose.TabIndex = 2;
            this.button_RentClose.Text = "Закрити рахунок";
            this.button_RentClose.UseVisualStyleBackColor = true;
            this.button_RentClose.Click += new System.EventHandler(this.button_RentClose_Click);
            // 
            // RentOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 488);
            this.Controls.Add(this.button_RentClose);
            this.Controls.Add(this.dataGridView_RentOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(440, 527);
            this.MinimumSize = new System.Drawing.Size(440, 527);
            this.Name = "RentOpen";
            this.Text = "Відкриті Рахунки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RentOpen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_RentOpen;
        private System.Windows.Forms.Button button_RentClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_secondDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Price;
    }
}