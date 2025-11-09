namespace ManageTheMoney.Forms
{
    partial class FrmAddScenarios
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
            this.GrpAddScenario = new System.Windows.Forms.GroupBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblAmount = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.LblCurrency = new System.Windows.Forms.Label();
            this.CmbCurrency = new System.Windows.Forms.ComboBox();
            this.LblExpectedDate = new System.Windows.Forms.Label();
            this.DtpExpectedDate = new System.Windows.Forms.DateTimePicker();
            this.LblExpectedDateEnd = new System.Windows.Forms.Label();
            this.DtpExpectedDateEnd = new System.Windows.Forms.DateTimePicker();
            this.LblProbability = new System.Windows.Forms.Label();
            this.TxtProbability = new System.Windows.Forms.TextBox();
            this.ChbRecurring = new System.Windows.Forms.CheckBox();
            this.ChbRealized = new System.Windows.Forms.CheckBox();
            this.LblRealizedDate = new System.Windows.Forms.Label();
            this.DtpRealizedDate = new System.Windows.Forms.DateTimePicker();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.GrpAddScenario.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpAddScenario
            // 
            this.GrpAddScenario.Controls.Add(this.ChbRealized);
            this.GrpAddScenario.Controls.Add(this.ChbRecurring);
            this.GrpAddScenario.Controls.Add(this.DtpRealizedDate);
            this.GrpAddScenario.Controls.Add(this.DtpExpectedDateEnd);
            this.GrpAddScenario.Controls.Add(this.DtpExpectedDate);
            this.GrpAddScenario.Controls.Add(this.LblRealizedDate);
            this.GrpAddScenario.Controls.Add(this.LblExpectedDateEnd);
            this.GrpAddScenario.Controls.Add(this.CmbCurrency);
            this.GrpAddScenario.Controls.Add(this.LblExpectedDate);
            this.GrpAddScenario.Controls.Add(this.TxtProbability);
            this.GrpAddScenario.Controls.Add(this.TxtAmount);
            this.GrpAddScenario.Controls.Add(this.LblProbability);
            this.GrpAddScenario.Controls.Add(this.LblCurrency);
            this.GrpAddScenario.Controls.Add(this.LblAmount);
            this.GrpAddScenario.Controls.Add(this.TxtDescription);
            this.GrpAddScenario.Controls.Add(this.LblDescription);
            this.GrpAddScenario.Controls.Add(this.TxtTitle);
            this.GrpAddScenario.Controls.Add(this.LblTitle);
            this.GrpAddScenario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpAddScenario.Location = new System.Drawing.Point(0, 0);
            this.GrpAddScenario.Name = "GrpAddScenario";
            this.GrpAddScenario.Size = new System.Drawing.Size(822, 317);
            this.GrpAddScenario.TabIndex = 0;
            this.GrpAddScenario.TabStop = false;
            this.GrpAddScenario.Text = "Add Scenario";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(6, 57);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(33, 13);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Title :";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(45, 54);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(100, 20);
            this.TxtTitle.TabIndex = 1;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(197, 57);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(66, 13);
            this.LblDescription.TabIndex = 0;
            this.LblDescription.Text = "Description :";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(269, 54);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(100, 20);
            this.TxtDescription.TabIndex = 1;
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Location = new System.Drawing.Point(412, 57);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(49, 13);
            this.LblAmount.TabIndex = 0;
            this.LblAmount.Text = "Amount :";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(467, 54);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(100, 20);
            this.TxtAmount.TabIndex = 1;
            // 
            // LblCurrency
            // 
            this.LblCurrency.AutoSize = true;
            this.LblCurrency.Location = new System.Drawing.Point(620, 57);
            this.LblCurrency.Name = "LblCurrency";
            this.LblCurrency.Size = new System.Drawing.Size(55, 13);
            this.LblCurrency.TabIndex = 0;
            this.LblCurrency.Text = "Currency :";
            // 
            // CmbCurrency
            // 
            this.CmbCurrency.FormattingEnabled = true;
            this.CmbCurrency.Location = new System.Drawing.Point(681, 54);
            this.CmbCurrency.Name = "CmbCurrency";
            this.CmbCurrency.Size = new System.Drawing.Size(121, 21);
            this.CmbCurrency.TabIndex = 2;
            // 
            // LblExpectedDate
            // 
            this.LblExpectedDate.AutoSize = true;
            this.LblExpectedDate.Location = new System.Drawing.Point(5, 132);
            this.LblExpectedDate.Name = "LblExpectedDate";
            this.LblExpectedDate.Size = new System.Drawing.Size(84, 13);
            this.LblExpectedDate.TabIndex = 0;
            this.LblExpectedDate.Text = "Expected Date :";
            // 
            // DtpExpectedDate
            // 
            this.DtpExpectedDate.Location = new System.Drawing.Point(112, 126);
            this.DtpExpectedDate.Name = "DtpExpectedDate";
            this.DtpExpectedDate.Size = new System.Drawing.Size(200, 20);
            this.DtpExpectedDate.TabIndex = 3;
            // 
            // LblExpectedDateEnd
            // 
            this.LblExpectedDateEnd.AutoSize = true;
            this.LblExpectedDateEnd.Location = new System.Drawing.Point(349, 131);
            this.LblExpectedDateEnd.Name = "LblExpectedDateEnd";
            this.LblExpectedDateEnd.Size = new System.Drawing.Size(106, 13);
            this.LblExpectedDateEnd.TabIndex = 0;
            this.LblExpectedDateEnd.Text = "Expected Date End :";
            // 
            // DtpExpectedDateEnd
            // 
            this.DtpExpectedDateEnd.Location = new System.Drawing.Point(461, 125);
            this.DtpExpectedDateEnd.Name = "DtpExpectedDateEnd";
            this.DtpExpectedDateEnd.Size = new System.Drawing.Size(200, 20);
            this.DtpExpectedDateEnd.TabIndex = 3;
            // 
            // LblProbability
            // 
            this.LblProbability.AutoSize = true;
            this.LblProbability.Location = new System.Drawing.Point(12, 206);
            this.LblProbability.Name = "LblProbability";
            this.LblProbability.Size = new System.Drawing.Size(61, 13);
            this.LblProbability.TabIndex = 0;
            this.LblProbability.Text = "Probability :";
            // 
            // TxtProbability
            // 
            this.TxtProbability.Location = new System.Drawing.Point(79, 203);
            this.TxtProbability.Name = "TxtProbability";
            this.TxtProbability.Size = new System.Drawing.Size(100, 20);
            this.TxtProbability.TabIndex = 1;
            // 
            // ChbRecurring
            // 
            this.ChbRecurring.AutoSize = true;
            this.ChbRecurring.Location = new System.Drawing.Point(213, 206);
            this.ChbRecurring.Name = "ChbRecurring";
            this.ChbRecurring.Size = new System.Drawing.Size(72, 17);
            this.ChbRecurring.TabIndex = 4;
            this.ChbRecurring.Text = "Recurring";
            this.ChbRecurring.UseVisualStyleBackColor = true;
            // 
            // ChbRealized
            // 
            this.ChbRealized.AutoSize = true;
            this.ChbRealized.Location = new System.Drawing.Point(319, 206);
            this.ChbRealized.Name = "ChbRealized";
            this.ChbRealized.Size = new System.Drawing.Size(67, 17);
            this.ChbRealized.TabIndex = 4;
            this.ChbRealized.Text = "Realized";
            this.ChbRealized.UseVisualStyleBackColor = true;
            // 
            // LblRealizedDate
            // 
            this.LblRealizedDate.AutoSize = true;
            this.LblRealizedDate.Location = new System.Drawing.Point(412, 206);
            this.LblRealizedDate.Name = "LblRealizedDate";
            this.LblRealizedDate.Size = new System.Drawing.Size(80, 13);
            this.LblRealizedDate.TabIndex = 0;
            this.LblRealizedDate.Text = "Realized Date :";
            // 
            // DtpRealizedDate
            // 
            this.DtpRealizedDate.Location = new System.Drawing.Point(498, 203);
            this.DtpRealizedDate.Name = "DtpRealizedDate";
            this.DtpRealizedDate.Size = new System.Drawing.Size(200, 20);
            this.DtpRealizedDate.TabIndex = 3;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.Location = new System.Drawing.Point(12, 282);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(735, 282);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // FrmAddScenarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 317);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.GrpAddScenario);
            this.Name = "FrmAddScenarios";
            this.Text = "FrmAddScenarios";
            this.GrpAddScenario.ResumeLayout(false);
            this.GrpAddScenario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpAddScenario;
        private System.Windows.Forms.ComboBox CmbCurrency;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label LblCurrency;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.CheckBox ChbRecurring;
        private System.Windows.Forms.DateTimePicker DtpExpectedDateEnd;
        private System.Windows.Forms.DateTimePicker DtpExpectedDate;
        private System.Windows.Forms.Label LblExpectedDateEnd;
        private System.Windows.Forms.Label LblExpectedDate;
        private System.Windows.Forms.TextBox TxtProbability;
        private System.Windows.Forms.Label LblProbability;
        private System.Windows.Forms.CheckBox ChbRealized;
        private System.Windows.Forms.DateTimePicker DtpRealizedDate;
        private System.Windows.Forms.Label LblRealizedDate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
    }
}