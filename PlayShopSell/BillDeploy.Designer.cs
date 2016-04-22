namespace PlayShopSell
{
    partial class BillDeploy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillDeploy));
            this.dataGridView_Main = new System.Windows.Forms.DataGridView();
            this.Column_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_secondDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_priceUAH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Main
            // 
            this.dataGridView_Main.AllowUserToAddRows = false;
            this.dataGridView_Main.AllowUserToDeleteRows = false;
            this.dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_number,
            this.Column_name,
            this.Column_amount,
            this.Column_secondDate,
            this.Column_priceUAH,
            this.Column_sum});
            this.dataGridView_Main.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Main.Name = "dataGridView_Main";
            this.dataGridView_Main.ReadOnly = true;
            this.dataGridView_Main.Size = new System.Drawing.Size(603, 347);
            this.dataGridView_Main.TabIndex = 0;
            // 
            // Column_number
            // 
            this.Column_number.Frozen = true;
            this.Column_number.HeaderText = "#";
            this.Column_number.Name = "Column_number";
            this.Column_number.ReadOnly = true;
            this.Column_number.Width = 40;
            // 
            // Column_name
            // 
            this.Column_name.Frozen = true;
            this.Column_name.HeaderText = "Назва";
            this.Column_name.Name = "Column_name";
            this.Column_name.ReadOnly = true;
            this.Column_name.Width = 140;
            // 
            // Column_amount
            // 
            this.Column_amount.Frozen = true;
            this.Column_amount.HeaderText = "Кількість";
            this.Column_amount.Name = "Column_amount";
            this.Column_amount.ReadOnly = true;
            // 
            // Column_secondDate
            // 
            this.Column_secondDate.Frozen = true;
            this.Column_secondDate.HeaderText = "До";
            this.Column_secondDate.Name = "Column_secondDate";
            this.Column_secondDate.ReadOnly = true;
            this.Column_secondDate.Width = 120;
            // 
            // Column_priceUAH
            // 
            this.Column_priceUAH.Frozen = true;
            this.Column_priceUAH.HeaderText = "Ціна";
            this.Column_priceUAH.Name = "Column_priceUAH";
            this.Column_priceUAH.ReadOnly = true;
            this.Column_priceUAH.Width = 80;
            // 
            // Column_sum
            // 
            this.Column_sum.Frozen = true;
            this.Column_sum.HeaderText = "Сума";
            this.Column_sum.Name = "Column_sum";
            this.Column_sum.ReadOnly = true;
            this.Column_sum.Width = 80;
            // 
            // BillDeploy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 370);
            this.Controls.Add(this.dataGridView_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(642, 409);
            this.MinimumSize = new System.Drawing.Size(642, 409);
            this.Name = "BillDeploy";
            this.Text = "Розгорення";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Main;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_secondDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_priceUAH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_sum;
    }
}