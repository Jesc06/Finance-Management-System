namespace Personal_Finance_Data
{
    partial class Expenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.add = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Amount = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpenseItem = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Expenseslist = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SetGoal = new Guna.UI.WinForms.GunaButton();
            this.addexpenses = new Guna.UI.WinForms.GunaButton();
            this.AddIncome = new Guna.UI.WinForms.GunaButton();
            this.Dashboard = new Guna.UI.WinForms.GunaButton();
            this.Delete = new Guna.UI.WinForms.GunaButton();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Expenseslist)).BeginInit();
            this.gunaShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.Delete);
            this.gunaShadowPanel1.Controls.Add(this.add);
            this.gunaShadowPanel1.Controls.Add(this.label1);
            this.gunaShadowPanel1.Controls.Add(this.Amount);
            this.gunaShadowPanel1.Controls.Add(this.label2);
            this.gunaShadowPanel1.Controls.Add(this.ExpenseItem);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(480, 289);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 14;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(935, 207);
            this.gunaShadowPanel1.TabIndex = 7;
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add.AnimationHoverSpeed = 0.07F;
            this.add.AnimationSpeed = 0.03F;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add.BorderColor = System.Drawing.Color.Transparent;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add.FocusedColor = System.Drawing.Color.Empty;
            this.add.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Image = null;
            this.add.ImageSize = new System.Drawing.Size(20, 20);
            this.add.Location = new System.Drawing.Point(725, 79);
            this.add.Name = "add";
            this.add.OnHoverBaseColor = System.Drawing.Color.Green;
            this.add.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.add.OnHoverForeColor = System.Drawing.Color.White;
            this.add.OnHoverImage = null;
            this.add.OnPressedColor = System.Drawing.Color.Black;
            this.add.Radius = 5;
            this.add.Size = new System.Drawing.Size(168, 77);
            this.add.TabIndex = 11;
            this.add.Text = "Add";
            this.add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(301, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Amount:";
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.Transparent;
            this.Amount.BaseColor = System.Drawing.Color.White;
            this.Amount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Amount.BorderSize = 3;
            this.Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Amount.FocusedBaseColor = System.Drawing.Color.White;
            this.Amount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Amount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Amount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Amount.Location = new System.Drawing.Point(305, 79);
            this.Amount.Name = "Amount";
            this.Amount.PasswordChar = '\0';
            this.Amount.Radius = 5;
            this.Amount.SelectedText = "";
            this.Amount.Size = new System.Drawing.Size(186, 77);
            this.Amount.TabIndex = 18;
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(47, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Expense Item:";
            // 
            // ExpenseItem
            // 
            this.ExpenseItem.BackColor = System.Drawing.Color.Transparent;
            this.ExpenseItem.BaseColor = System.Drawing.Color.White;
            this.ExpenseItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ExpenseItem.BorderSize = 3;
            this.ExpenseItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExpenseItem.FocusedBaseColor = System.Drawing.Color.White;
            this.ExpenseItem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ExpenseItem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.ExpenseItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExpenseItem.Location = new System.Drawing.Point(51, 79);
            this.ExpenseItem.Name = "ExpenseItem";
            this.ExpenseItem.PasswordChar = '\0';
            this.ExpenseItem.Radius = 5;
            this.ExpenseItem.SelectedText = "";
            this.ExpenseItem.Size = new System.Drawing.Size(239, 77);
            this.ExpenseItem.TabIndex = 16;
            this.ExpenseItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(721, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(471, 89);
            this.label4.TabIndex = 11;
            this.label4.Text = "Add Expenses";
            // 
            // Expenseslist
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.Expenseslist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Expenseslist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Expenseslist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Expenseslist.BackgroundColor = System.Drawing.Color.White;
            this.Expenseslist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Expenseslist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Expenseslist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Expenseslist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Expenseslist.ColumnHeadersHeight = 70;
            this.Expenseslist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Expenseslist.DefaultCellStyle = dataGridViewCellStyle8;
            this.Expenseslist.EnableHeadersVisualStyles = false;
            this.Expenseslist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.Expenseslist.Location = new System.Drawing.Point(-3, 532);
            this.Expenseslist.Name = "Expenseslist";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Expenseslist.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Expenseslist.RowHeadersVisible = false;
            this.Expenseslist.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Expenseslist.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Expenseslist.RowTemplate.Height = 24;
            this.Expenseslist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Expenseslist.Size = new System.Drawing.Size(1909, 526);
            this.Expenseslist.TabIndex = 12;
            this.Expenseslist.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Green;
            this.Expenseslist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.Expenseslist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Expenseslist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Expenseslist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Expenseslist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Expenseslist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Expenseslist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.Expenseslist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.Expenseslist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Expenseslist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Expenseslist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Expenseslist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Expenseslist.ThemeStyle.HeaderStyle.Height = 70;
            this.Expenseslist.ThemeStyle.ReadOnly = false;
            this.Expenseslist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.Expenseslist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Expenseslist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Expenseslist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Expenseslist.ThemeStyle.RowsStyle.Height = 24;
            this.Expenseslist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.Expenseslist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Expenseslist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Expenseslist_CellClick);
            this.Expenseslist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Expenseslist_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Expense Item";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Amount";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.gunaButton1);
            this.gunaShadowPanel2.Controls.Add(this.label3);
            this.gunaShadowPanel2.Controls.Add(this.SetGoal);
            this.gunaShadowPanel2.Controls.Add(this.addexpenses);
            this.gunaShadowPanel2.Controls.Add(this.AddIncome);
            this.gunaShadowPanel2.Controls.Add(this.Dashboard);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(27, 19);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 5;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(1847, 130);
            this.gunaShadowPanel2.TabIndex = 19;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(1431, 35);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(164, 65);
            this.gunaButton1.TabIndex = 10;
            this.gunaButton1.Text = "Budget";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(85, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 57);
            this.label3.TabIndex = 5;
            this.label3.Text = "MyFinance";
            // 
            // SetGoal
            // 
            this.SetGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetGoal.AnimationHoverSpeed = 0.07F;
            this.SetGoal.AnimationSpeed = 0.03F;
            this.SetGoal.BackColor = System.Drawing.Color.Transparent;
            this.SetGoal.BaseColor = System.Drawing.Color.Transparent;
            this.SetGoal.BorderColor = System.Drawing.Color.Transparent;
            this.SetGoal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetGoal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SetGoal.FocusedColor = System.Drawing.Color.Empty;
            this.SetGoal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SetGoal.Image = null;
            this.SetGoal.ImageSize = new System.Drawing.Size(20, 20);
            this.SetGoal.Location = new System.Drawing.Point(1566, 35);
            this.SetGoal.Name = "SetGoal";
            this.SetGoal.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.SetGoal.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.SetGoal.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SetGoal.OnHoverImage = null;
            this.SetGoal.OnPressedColor = System.Drawing.Color.Black;
            this.SetGoal.Radius = 10;
            this.SetGoal.Size = new System.Drawing.Size(164, 65);
            this.SetGoal.TabIndex = 9;
            this.SetGoal.Text = "Set Goal";
            this.SetGoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetGoal.Click += new System.EventHandler(this.SetGoal_Click);
            // 
            // addexpenses
            // 
            this.addexpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addexpenses.AnimationHoverSpeed = 0.07F;
            this.addexpenses.AnimationSpeed = 0.03F;
            this.addexpenses.BackColor = System.Drawing.Color.Transparent;
            this.addexpenses.BaseColor = System.Drawing.Color.Blue;
            this.addexpenses.BorderColor = System.Drawing.Color.Transparent;
            this.addexpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addexpenses.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addexpenses.FocusedColor = System.Drawing.Color.Empty;
            this.addexpenses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addexpenses.ForeColor = System.Drawing.Color.White;
            this.addexpenses.Image = null;
            this.addexpenses.ImageSize = new System.Drawing.Size(20, 20);
            this.addexpenses.Location = new System.Drawing.Point(1101, 35);
            this.addexpenses.Name = "addexpenses";
            this.addexpenses.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.addexpenses.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.addexpenses.OnHoverForeColor = System.Drawing.Color.White;
            this.addexpenses.OnHoverImage = null;
            this.addexpenses.OnPressedColor = System.Drawing.Color.Black;
            this.addexpenses.Radius = 10;
            this.addexpenses.Size = new System.Drawing.Size(164, 65);
            this.addexpenses.TabIndex = 6;
            this.addexpenses.Text = "Add Expenses";
            this.addexpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addexpenses.Click += new System.EventHandler(this.addexpenses_Click);
            // 
            // AddIncome
            // 
            this.AddIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddIncome.AnimationHoverSpeed = 0.07F;
            this.AddIncome.AnimationSpeed = 0.03F;
            this.AddIncome.BackColor = System.Drawing.Color.Transparent;
            this.AddIncome.BaseColor = System.Drawing.Color.Transparent;
            this.AddIncome.BorderColor = System.Drawing.Color.Transparent;
            this.AddIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddIncome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddIncome.FocusedColor = System.Drawing.Color.Empty;
            this.AddIncome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddIncome.Image = null;
            this.AddIncome.ImageSize = new System.Drawing.Size(20, 20);
            this.AddIncome.Location = new System.Drawing.Point(1280, 35);
            this.AddIncome.Name = "AddIncome";
            this.AddIncome.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.AddIncome.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.AddIncome.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddIncome.OnHoverImage = null;
            this.AddIncome.OnPressedColor = System.Drawing.Color.Black;
            this.AddIncome.Radius = 10;
            this.AddIncome.Size = new System.Drawing.Size(164, 65);
            this.AddIncome.TabIndex = 7;
            this.AddIncome.Text = "Add Income";
            this.AddIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddIncome.Click += new System.EventHandler(this.AddIncome_Click_1);
            // 
            // Dashboard
            // 
            this.Dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dashboard.AnimationHoverSpeed = 0.07F;
            this.Dashboard.AnimationSpeed = 0.03F;
            this.Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.Dashboard.BaseColor = System.Drawing.Color.Transparent;
            this.Dashboard.BorderColor = System.Drawing.Color.Transparent;
            this.Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Dashboard.FocusedColor = System.Drawing.Color.Empty;
            this.Dashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dashboard.Image = null;
            this.Dashboard.ImageSize = new System.Drawing.Size(20, 20);
            this.Dashboard.Location = new System.Drawing.Point(921, 35);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Dashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Dashboard.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dashboard.OnHoverImage = null;
            this.Dashboard.OnPressedColor = System.Drawing.Color.Black;
            this.Dashboard.Radius = 10;
            this.Dashboard.Size = new System.Drawing.Size(152, 65);
            this.Dashboard.TabIndex = 5;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click_1);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.AnimationHoverSpeed = 0.07F;
            this.Delete.AnimationSpeed = 0.03F;
            this.Delete.BackColor = System.Drawing.Color.Transparent;
            this.Delete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Delete.BorderColor = System.Drawing.Color.Transparent;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Delete.FocusedColor = System.Drawing.Color.Empty;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Image = null;
            this.Delete.ImageSize = new System.Drawing.Size(20, 20);
            this.Delete.Location = new System.Drawing.Point(521, 79);
            this.Delete.Name = "Delete";
            this.Delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Delete.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Delete.OnHoverForeColor = System.Drawing.Color.White;
            this.Delete.OnHoverImage = null;
            this.Delete.OnPressedColor = System.Drawing.Color.Black;
            this.Delete.Radius = 5;
            this.Delete.Size = new System.Drawing.Size(179, 74);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "Delete ";
            this.Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Personal_Finance_Data.Properties.Resources.final_bg21;
            this.ClientSize = new System.Drawing.Size(1902, 1055);
            this.Controls.Add(this.gunaShadowPanel2);
            this.Controls.Add(this.Expenseslist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Expenseslist)).EndInit();
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaButton add;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox Amount;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox ExpenseItem;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDataGridView Expenseslist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton SetGoal;
        private Guna.UI.WinForms.GunaButton addexpenses;
        private Guna.UI.WinForms.GunaButton AddIncome;
        private Guna.UI.WinForms.GunaButton Dashboard;
        private Guna.UI.WinForms.GunaButton Delete;
    }
}