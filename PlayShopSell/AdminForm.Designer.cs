namespace PlayShopSell
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControl_Admin = new System.Windows.Forms.TabControl();
            this.tabPage_Bills = new System.Windows.Forms.TabPage();
            this.dataGridView_Bills = new System.Windows.Forms.DataGridView();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_sumUAH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_SaleStorage = new System.Windows.Forms.TabPage();
            this.dataGridView_SaleStorage = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_amountS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_priceUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_RentStorage = new System.Windows.Forms.TabPage();
            this.dataGridView_RentStorage = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_RepairInfo = new System.Windows.Forms.TabPage();
            this.dataGridView_RepairInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_StorageIncome = new System.Windows.Forms.TabPage();
            this.dataGridView_StorageIncome = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker_FirstDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_SecondDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Show = new System.Windows.Forms.Button();
            this.button_Deploy = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_DeletePos = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.comboBox_IncomeType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_GetIncome = new System.Windows.Forms.Button();
            this.groupBox_PosChange = new System.Windows.Forms.GroupBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.groupBox_GetIncome = new System.Windows.Forms.GroupBox();
            this.groupBox_GetBills = new System.Windows.Forms.GroupBox();
            this.menuStrip_Admin = new System.Windows.Forms.MenuStrip();
            this.інфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_Admin.SuspendLayout();
            this.tabPage_Bills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bills)).BeginInit();
            this.tabPage_SaleStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SaleStorage)).BeginInit();
            this.tabPage_RentStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RentStorage)).BeginInit();
            this.tabPage_RepairInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RepairInfo)).BeginInit();
            this.tabPage_StorageIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StorageIncome)).BeginInit();
            this.groupBox_PosChange.SuspendLayout();
            this.groupBox_GetIncome.SuspendLayout();
            this.groupBox_GetBills.SuspendLayout();
            this.menuStrip_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Admin
            // 
            this.tabControl_Admin.Controls.Add(this.tabPage_Bills);
            this.tabControl_Admin.Controls.Add(this.tabPage_SaleStorage);
            this.tabControl_Admin.Controls.Add(this.tabPage_RentStorage);
            this.tabControl_Admin.Controls.Add(this.tabPage_RepairInfo);
            this.tabControl_Admin.Controls.Add(this.tabPage_StorageIncome);
            this.tabControl_Admin.Location = new System.Drawing.Point(12, 27);
            this.tabControl_Admin.Name = "tabControl_Admin";
            this.tabControl_Admin.SelectedIndex = 0;
            this.tabControl_Admin.Size = new System.Drawing.Size(458, 544);
            this.tabControl_Admin.TabIndex = 0;
            this.tabControl_Admin.SelectedIndexChanged += new System.EventHandler(this.tabControl_Admin_SelectedIndexChanged);
            // 
            // tabPage_Bills
            // 
            this.tabPage_Bills.Controls.Add(this.dataGridView_Bills);
            this.tabPage_Bills.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Bills.Name = "tabPage_Bills";
            this.tabPage_Bills.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Bills.Size = new System.Drawing.Size(450, 518);
            this.tabPage_Bills.TabIndex = 0;
            this.tabPage_Bills.Text = "Рахунки";
            this.tabPage_Bills.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Bills
            // 
            this.dataGridView_Bills.AllowUserToAddRows = false;
            this.dataGridView_Bills.AllowUserToDeleteRows = false;
            this.dataGridView_Bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id,
            this.Column_date,
            this.Column_sumUAH});
            this.dataGridView_Bills.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_Bills.Name = "dataGridView_Bills";
            this.dataGridView_Bills.ReadOnly = true;
            this.dataGridView_Bills.Size = new System.Drawing.Size(438, 506);
            this.dataGridView_Bills.TabIndex = 0;
            // 
            // Column_id
            // 
            this.Column_id.Frozen = true;
            this.Column_id.HeaderText = "Id";
            this.Column_id.Name = "Column_id";
            this.Column_id.ReadOnly = true;
            // 
            // Column_date
            // 
            this.Column_date.Frozen = true;
            this.Column_date.HeaderText = "Дата";
            this.Column_date.Name = "Column_date";
            this.Column_date.ReadOnly = true;
            this.Column_date.Width = 150;
            // 
            // Column_sumUAH
            // 
            this.Column_sumUAH.Frozen = true;
            this.Column_sumUAH.HeaderText = "Сума(UAH)";
            this.Column_sumUAH.Name = "Column_sumUAH";
            this.Column_sumUAH.ReadOnly = true;
            this.Column_sumUAH.Width = 200;
            // 
            // tabPage_SaleStorage
            // 
            this.tabPage_SaleStorage.Controls.Add(this.dataGridView_SaleStorage);
            this.tabPage_SaleStorage.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SaleStorage.Name = "tabPage_SaleStorage";
            this.tabPage_SaleStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SaleStorage.Size = new System.Drawing.Size(450, 518);
            this.tabPage_SaleStorage.TabIndex = 1;
            this.tabPage_SaleStorage.Text = "Продаж";
            this.tabPage_SaleStorage.UseVisualStyleBackColor = true;
            // 
            // dataGridView_SaleStorage
            // 
            this.dataGridView_SaleStorage.AllowUserToAddRows = false;
            this.dataGridView_SaleStorage.AllowUserToDeleteRows = false;
            this.dataGridView_SaleStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SaleStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column_Name,
            this.Column_amountS,
            this.Column_priceUSD});
            this.dataGridView_SaleStorage.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_SaleStorage.Name = "dataGridView_SaleStorage";
            this.dataGridView_SaleStorage.Size = new System.Drawing.Size(438, 506);
            this.dataGridView_SaleStorage.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // Column_Name
            // 
            this.Column_Name.Frozen = true;
            this.Column_Name.HeaderText = "Назва";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Name.Width = 140;
            // 
            // Column_amountS
            // 
            this.Column_amountS.Frozen = true;
            this.Column_amountS.HeaderText = "Залишок";
            this.Column_amountS.Name = "Column_amountS";
            this.Column_amountS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_priceUSD
            // 
            this.Column_priceUSD.Frozen = true;
            this.Column_priceUSD.HeaderText = "Ціна(USD)";
            this.Column_priceUSD.Name = "Column_priceUSD";
            this.Column_priceUSD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage_RentStorage
            // 
            this.tabPage_RentStorage.Controls.Add(this.dataGridView_RentStorage);
            this.tabPage_RentStorage.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RentStorage.Name = "tabPage_RentStorage";
            this.tabPage_RentStorage.Size = new System.Drawing.Size(450, 518);
            this.tabPage_RentStorage.TabIndex = 2;
            this.tabPage_RentStorage.Text = "Прокат";
            this.tabPage_RentStorage.UseVisualStyleBackColor = true;
            // 
            // dataGridView_RentStorage
            // 
            this.dataGridView_RentStorage.AllowUserToAddRows = false;
            this.dataGridView_RentStorage.AllowUserToDeleteRows = false;
            this.dataGridView_RentStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RentStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView_RentStorage.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_RentStorage.Name = "dataGridView_RentStorage";
            this.dataGridView_RentStorage.Size = new System.Drawing.Size(438, 506);
            this.dataGridView_RentStorage.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Залишок";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Ціна(UAH)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage_RepairInfo
            // 
            this.tabPage_RepairInfo.Controls.Add(this.dataGridView_RepairInfo);
            this.tabPage_RepairInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RepairInfo.Name = "tabPage_RepairInfo";
            this.tabPage_RepairInfo.Size = new System.Drawing.Size(450, 518);
            this.tabPage_RepairInfo.TabIndex = 3;
            this.tabPage_RepairInfo.Text = "Ремонт";
            this.tabPage_RepairInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridView_RepairInfo
            // 
            this.dataGridView_RepairInfo.AllowUserToAddRows = false;
            this.dataGridView_RepairInfo.AllowUserToDeleteRows = false;
            this.dataGridView_RepairInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RepairInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView_RepairInfo.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_RepairInfo.Name = "dataGridView_RepairInfo";
            this.dataGridView_RepairInfo.Size = new System.Drawing.Size(438, 506);
            this.dataGridView_RepairInfo.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 160;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.Frozen = true;
            this.dataGridViewTextBoxColumn9.HeaderText = "Ціна(UAH)";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 140;
            // 
            // tabPage_StorageIncome
            // 
            this.tabPage_StorageIncome.Controls.Add(this.dataGridView_StorageIncome);
            this.tabPage_StorageIncome.Location = new System.Drawing.Point(4, 22);
            this.tabPage_StorageIncome.Name = "tabPage_StorageIncome";
            this.tabPage_StorageIncome.Size = new System.Drawing.Size(450, 518);
            this.tabPage_StorageIncome.TabIndex = 4;
            this.tabPage_StorageIncome.Text = "Надходження";
            this.tabPage_StorageIncome.UseVisualStyleBackColor = true;
            // 
            // dataGridView_StorageIncome
            // 
            this.dataGridView_StorageIncome.AllowUserToAddRows = false;
            this.dataGridView_StorageIncome.AllowUserToDeleteRows = false;
            this.dataGridView_StorageIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StorageIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView_StorageIncome.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_StorageIncome.Name = "dataGridView_StorageIncome";
            this.dataGridView_StorageIncome.ReadOnly = true;
            this.dataGridView_StorageIncome.Size = new System.Drawing.Size(438, 506);
            this.dataGridView_StorageIncome.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.Frozen = true;
            this.dataGridViewTextBoxColumn10.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.Frozen = true;
            this.dataGridViewTextBoxColumn11.HeaderText = "Кількість";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.Frozen = true;
            this.dataGridViewTextBoxColumn12.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dateTimePicker_FirstDate
            // 
            this.dateTimePicker_FirstDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker_FirstDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker_FirstDate.Location = new System.Drawing.Point(17, 47);
            this.dateTimePicker_FirstDate.Name = "dateTimePicker_FirstDate";
            this.dateTimePicker_FirstDate.Size = new System.Drawing.Size(218, 23);
            this.dateTimePicker_FirstDate.TabIndex = 1;
            // 
            // dateTimePicker_SecondDate
            // 
            this.dateTimePicker_SecondDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker_SecondDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker_SecondDate.Location = new System.Drawing.Point(17, 93);
            this.dateTimePicker_SecondDate.Name = "dateTimePicker_SecondDate";
            this.dateTimePicker_SecondDate.Size = new System.Drawing.Size(218, 23);
            this.dateTimePicker_SecondDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Початкова Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кінцева Дата:";
            // 
            // button_Show
            // 
            this.button_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Show.Location = new System.Drawing.Point(17, 122);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(218, 27);
            this.button_Show.TabIndex = 5;
            this.button_Show.Text = "Вивід";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // button_Deploy
            // 
            this.button_Deploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Deploy.Location = new System.Drawing.Point(17, 155);
            this.button_Deploy.Name = "button_Deploy";
            this.button_Deploy.Size = new System.Drawing.Size(218, 28);
            this.button_Deploy.TabIndex = 6;
            this.button_Deploy.Text = "Розгорнути";
            this.button_Deploy.UseVisualStyleBackColor = true;
            this.button_Deploy.Click += new System.EventHandler(this.button_Deploy_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Name.Location = new System.Drawing.Point(72, 30);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(163, 23);
            this.textBox_Name.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Назва:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(14, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ціна:";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Price.Location = new System.Drawing.Point(198, 62);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(37, 17);
            this.label_Price.TabIndex = 11;
            this.label_Price.Text = "USD";
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Add.Location = new System.Drawing.Point(17, 89);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(218, 27);
            this.button_Add.TabIndex = 12;
            this.button_Add.Text = "Додати";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_DeletePos
            // 
            this.button_DeletePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_DeletePos.Location = new System.Drawing.Point(17, 122);
            this.button_DeletePos.Name = "button_DeletePos";
            this.button_DeletePos.Size = new System.Drawing.Size(218, 27);
            this.button_DeletePos.TabIndex = 13;
            this.button_DeletePos.Text = "Видалити";
            this.button_DeletePos.UseVisualStyleBackColor = true;
            this.button_DeletePos.Click += new System.EventHandler(this.button_DeletePos_Click);
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Update.Location = new System.Drawing.Point(17, 155);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(218, 27);
            this.button_Update.TabIndex = 14;
            this.button_Update.Text = "Оновити";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // comboBox_IncomeType
            // 
            this.comboBox_IncomeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_IncomeType.FormattingEnabled = true;
            this.comboBox_IncomeType.Items.AddRange(new object[] {
            "Загальний",
            "Продаж",
            "Прокат",
            "Ремонт",
            "Продаж(Чистий)"});
            this.comboBox_IncomeType.Location = new System.Drawing.Point(17, 53);
            this.comboBox_IncomeType.Name = "comboBox_IncomeType";
            this.comboBox_IncomeType.Size = new System.Drawing.Size(218, 24);
            this.comboBox_IncomeType.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(14, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Тип прибутку:";
            // 
            // button_GetIncome
            // 
            this.button_GetIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_GetIncome.Location = new System.Drawing.Point(17, 83);
            this.button_GetIncome.Name = "button_GetIncome";
            this.button_GetIncome.Size = new System.Drawing.Size(218, 27);
            this.button_GetIncome.TabIndex = 17;
            this.button_GetIncome.Text = "Вирахувати";
            this.button_GetIncome.UseVisualStyleBackColor = true;
            this.button_GetIncome.Click += new System.EventHandler(this.button_GetIncome_Click);
            // 
            // groupBox_PosChange
            // 
            this.groupBox_PosChange.Controls.Add(this.textBox_Price);
            this.groupBox_PosChange.Controls.Add(this.textBox_Name);
            this.groupBox_PosChange.Controls.Add(this.label3);
            this.groupBox_PosChange.Controls.Add(this.label4);
            this.groupBox_PosChange.Controls.Add(this.label_Price);
            this.groupBox_PosChange.Controls.Add(this.button_Add);
            this.groupBox_PosChange.Controls.Add(this.button_Update);
            this.groupBox_PosChange.Controls.Add(this.button_DeletePos);
            this.groupBox_PosChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_PosChange.Location = new System.Drawing.Point(489, 34);
            this.groupBox_PosChange.Name = "groupBox_PosChange";
            this.groupBox_PosChange.Size = new System.Drawing.Size(247, 202);
            this.groupBox_PosChange.TabIndex = 19;
            this.groupBox_PosChange.TabStop = false;
            this.groupBox_PosChange.Text = "Робота з позиціями";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(62, 59);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(130, 23);
            this.textBox_Price.TabIndex = 15;
            this.textBox_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Price_KeyPress);
            // 
            // groupBox_GetIncome
            // 
            this.groupBox_GetIncome.Controls.Add(this.button_GetIncome);
            this.groupBox_GetIncome.Controls.Add(this.comboBox_IncomeType);
            this.groupBox_GetIncome.Controls.Add(this.label5);
            this.groupBox_GetIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_GetIncome.Location = new System.Drawing.Point(489, 242);
            this.groupBox_GetIncome.Name = "groupBox_GetIncome";
            this.groupBox_GetIncome.Size = new System.Drawing.Size(247, 124);
            this.groupBox_GetIncome.TabIndex = 20;
            this.groupBox_GetIncome.TabStop = false;
            this.groupBox_GetIncome.Text = "Вирахувати прибуток";
            // 
            // groupBox_GetBills
            // 
            this.groupBox_GetBills.Controls.Add(this.label1);
            this.groupBox_GetBills.Controls.Add(this.dateTimePicker_FirstDate);
            this.groupBox_GetBills.Controls.Add(this.label2);
            this.groupBox_GetBills.Controls.Add(this.button_Deploy);
            this.groupBox_GetBills.Controls.Add(this.dateTimePicker_SecondDate);
            this.groupBox_GetBills.Controls.Add(this.button_Show);
            this.groupBox_GetBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox_GetBills.Location = new System.Drawing.Point(489, 372);
            this.groupBox_GetBills.Name = "groupBox_GetBills";
            this.groupBox_GetBills.Size = new System.Drawing.Size(247, 199);
            this.groupBox_GetBills.TabIndex = 21;
            this.groupBox_GetBills.TabStop = false;
            this.groupBox_GetBills.Text = "Розгортання рахунків";
            // 
            // menuStrip_Admin
            // 
            this.menuStrip_Admin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.інфоToolStripMenuItem});
            this.menuStrip_Admin.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Admin.Name = "menuStrip_Admin";
            this.menuStrip_Admin.Size = new System.Drawing.Size(755, 24);
            this.menuStrip_Admin.TabIndex = 22;
            this.menuStrip_Admin.Text = "menuStrip1";
            // 
            // інфоToolStripMenuItem
            // 
            this.інфоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.довідкаToolStripMenuItem});
            this.інфоToolStripMenuItem.Name = "інфоToolStripMenuItem";
            this.інфоToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.інфоToolStripMenuItem.Text = "Інфо";
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            this.довідкаToolStripMenuItem.Click += new System.EventHandler(this.довідкаToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 580);
            this.Controls.Add(this.groupBox_GetBills);
            this.Controls.Add(this.groupBox_GetIncome);
            this.Controls.Add(this.groupBox_PosChange);
            this.Controls.Add(this.tabControl_Admin);
            this.Controls.Add(this.menuStrip_Admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(771, 619);
            this.MinimumSize = new System.Drawing.Size(771, 619);
            this.Name = "AdminForm";
            this.Text = "Адміністрування";
            this.tabControl_Admin.ResumeLayout(false);
            this.tabPage_Bills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bills)).EndInit();
            this.tabPage_SaleStorage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SaleStorage)).EndInit();
            this.tabPage_RentStorage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RentStorage)).EndInit();
            this.tabPage_RepairInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RepairInfo)).EndInit();
            this.tabPage_StorageIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StorageIncome)).EndInit();
            this.groupBox_PosChange.ResumeLayout(false);
            this.groupBox_PosChange.PerformLayout();
            this.groupBox_GetIncome.ResumeLayout(false);
            this.groupBox_GetIncome.PerformLayout();
            this.groupBox_GetBills.ResumeLayout(false);
            this.groupBox_GetBills.PerformLayout();
            this.menuStrip_Admin.ResumeLayout(false);
            this.menuStrip_Admin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Admin;
        private System.Windows.Forms.TabPage tabPage_Bills;
        private System.Windows.Forms.DataGridView dataGridView_Bills;
        private System.Windows.Forms.TabPage tabPage_SaleStorage;
        private System.Windows.Forms.TabPage tabPage_RentStorage;
        private System.Windows.Forms.TabPage tabPage_RepairInfo;
        private System.Windows.Forms.TabPage tabPage_StorageIncome;
        private System.Windows.Forms.DataGridView dataGridView_SaleStorage;
        private System.Windows.Forms.DataGridView dataGridView_RentStorage;
        private System.Windows.Forms.DataGridView dataGridView_RepairInfo;
        private System.Windows.Forms.DataGridView dataGridView_StorageIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FirstDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SecondDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Button button_Deploy;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_sumUAH;
        private System.Windows.Forms.Button button_DeletePos;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_amountS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_priceUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ComboBox comboBox_IncomeType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_GetIncome;
        private System.Windows.Forms.GroupBox groupBox_PosChange;
        private System.Windows.Forms.GroupBox groupBox_GetIncome;
        private System.Windows.Forms.GroupBox groupBox_GetBills;
        private System.Windows.Forms.MenuStrip menuStrip_Admin;
        private System.Windows.Forms.ToolStripMenuItem інфоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_Price;
    }
}