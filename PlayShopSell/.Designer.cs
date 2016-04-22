namespace PlayShopSell
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView_Main = new System.Windows.Forms.DataGridView();
            this.Column_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_secondDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Amount = new System.Windows.Forms.NumericUpDown();
            this.listBox_Sale = new System.Windows.Forms.ListBox();
            this.textBox_ListSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_AmountS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Sale = new System.Windows.Forms.TabPage();
            this.tabPage_Rent = new System.Windows.Forms.TabPage();
            this.dateTimePicker_SecondDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_Rent = new System.Windows.Forms.ListBox();
            this.tabPage_Repair = new System.Windows.Forms.TabPage();
            this.listBox_Repair = new System.Windows.Forms.ListBox();
            this.button_AddPos = new System.Windows.Forms.Button();
            this.button_DeletePos = new System.Windows.Forms.Button();
            this.button_Sell = new System.Windows.Forms.Button();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.данніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсДолараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритийПрокатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адмініструванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адмініструванняToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.надходженняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Dollar = new System.Windows.Forms.TextBox();
            this.textBox_PriceUAH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).BeginInit();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Sale.SuspendLayout();
            this.tabPage_Rent.SuspendLayout();
            this.tabPage_Repair.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Main
            // 
            this.dataGridView_Main.AllowUserToAddRows = false;
            this.dataGridView_Main.AllowUserToDeleteRows = false;
            this.dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Number,
            this.Column_Name,
            this.Column_Amount,
            this.Column_secondDate,
            this.Column_Price,
            this.Column_Sum,
            this.Column_Id,
            this.Column_Type});
            this.dataGridView_Main.Location = new System.Drawing.Point(12, 27);
            this.dataGridView_Main.Name = "dataGridView_Main";
            this.dataGridView_Main.ReadOnly = true;
            this.dataGridView_Main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Main.Size = new System.Drawing.Size(449, 634);
            this.dataGridView_Main.TabIndex = 0;
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
            // Column_Amount
            // 
            this.Column_Amount.Frozen = true;
            this.Column_Amount.HeaderText = "Кількість";
            this.Column_Amount.Name = "Column_Amount";
            this.Column_Amount.ReadOnly = true;
            this.Column_Amount.Width = 55;
            // 
            // Column_secondDate
            // 
            this.Column_secondDate.Frozen = true;
            this.Column_secondDate.HeaderText = "До";
            this.Column_secondDate.Name = "Column_secondDate";
            this.Column_secondDate.ReadOnly = true;
            // 
            // Column_Price
            // 
            this.Column_Price.Frozen = true;
            this.Column_Price.HeaderText = "Ціна";
            this.Column_Price.Name = "Column_Price";
            this.Column_Price.ReadOnly = true;
            this.Column_Price.Width = 50;
            // 
            // Column_Sum
            // 
            this.Column_Sum.Frozen = true;
            this.Column_Sum.HeaderText = "Сума";
            this.Column_Sum.Name = "Column_Sum";
            this.Column_Sum.ReadOnly = true;
            this.Column_Sum.Width = 50;
            // 
            // Column_Id
            // 
            this.Column_Id.Frozen = true;
            this.Column_Id.HeaderText = "id";
            this.Column_Id.Name = "Column_Id";
            this.Column_Id.ReadOnly = true;
            this.Column_Id.Visible = false;
            this.Column_Id.Width = 20;
            // 
            // Column_Type
            // 
            this.Column_Type.Frozen = true;
            this.Column_Type.HeaderText = "Type";
            this.Column_Type.Name = "Column_Type";
            this.Column_Type.ReadOnly = true;
            this.Column_Type.Visible = false;
            this.Column_Type.Width = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(475, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Курс Долара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(475, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Кількість на продаж:";
            // 
            // numericUpDown_Amount
            // 
            this.numericUpDown_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDown_Amount.Location = new System.Drawing.Point(617, 542);
            this.numericUpDown_Amount.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.numericUpDown_Amount.Name = "numericUpDown_Amount";
            this.numericUpDown_Amount.Size = new System.Drawing.Size(315, 23);
            this.numericUpDown_Amount.TabIndex = 6;
            // 
            // listBox_Sale
            // 
            this.listBox_Sale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox_Sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox_Sale.FormattingEnabled = true;
            this.listBox_Sale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox_Sale.ItemHeight = 16;
            this.listBox_Sale.Location = new System.Drawing.Point(6, 6);
            this.listBox_Sale.Name = "listBox_Sale";
            this.listBox_Sale.Size = new System.Drawing.Size(446, 388);
            this.listBox_Sale.TabIndex = 7;
            this.listBox_Sale.SelectedIndexChanged += new System.EventHandler(this.listBox_Sale_SelectedIndexChanged);
            // 
            // textBox_ListSearch
            // 
            this.textBox_ListSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_ListSearch.Location = new System.Drawing.Point(533, 24);
            this.textBox_ListSearch.Name = "textBox_ListSearch";
            this.textBox_ListSearch.Size = new System.Drawing.Size(399, 23);
            this.textBox_ListSearch.TabIndex = 8;
            this.textBox_ListSearch.TextChanged += new System.EventHandler(this.textBox_ListSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(467, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Знайти:";
            // 
            // textBox_AmountS
            // 
            this.textBox_AmountS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_AmountS.Location = new System.Drawing.Point(617, 486);
            this.textBox_AmountS.Name = "textBox_AmountS";
            this.textBox_AmountS.ReadOnly = true;
            this.textBox_AmountS.Size = new System.Drawing.Size(118, 23);
            this.textBox_AmountS.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(475, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Залишок на складі:";
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Sale);
            this.tabControl_Main.Controls.Add(this.tabPage_Rent);
            this.tabControl_Main.Controls.Add(this.tabPage_Repair);
            this.tabControl_Main.Location = new System.Drawing.Point(470, 53);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(466, 427);
            this.tabControl_Main.TabIndex = 12;
            this.tabControl_Main.SelectedIndexChanged += new System.EventHandler(this.tabControl_Main_SelectedIndexChanged);
            // 
            // tabPage_Sale
            // 
            this.tabPage_Sale.Controls.Add(this.listBox_Sale);
            this.tabPage_Sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabPage_Sale.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Sale.Name = "tabPage_Sale";
            this.tabPage_Sale.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Sale.Size = new System.Drawing.Size(458, 401);
            this.tabPage_Sale.TabIndex = 0;
            this.tabPage_Sale.Text = "Продаж";
            this.tabPage_Sale.UseVisualStyleBackColor = true;
            // 
            // tabPage_Rent
            // 
            this.tabPage_Rent.Controls.Add(this.dateTimePicker_SecondDate);
            this.tabPage_Rent.Controls.Add(this.label5);
            this.tabPage_Rent.Controls.Add(this.listBox_Rent);
            this.tabPage_Rent.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Rent.Name = "tabPage_Rent";
            this.tabPage_Rent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Rent.Size = new System.Drawing.Size(458, 401);
            this.tabPage_Rent.TabIndex = 1;
            this.tabPage_Rent.Text = "Прокат";
            this.tabPage_Rent.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_SecondDate
            // 
            this.dateTimePicker_SecondDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker_SecondDate.Location = new System.Drawing.Point(43, 368);
            this.dateTimePicker_SecondDate.Name = "dateTimePicker_SecondDate";
            this.dateTimePicker_SecondDate.Size = new System.Drawing.Size(409, 23);
            this.dateTimePicker_SecondDate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(6, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "До:";
            // 
            // listBox_Rent
            // 
            this.listBox_Rent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox_Rent.FormattingEnabled = true;
            this.listBox_Rent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox_Rent.ItemHeight = 16;
            this.listBox_Rent.Location = new System.Drawing.Point(6, 6);
            this.listBox_Rent.Name = "listBox_Rent";
            this.listBox_Rent.Size = new System.Drawing.Size(446, 356);
            this.listBox_Rent.TabIndex = 8;
            this.listBox_Rent.SelectedIndexChanged += new System.EventHandler(this.listBox_Sale_SelectedIndexChanged);
            // 
            // tabPage_Repair
            // 
            this.tabPage_Repair.Controls.Add(this.listBox_Repair);
            this.tabPage_Repair.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Repair.Name = "tabPage_Repair";
            this.tabPage_Repair.Size = new System.Drawing.Size(458, 401);
            this.tabPage_Repair.TabIndex = 2;
            this.tabPage_Repair.Text = "Ремонт";
            this.tabPage_Repair.UseVisualStyleBackColor = true;
            // 
            // listBox_Repair
            // 
            this.listBox_Repair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox_Repair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox_Repair.FormattingEnabled = true;
            this.listBox_Repair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox_Repair.ItemHeight = 16;
            this.listBox_Repair.Location = new System.Drawing.Point(6, 6);
            this.listBox_Repair.Name = "listBox_Repair";
            this.listBox_Repair.Size = new System.Drawing.Size(446, 388);
            this.listBox_Repair.TabIndex = 9;
            this.listBox_Repair.SelectedIndexChanged += new System.EventHandler(this.listBox_Sale_SelectedIndexChanged);
            // 
            // button_AddPos
            // 
            this.button_AddPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_AddPos.Location = new System.Drawing.Point(480, 571);
            this.button_AddPos.Name = "button_AddPos";
            this.button_AddPos.Size = new System.Drawing.Size(452, 26);
            this.button_AddPos.TabIndex = 13;
            this.button_AddPos.Text = "Додати позицію";
            this.button_AddPos.UseVisualStyleBackColor = true;
            this.button_AddPos.Click += new System.EventHandler(this.button_AddPos_Click);
            // 
            // button_DeletePos
            // 
            this.button_DeletePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_DeletePos.Location = new System.Drawing.Point(480, 603);
            this.button_DeletePos.Name = "button_DeletePos";
            this.button_DeletePos.Size = new System.Drawing.Size(452, 26);
            this.button_DeletePos.TabIndex = 14;
            this.button_DeletePos.Text = "Видалити позицію";
            this.button_DeletePos.UseVisualStyleBackColor = true;
            this.button_DeletePos.Click += new System.EventHandler(this.button_DeletePos_Click);
            // 
            // button_Sell
            // 
            this.button_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Sell.Location = new System.Drawing.Point(479, 635);
            this.button_Sell.Name = "button_Sell";
            this.button_Sell.Size = new System.Drawing.Size(453, 26);
            this.button_Sell.TabIndex = 15;
            this.button_Sell.Text = "Продаж";
            this.button_Sell.UseVisualStyleBackColor = true;
            this.button_Sell.Click += new System.EventHandler(this.button_Sell_Click);
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данніToolStripMenuItem,
            this.рахToolStripMenuItem,
            this.адмініструванняToolStripMenuItem,
            this.інфоToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(948, 24);
            this.menuStrip_Main.TabIndex = 16;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // данніToolStripMenuItem
            // 
            this.данніToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.курсДолараToolStripMenuItem});
            this.данніToolStripMenuItem.Name = "данніToolStripMenuItem";
            this.данніToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.данніToolStripMenuItem.Text = "Дані";
            // 
            // курсДолараToolStripMenuItem
            // 
            this.курсДолараToolStripMenuItem.Name = "курсДолараToolStripMenuItem";
            this.курсДолараToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.курсДолараToolStripMenuItem.Text = "Курс Долара";
            this.курсДолараToolStripMenuItem.Click += new System.EventHandler(this.курсДолараToolStripMenuItem_Click);
            // 
            // рахToolStripMenuItem
            // 
            this.рахToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритийПрокатToolStripMenuItem});
            this.рахToolStripMenuItem.Name = "рахToolStripMenuItem";
            this.рахToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.рахToolStripMenuItem.Text = "Рахунки";
            // 
            // відкритийПрокатToolStripMenuItem
            // 
            this.відкритийПрокатToolStripMenuItem.Name = "відкритийПрокатToolStripMenuItem";
            this.відкритийПрокатToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.відкритийПрокатToolStripMenuItem.Text = "Відкритий прокат";
            this.відкритийПрокатToolStripMenuItem.Click += new System.EventHandler(this.відкритийПрокатToolStripMenuItem_Click);
            // 
            // адмініструванняToolStripMenuItem
            // 
            this.адмініструванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.адмініструванняToolStripMenuItem1,
            this.надходженняToolStripMenuItem});
            this.адмініструванняToolStripMenuItem.Name = "адмініструванняToolStripMenuItem";
            this.адмініструванняToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.адмініструванняToolStripMenuItem.Text = "Адміністрування";
            // 
            // адмініструванняToolStripMenuItem1
            // 
            this.адмініструванняToolStripMenuItem1.Name = "адмініструванняToolStripMenuItem1";
            this.адмініструванняToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.адмініструванняToolStripMenuItem1.Text = "Адміністрування";
            this.адмініструванняToolStripMenuItem1.Click += new System.EventHandler(this.адмініструванняToolStripMenuItem1_Click);
            // 
            // надходженняToolStripMenuItem
            // 
            this.надходженняToolStripMenuItem.Name = "надходженняToolStripMenuItem";
            this.надходженняToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.надходженняToolStripMenuItem.Text = "Надходження";
            this.надходженняToolStripMenuItem.Click += new System.EventHandler(this.надходженняToolStripMenuItem_Click);
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
            // textBox_Dollar
            // 
            this.textBox_Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Dollar.Location = new System.Drawing.Point(617, 515);
            this.textBox_Dollar.Name = "textBox_Dollar";
            this.textBox_Dollar.ReadOnly = true;
            this.textBox_Dollar.Size = new System.Drawing.Size(315, 23);
            this.textBox_Dollar.TabIndex = 17;
            // 
            // textBox_PriceUAH
            // 
            this.textBox_PriceUAH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_PriceUAH.Location = new System.Drawing.Point(826, 486);
            this.textBox_PriceUAH.Name = "textBox_PriceUAH";
            this.textBox_PriceUAH.ReadOnly = true;
            this.textBox_PriceUAH.Size = new System.Drawing.Size(106, 23);
            this.textBox_PriceUAH.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(741, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ціна(UAH):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 682);
            this.Controls.Add(this.textBox_PriceUAH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Dollar);
            this.Controls.Add(this.button_Sell);
            this.Controls.Add(this.button_DeletePos);
            this.Controls.Add(this.button_AddPos);
            this.Controls.Add(this.textBox_ListSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_Main);
            this.Controls.Add(this.numericUpDown_Amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.textBox_AmountS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximumSize = new System.Drawing.Size(964, 721);
            this.MinimumSize = new System.Drawing.Size(964, 721);
            this.Name = "Form1";
            this.Text = "PlayShop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).EndInit();
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Sale.ResumeLayout(false);
            this.tabPage_Rent.ResumeLayout(false);
            this.tabPage_Rent.PerformLayout();
            this.tabPage_Repair.ResumeLayout(false);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Amount;
        private System.Windows.Forms.ListBox listBox_Sale;
        private System.Windows.Forms.TextBox textBox_ListSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_AmountS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Sale;
        private System.Windows.Forms.Button button_AddPos;
        private System.Windows.Forms.TabPage tabPage_Rent;
        private System.Windows.Forms.Button button_DeletePos;
        private System.Windows.Forms.Button button_Sell;
        private System.Windows.Forms.ListBox listBox_Rent;
        private System.Windows.Forms.TabPage tabPage_Repair;
        private System.Windows.Forms.ListBox listBox_Repair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SecondDate;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem данніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсДолараToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox_Dollar;
        private System.Windows.Forms.TextBox textBox_PriceUAH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem рахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритийПрокатToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_secondDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Type;
        private System.Windows.Forms.ToolStripMenuItem адмініструванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адмініструванняToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem надходженняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інфоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
    }
}

