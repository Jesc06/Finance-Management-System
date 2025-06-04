namespace Personal_Finance_Data
{
    partial class AddIncome
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
            this.label4 = new System.Windows.Forms.Label();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.addamount = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.amount = new Guna.UI.WinForms.GunaTextBox();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.budget = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SetGoal = new Guna.UI.WinForms.GunaButton();
            this.AddExpense = new Guna.UI.WinForms.GunaButton();
            this.AddIncomes = new Guna.UI.WinForms.GunaButton();
            this.Dashboard = new Guna.UI.WinForms.GunaButton();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(759, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 89);
            this.label4.TabIndex = 14;
            this.label4.Text = "Add Income";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.addamount);
            this.gunaShadowPanel1.Controls.Add(this.label2);
            this.gunaShadowPanel1.Controls.Add(this.amount);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(581, 306);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 14;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(752, 506);
            this.gunaShadowPanel1.TabIndex = 13;
            // 
            // addamount
            // 
            this.addamount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addamount.AnimationHoverSpeed = 0.07F;
            this.addamount.AnimationSpeed = 0.03F;
            this.addamount.BackColor = System.Drawing.Color.Transparent;
            this.addamount.BaseColor = System.Drawing.Color.Blue;
            this.addamount.BorderColor = System.Drawing.Color.Transparent;
            this.addamount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addamount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addamount.FocusedColor = System.Drawing.Color.Empty;
            this.addamount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addamount.ForeColor = System.Drawing.Color.White;
            this.addamount.Image = null;
            this.addamount.ImageSize = new System.Drawing.Size(20, 20);
            this.addamount.Location = new System.Drawing.Point(88, 315);
            this.addamount.Name = "addamount";
            this.addamount.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addamount.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.addamount.OnHoverForeColor = System.Drawing.Color.White;
            this.addamount.OnHoverImage = null;
            this.addamount.OnPressedColor = System.Drawing.Color.Black;
            this.addamount.Radius = 10;
            this.addamount.Size = new System.Drawing.Size(578, 96);
            this.addamount.TabIndex = 11;
            this.addamount.Text = "Add Income";
            this.addamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addamount.Click += new System.EventHandler(this.addamount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(82, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 41);
            this.label2.TabIndex = 17;
            this.label2.Text = "Amount:";
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.Transparent;
            this.amount.BaseColor = System.Drawing.Color.White;
            this.amount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.amount.BorderSize = 3;
            this.amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amount.FocusedBaseColor = System.Drawing.Color.White;
            this.amount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.amount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.amount.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.amount.Location = new System.Drawing.Point(88, 134);
            this.amount.Name = "amount";
            this.amount.PasswordChar = '\0';
            this.amount.Radius = 5;
            this.amount.SelectedText = "";
            this.amount.Size = new System.Drawing.Size(578, 102);
            this.amount.TabIndex = 16;
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.AddIncomes);
            this.gunaShadowPanel2.Controls.Add(this.budget);
            this.gunaShadowPanel2.Controls.Add(this.label1);
            this.gunaShadowPanel2.Controls.Add(this.SetGoal);
            this.gunaShadowPanel2.Controls.Add(this.AddExpense);
            this.gunaShadowPanel2.Controls.Add(this.Dashboard);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(27, 20);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 5;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(1847, 130);
            this.gunaShadowPanel2.TabIndex = 16;
            // 
            // budget
            // 
            this.budget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.budget.AnimationHoverSpeed = 0.07F;
            this.budget.AnimationSpeed = 0.03F;
            this.budget.BackColor = System.Drawing.Color.Transparent;
            this.budget.BaseColor = System.Drawing.Color.Transparent;
            this.budget.BorderColor = System.Drawing.Color.Transparent;
            this.budget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.budget.DialogResult = System.Windows.Forms.DialogResult.None;
            this.budget.FocusedColor = System.Drawing.Color.Empty;
            this.budget.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.budget.Image = null;
            this.budget.ImageSize = new System.Drawing.Size(20, 20);
            this.budget.Location = new System.Drawing.Point(1431, 35);
            this.budget.Name = "budget";
            this.budget.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.budget.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.budget.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.budget.OnHoverImage = null;
            this.budget.OnPressedColor = System.Drawing.Color.Black;
            this.budget.Radius = 10;
            this.budget.Size = new System.Drawing.Size(164, 65);
            this.budget.TabIndex = 10;
            this.budget.Text = "Budget";
            this.budget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.budget.Click += new System.EventHandler(this.budget_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(85, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "MyFinance";
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
            // AddExpense
            // 
            this.AddExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddExpense.AnimationHoverSpeed = 0.07F;
            this.AddExpense.AnimationSpeed = 0.03F;
            this.AddExpense.BackColor = System.Drawing.Color.Transparent;
            this.AddExpense.BaseColor = System.Drawing.Color.Transparent;
            this.AddExpense.BorderColor = System.Drawing.Color.Transparent;
            this.AddExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddExpense.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddExpense.FocusedColor = System.Drawing.Color.Empty;
            this.AddExpense.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddExpense.Image = null;
            this.AddExpense.ImageSize = new System.Drawing.Size(20, 20);
            this.AddExpense.Location = new System.Drawing.Point(1109, 35);
            this.AddExpense.Name = "AddExpense";
            this.AddExpense.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.AddExpense.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.AddExpense.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddExpense.OnHoverImage = null;
            this.AddExpense.OnPressedColor = System.Drawing.Color.Black;
            this.AddExpense.Radius = 10;
            this.AddExpense.Size = new System.Drawing.Size(164, 65);
            this.AddExpense.TabIndex = 6;
            this.AddExpense.Text = "Add Expense";
            this.AddExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddExpense.Click += new System.EventHandler(this.AddExpense_Click);
            // 
            // AddIncomes
            // 
            this.AddIncomes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddIncomes.AnimationHoverSpeed = 0.07F;
            this.AddIncomes.AnimationSpeed = 0.03F;
            this.AddIncomes.BackColor = System.Drawing.Color.Transparent;
            this.AddIncomes.BaseColor = System.Drawing.Color.Blue;
            this.AddIncomes.BorderColor = System.Drawing.Color.Transparent;
            this.AddIncomes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddIncomes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddIncomes.FocusedColor = System.Drawing.Color.Empty;
            this.AddIncomes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIncomes.ForeColor = System.Drawing.Color.White;
            this.AddIncomes.Image = null;
            this.AddIncomes.ImageSize = new System.Drawing.Size(20, 20);
            this.AddIncomes.Location = new System.Drawing.Point(1280, 35);
            this.AddIncomes.Name = "AddIncomes";
            this.AddIncomes.OnHoverBaseColor = System.Drawing.Color.Blue;
            this.AddIncomes.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.AddIncomes.OnHoverForeColor = System.Drawing.Color.White;
            this.AddIncomes.OnHoverImage = null;
            this.AddIncomes.OnPressedColor = System.Drawing.Color.Black;
            this.AddIncomes.Radius = 10;
            this.AddIncomes.Size = new System.Drawing.Size(164, 65);
            this.AddIncomes.TabIndex = 7;
            this.AddIncomes.Text = "Add Income";
            this.AddIncomes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Personal_Finance_Data.Properties.Resources.final_bg22;
            this.ClientSize = new System.Drawing.Size(1902, 1055);
            this.Controls.Add(this.gunaShadowPanel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "AddIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddIncome";
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaButton addamount;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox amount;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private Guna.UI.WinForms.GunaButton budget;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton SetGoal;
        private Guna.UI.WinForms.GunaButton AddExpense;
        private Guna.UI.WinForms.GunaButton AddIncomes;
        private Guna.UI.WinForms.GunaButton Dashboard;
    }
}