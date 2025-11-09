namespace ManageTheMoney.Forms
{
    partial class FrmMainContent
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.PnlCalendar = new System.Windows.Forms.Panel();
            this.CmbYears = new System.Windows.Forms.ComboBox();
            this.CmbMonths = new System.Windows.Forms.ComboBox();
            this.GrpStatament = new System.Windows.Forms.GroupBox();
            this.PnlStatementPie = new System.Windows.Forms.Panel();
            this.ChrtStatement = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PnlStatementText = new System.Windows.Forms.Panel();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtExpenses = new System.Windows.Forms.TextBox();
            this.LblExpenses = new System.Windows.Forms.Label();
            this.LblIncomes = new System.Windows.Forms.Label();
            this.TxtIncomes = new System.Windows.Forms.TextBox();
            this.GrpPreviousStatement = new System.Windows.Forms.GroupBox();
            this.PnlPreviousStatementPie = new System.Windows.Forms.Panel();
            this.ChrtPreviousStatement = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PnlPreviousStatementText = new System.Windows.Forms.Panel();
            this.TxtPreviousTotal = new System.Windows.Forms.TextBox();
            this.LblPreviousTotal = new System.Windows.Forms.Label();
            this.TxtPreviousExpenses = new System.Windows.Forms.TextBox();
            this.LblPreviousExpenses = new System.Windows.Forms.Label();
            this.LblPreviousIncomes = new System.Windows.Forms.Label();
            this.TxtPreviousIncomes = new System.Windows.Forms.TextBox();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.PnlCalendar.SuspendLayout();
            this.GrpStatament.SuspendLayout();
            this.PnlStatementPie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtStatement)).BeginInit();
            this.PnlStatementText.SuspendLayout();
            this.GrpPreviousStatement.SuspendLayout();
            this.PnlPreviousStatementPie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtPreviousStatement)).BeginInit();
            this.PnlPreviousStatementText.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPrevious.Location = new System.Drawing.Point(0, 0);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(75, 841);
            this.BtnPrevious.TabIndex = 0;
            this.BtnPrevious.Text = "<";
            this.BtnPrevious.UseVisualStyleBackColor = false;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNext.Location = new System.Drawing.Point(1493, 0);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 841);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // PnlCalendar
            // 
            this.PnlCalendar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PnlCalendar.Controls.Add(this.CmbYears);
            this.PnlCalendar.Controls.Add(this.CmbDays);
            this.PnlCalendar.Controls.Add(this.CmbMonths);
            this.PnlCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCalendar.Location = new System.Drawing.Point(75, 0);
            this.PnlCalendar.Name = "PnlCalendar";
            this.PnlCalendar.Size = new System.Drawing.Size(1418, 100);
            this.PnlCalendar.TabIndex = 2;
            // 
            // CmbYears
            // 
            this.CmbYears.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbYears.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CmbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbYears.FormattingEnabled = true;
            this.CmbYears.IntegralHeight = false;
            this.CmbYears.Items.AddRange(new object[] {
            "Month",
            "Month2"});
            this.CmbYears.Location = new System.Drawing.Point(1069, 11);
            this.CmbYears.MaxDropDownItems = 5;
            this.CmbYears.Name = "CmbYears";
            this.CmbYears.Size = new System.Drawing.Size(343, 81);
            this.CmbYears.TabIndex = 5;
            // 
            // CmbMonths
            // 
            this.CmbMonths.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CmbMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbMonths.FormattingEnabled = true;
            this.CmbMonths.IntegralHeight = false;
            this.CmbMonths.Items.AddRange(new object[] {
            "Month",
            "Month2"});
            this.CmbMonths.Location = new System.Drawing.Point(16, 11);
            this.CmbMonths.MaxDropDownItems = 5;
            this.CmbMonths.Name = "CmbMonths";
            this.CmbMonths.Size = new System.Drawing.Size(343, 81);
            this.CmbMonths.TabIndex = 4;
            // 
            // GrpStatament
            // 
            this.GrpStatament.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GrpStatament.Controls.Add(this.PnlStatementPie);
            this.GrpStatament.Controls.Add(this.PnlStatementText);
            this.GrpStatament.Dock = System.Windows.Forms.DockStyle.Right;
            this.GrpStatament.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrpStatament.Location = new System.Drawing.Point(785, 100);
            this.GrpStatament.Name = "GrpStatament";
            this.GrpStatament.Size = new System.Drawing.Size(708, 741);
            this.GrpStatament.TabIndex = 4;
            this.GrpStatament.TabStop = false;
            this.GrpStatament.Text = "Statement";
            // 
            // PnlStatementPie
            // 
            this.PnlStatementPie.Controls.Add(this.ChrtStatement);
            this.PnlStatementPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlStatementPie.Location = new System.Drawing.Point(3, 395);
            this.PnlStatementPie.Name = "PnlStatementPie";
            this.PnlStatementPie.Size = new System.Drawing.Size(702, 343);
            this.PnlStatementPie.TabIndex = 12;
            // 
            // ChrtStatement
            // 
            chartArea7.Name = "ChartArea1";
            this.ChrtStatement.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            legend7.Title = "Previous Statement Graph";
            this.ChrtStatement.Legends.Add(legend7);
            this.ChrtStatement.Location = new System.Drawing.Point(80, 34);
            this.ChrtStatement.Name = "ChrtStatement";
            this.ChrtStatement.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.ChrtStatement.Series.Add(series7);
            this.ChrtStatement.Size = new System.Drawing.Size(543, 300);
            this.ChrtStatement.TabIndex = 12;
            this.ChrtStatement.Text = "chart1";
            // 
            // PnlStatementText
            // 
            this.PnlStatementText.Controls.Add(this.TxtTotal);
            this.PnlStatementText.Controls.Add(this.LblTotal);
            this.PnlStatementText.Controls.Add(this.TxtExpenses);
            this.PnlStatementText.Controls.Add(this.LblExpenses);
            this.PnlStatementText.Controls.Add(this.LblIncomes);
            this.PnlStatementText.Controls.Add(this.TxtIncomes);
            this.PnlStatementText.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlStatementText.Location = new System.Drawing.Point(3, 45);
            this.PnlStatementText.Name = "PnlStatementText";
            this.PnlStatementText.Size = new System.Drawing.Size(702, 350);
            this.PnlStatementText.TabIndex = 11;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTotal.Location = new System.Drawing.Point(289, 240);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(334, 62);
            this.TxtTotal.TabIndex = 14;
            this.TxtTotal.Text = "2000";
            // 
            // LblTotal
            // 
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotal.Location = new System.Drawing.Point(73, 223);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(203, 100);
            this.LblTotal.TabIndex = 13;
            this.LblTotal.Text = "Total :";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtExpenses
            // 
            this.TxtExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtExpenses.Location = new System.Drawing.Point(289, 145);
            this.TxtExpenses.Name = "TxtExpenses";
            this.TxtExpenses.ReadOnly = true;
            this.TxtExpenses.Size = new System.Drawing.Size(334, 62);
            this.TxtExpenses.TabIndex = 12;
            this.TxtExpenses.Text = "4000";
            // 
            // LblExpenses
            // 
            this.LblExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblExpenses.Location = new System.Drawing.Point(73, 128);
            this.LblExpenses.Name = "LblExpenses";
            this.LblExpenses.Size = new System.Drawing.Size(210, 100);
            this.LblExpenses.TabIndex = 11;
            this.LblExpenses.Text = "Expenses :";
            this.LblExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblIncomes
            // 
            this.LblIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblIncomes.Location = new System.Drawing.Point(73, 25);
            this.LblIncomes.Name = "LblIncomes";
            this.LblIncomes.Size = new System.Drawing.Size(191, 100);
            this.LblIncomes.TabIndex = 10;
            this.LblIncomes.Text = "Incomes :";
            this.LblIncomes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtIncomes
            // 
            this.TxtIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtIncomes.Location = new System.Drawing.Point(289, 42);
            this.TxtIncomes.Name = "TxtIncomes";
            this.TxtIncomes.ReadOnly = true;
            this.TxtIncomes.Size = new System.Drawing.Size(334, 62);
            this.TxtIncomes.TabIndex = 9;
            this.TxtIncomes.Text = "6000";
            // 
            // GrpPreviousStatement
            // 
            this.GrpPreviousStatement.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GrpPreviousStatement.Controls.Add(this.PnlPreviousStatementPie);
            this.GrpPreviousStatement.Controls.Add(this.PnlPreviousStatementText);
            this.GrpPreviousStatement.Dock = System.Windows.Forms.DockStyle.Left;
            this.GrpPreviousStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrpPreviousStatement.Location = new System.Drawing.Point(75, 100);
            this.GrpPreviousStatement.Name = "GrpPreviousStatement";
            this.GrpPreviousStatement.Size = new System.Drawing.Size(712, 741);
            this.GrpPreviousStatement.TabIndex = 5;
            this.GrpPreviousStatement.TabStop = false;
            this.GrpPreviousStatement.Text = "Previous Statement";
            // 
            // PnlPreviousStatementPie
            // 
            this.PnlPreviousStatementPie.Controls.Add(this.ChrtPreviousStatement);
            this.PnlPreviousStatementPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlPreviousStatementPie.Location = new System.Drawing.Point(3, 395);
            this.PnlPreviousStatementPie.Name = "PnlPreviousStatementPie";
            this.PnlPreviousStatementPie.Size = new System.Drawing.Size(706, 343);
            this.PnlPreviousStatementPie.TabIndex = 11;
            // 
            // ChrtPreviousStatement
            // 
            chartArea8.Name = "ChartArea1";
            this.ChrtPreviousStatement.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            legend8.Title = "Previous Statement Graph";
            this.ChrtPreviousStatement.Legends.Add(legend8);
            this.ChrtPreviousStatement.Location = new System.Drawing.Point(80, 34);
            this.ChrtPreviousStatement.Name = "ChrtPreviousStatement";
            this.ChrtPreviousStatement.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.ChrtPreviousStatement.Series.Add(series8);
            this.ChrtPreviousStatement.Size = new System.Drawing.Size(543, 300);
            this.ChrtPreviousStatement.TabIndex = 9;
            this.ChrtPreviousStatement.Text = "chart1";
            // 
            // PnlPreviousStatementText
            // 
            this.PnlPreviousStatementText.Controls.Add(this.TxtPreviousTotal);
            this.PnlPreviousStatementText.Controls.Add(this.LblPreviousTotal);
            this.PnlPreviousStatementText.Controls.Add(this.TxtPreviousExpenses);
            this.PnlPreviousStatementText.Controls.Add(this.LblPreviousExpenses);
            this.PnlPreviousStatementText.Controls.Add(this.LblPreviousIncomes);
            this.PnlPreviousStatementText.Controls.Add(this.TxtPreviousIncomes);
            this.PnlPreviousStatementText.Location = new System.Drawing.Point(3, 45);
            this.PnlPreviousStatementText.Name = "PnlPreviousStatementText";
            this.PnlPreviousStatementText.Size = new System.Drawing.Size(706, 350);
            this.PnlPreviousStatementText.TabIndex = 10;
            // 
            // TxtPreviousTotal
            // 
            this.TxtPreviousTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPreviousTotal.Location = new System.Drawing.Point(289, 240);
            this.TxtPreviousTotal.Name = "TxtPreviousTotal";
            this.TxtPreviousTotal.ReadOnly = true;
            this.TxtPreviousTotal.Size = new System.Drawing.Size(334, 62);
            this.TxtPreviousTotal.TabIndex = 14;
            this.TxtPreviousTotal.Text = "1000";
            // 
            // LblPreviousTotal
            // 
            this.LblPreviousTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPreviousTotal.Location = new System.Drawing.Point(73, 223);
            this.LblPreviousTotal.Name = "LblPreviousTotal";
            this.LblPreviousTotal.Size = new System.Drawing.Size(210, 100);
            this.LblPreviousTotal.TabIndex = 13;
            this.LblPreviousTotal.Text = "Previous Total :";
            this.LblPreviousTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtPreviousExpenses
            // 
            this.TxtPreviousExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPreviousExpenses.Location = new System.Drawing.Point(289, 145);
            this.TxtPreviousExpenses.Name = "TxtPreviousExpenses";
            this.TxtPreviousExpenses.ReadOnly = true;
            this.TxtPreviousExpenses.Size = new System.Drawing.Size(334, 62);
            this.TxtPreviousExpenses.TabIndex = 12;
            this.TxtPreviousExpenses.Text = "5000";
            // 
            // LblPreviousExpenses
            // 
            this.LblPreviousExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPreviousExpenses.Location = new System.Drawing.Point(73, 128);
            this.LblPreviousExpenses.Name = "LblPreviousExpenses";
            this.LblPreviousExpenses.Size = new System.Drawing.Size(210, 100);
            this.LblPreviousExpenses.TabIndex = 11;
            this.LblPreviousExpenses.Text = "Previous Expenses :";
            this.LblPreviousExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblPreviousIncomes
            // 
            this.LblPreviousIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPreviousIncomes.Location = new System.Drawing.Point(73, 27);
            this.LblPreviousIncomes.Name = "LblPreviousIncomes";
            this.LblPreviousIncomes.Size = new System.Drawing.Size(210, 100);
            this.LblPreviousIncomes.TabIndex = 10;
            this.LblPreviousIncomes.Text = "Previous Incomes :";
            this.LblPreviousIncomes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtPreviousIncomes
            // 
            this.TxtPreviousIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPreviousIncomes.Location = new System.Drawing.Point(289, 45);
            this.TxtPreviousIncomes.Name = "TxtPreviousIncomes";
            this.TxtPreviousIncomes.ReadOnly = true;
            this.TxtPreviousIncomes.Size = new System.Drawing.Size(334, 62);
            this.TxtPreviousIncomes.TabIndex = 9;
            this.TxtPreviousIncomes.Text = "6000";
            // 
            // CmbDays
            // 
            this.CmbDays.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CmbDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.IntegralHeight = false;
            this.CmbDays.Items.AddRange(new object[] {
            "Month",
            "Month2"});
            this.CmbDays.Location = new System.Drawing.Point(547, 11);
            this.CmbDays.MaxDropDownItems = 5;
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(343, 81);
            this.CmbDays.TabIndex = 4;
            // 
            // FrmMainContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1568, 841);
            this.Controls.Add(this.GrpPreviousStatement);
            this.Controls.Add(this.GrpStatament);
            this.Controls.Add(this.PnlCalendar);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Name = "FrmMainContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainContent_Load);
            this.PnlCalendar.ResumeLayout(false);
            this.GrpStatament.ResumeLayout(false);
            this.PnlStatementPie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChrtStatement)).EndInit();
            this.PnlStatementText.ResumeLayout(false);
            this.PnlStatementText.PerformLayout();
            this.GrpPreviousStatement.ResumeLayout(false);
            this.PnlPreviousStatementPie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChrtPreviousStatement)).EndInit();
            this.PnlPreviousStatementText.ResumeLayout(false);
            this.PnlPreviousStatementText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Panel PnlCalendar;
        private System.Windows.Forms.GroupBox GrpStatament;
        private System.Windows.Forms.GroupBox GrpPreviousStatement;
        private System.Windows.Forms.ComboBox CmbMonths;
        private System.Windows.Forms.ComboBox CmbYears;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChrtPreviousStatement;
        private System.Windows.Forms.Panel PnlStatementPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChrtStatement;
        private System.Windows.Forms.Panel PnlStatementText;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtExpenses;
        private System.Windows.Forms.Label LblExpenses;
        private System.Windows.Forms.Label LblIncomes;
        private System.Windows.Forms.TextBox TxtIncomes;
        private System.Windows.Forms.Panel PnlPreviousStatementText;
        private System.Windows.Forms.Panel PnlPreviousStatementPie;
        private System.Windows.Forms.TextBox TxtPreviousTotal;
        private System.Windows.Forms.Label LblPreviousTotal;
        private System.Windows.Forms.TextBox TxtPreviousExpenses;
        private System.Windows.Forms.Label LblPreviousExpenses;
        private System.Windows.Forms.Label LblPreviousIncomes;
        private System.Windows.Forms.TextBox TxtPreviousIncomes;
        private System.Windows.Forms.ComboBox CmbDays;
    }
}