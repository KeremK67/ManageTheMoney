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
            this.CmbNecessary = new System.Windows.Forms.CheckBox();
            this.ChbRealized = new System.Windows.Forms.CheckBox();
            this.ChbRecurring = new System.Windows.Forms.CheckBox();
            this.DtpRealizedDate = new System.Windows.Forms.DateTimePicker();
            this.DtpExpectedDateEnd = new System.Windows.Forms.DateTimePicker();
            this.DtpExpectedDate = new System.Windows.Forms.DateTimePicker();
            this.LblRealizedDate = new System.Windows.Forms.Label();
            this.LblExpectedDateEnd = new System.Windows.Forms.Label();
            this.CmbAccount = new System.Windows.Forms.ComboBox();
            this.LblExpectedDate = new System.Windows.Forms.Label();
            this.TxtProbability = new System.Windows.Forms.TextBox();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.LblAccount = new System.Windows.Forms.Label();
            this.LblProbability = new System.Windows.Forms.Label();
            this.LblAmount = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ChbExpectedDateNull = new System.Windows.Forms.CheckBox();
            this.ChbRealizedDateNull = new System.Windows.Forms.CheckBox();
            this.ChbExpectedDateEndNull = new System.Windows.Forms.CheckBox();
            this.LblScenarioType = new System.Windows.Forms.Label();
            this.CmbScenarioType = new System.Windows.Forms.ComboBox();
            this.ChbScenarioCategory = new System.Windows.Forms.CheckBox();
            this.GrpAddScenario.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpAddScenario
            // 
            this.GrpAddScenario.Controls.Add(this.ChbScenarioCategory);
            this.GrpAddScenario.Controls.Add(this.BtnAdd);
            this.GrpAddScenario.Controls.Add(this.BtnCancel);
            this.GrpAddScenario.Controls.Add(this.CmbNecessary);
            this.GrpAddScenario.Controls.Add(this.ChbRealized);
            this.GrpAddScenario.Controls.Add(this.ChbExpectedDateEndNull);
            this.GrpAddScenario.Controls.Add(this.ChbRealizedDateNull);
            this.GrpAddScenario.Controls.Add(this.ChbExpectedDateNull);
            this.GrpAddScenario.Controls.Add(this.ChbRecurring);
            this.GrpAddScenario.Controls.Add(this.DtpRealizedDate);
            this.GrpAddScenario.Controls.Add(this.DtpExpectedDateEnd);
            this.GrpAddScenario.Controls.Add(this.DtpExpectedDate);
            this.GrpAddScenario.Controls.Add(this.LblRealizedDate);
            this.GrpAddScenario.Controls.Add(this.LblExpectedDateEnd);
            this.GrpAddScenario.Controls.Add(this.CmbAccount);
            this.GrpAddScenario.Controls.Add(this.CmbScenarioType);
            this.GrpAddScenario.Controls.Add(this.LblExpectedDate);
            this.GrpAddScenario.Controls.Add(this.TxtProbability);
            this.GrpAddScenario.Controls.Add(this.TxtAmount);
            this.GrpAddScenario.Controls.Add(this.LblAccount);
            this.GrpAddScenario.Controls.Add(this.LblProbability);
            this.GrpAddScenario.Controls.Add(this.LblScenarioType);
            this.GrpAddScenario.Controls.Add(this.LblAmount);
            this.GrpAddScenario.Controls.Add(this.TxtDescription);
            this.GrpAddScenario.Controls.Add(this.LblDescription);
            this.GrpAddScenario.Controls.Add(this.TxtTitle);
            this.GrpAddScenario.Controls.Add(this.LblTitle);
            this.GrpAddScenario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpAddScenario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrpAddScenario.Location = new System.Drawing.Point(0, 0);
            this.GrpAddScenario.Name = "GrpAddScenario";
            this.GrpAddScenario.Size = new System.Drawing.Size(921, 495);
            this.GrpAddScenario.TabIndex = 0;
            this.GrpAddScenario.TabStop = false;
            this.GrpAddScenario.Text = "Add Scenario";
            // 
            // CmbNecessary
            // 
            this.CmbNecessary.AutoSize = true;
            this.CmbNecessary.Checked = true;
            this.CmbNecessary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CmbNecessary.Location = new System.Drawing.Point(534, 394);
            this.CmbNecessary.Name = "CmbNecessary";
            this.CmbNecessary.Size = new System.Drawing.Size(118, 28);
            this.CmbNecessary.TabIndex = 4;
            this.CmbNecessary.Text = "Necessary";
            this.CmbNecessary.UseVisualStyleBackColor = true;
            // 
            // ChbRealized
            // 
            this.ChbRealized.AutoSize = true;
            this.ChbRealized.Location = new System.Drawing.Point(413, 394);
            this.ChbRealized.Name = "ChbRealized";
            this.ChbRealized.Size = new System.Drawing.Size(102, 28);
            this.ChbRealized.TabIndex = 4;
            this.ChbRealized.Text = "Realized";
            this.ChbRealized.UseVisualStyleBackColor = true;
            // 
            // ChbRecurring
            // 
            this.ChbRecurring.AutoSize = true;
            this.ChbRecurring.Location = new System.Drawing.Point(280, 394);
            this.ChbRecurring.Name = "ChbRecurring";
            this.ChbRecurring.Size = new System.Drawing.Size(112, 28);
            this.ChbRecurring.TabIndex = 4;
            this.ChbRecurring.Text = "Recurring";
            this.ChbRecurring.UseVisualStyleBackColor = true;
            // 
            // DtpRealizedDate
            // 
            this.DtpRealizedDate.Location = new System.Drawing.Point(430, 315);
            this.DtpRealizedDate.Name = "DtpRealizedDate";
            this.DtpRealizedDate.Size = new System.Drawing.Size(170, 29);
            this.DtpRealizedDate.TabIndex = 3;
            // 
            // DtpExpectedDateEnd
            // 
            this.DtpExpectedDateEnd.Location = new System.Drawing.Point(658, 249);
            this.DtpExpectedDateEnd.Name = "DtpExpectedDateEnd";
            this.DtpExpectedDateEnd.Size = new System.Drawing.Size(170, 29);
            this.DtpExpectedDateEnd.TabIndex = 3;
            // 
            // DtpExpectedDate
            // 
            this.DtpExpectedDate.Location = new System.Drawing.Point(215, 249);
            this.DtpExpectedDate.Name = "DtpExpectedDate";
            this.DtpExpectedDate.Size = new System.Drawing.Size(170, 29);
            this.DtpExpectedDate.TabIndex = 3;
            // 
            // LblRealizedDate
            // 
            this.LblRealizedDate.AutoSize = true;
            this.LblRealizedDate.Location = new System.Drawing.Point(288, 319);
            this.LblRealizedDate.Name = "LblRealizedDate";
            this.LblRealizedDate.Size = new System.Drawing.Size(136, 24);
            this.LblRealizedDate.TabIndex = 0;
            this.LblRealizedDate.Text = "Realized Date :";
            this.LblRealizedDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblExpectedDateEnd
            // 
            this.LblExpectedDateEnd.AutoSize = true;
            this.LblExpectedDateEnd.Location = new System.Drawing.Point(468, 252);
            this.LblExpectedDateEnd.Name = "LblExpectedDateEnd";
            this.LblExpectedDateEnd.Size = new System.Drawing.Size(184, 24);
            this.LblExpectedDateEnd.TabIndex = 0;
            this.LblExpectedDateEnd.Text = "Expected Date End :";
            this.LblExpectedDateEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbAccount
            // 
            this.CmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAccount.FormattingEnabled = true;
            this.CmbAccount.Location = new System.Drawing.Point(643, 68);
            this.CmbAccount.Name = "CmbAccount";
            this.CmbAccount.Size = new System.Drawing.Size(170, 32);
            this.CmbAccount.TabIndex = 2;
            // 
            // LblExpectedDate
            // 
            this.LblExpectedDate.AutoSize = true;
            this.LblExpectedDate.Location = new System.Drawing.Point(65, 253);
            this.LblExpectedDate.Name = "LblExpectedDate";
            this.LblExpectedDate.Size = new System.Drawing.Size(144, 24);
            this.LblExpectedDate.TabIndex = 0;
            this.LblExpectedDate.Text = "Expected Date :";
            this.LblExpectedDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtProbability
            // 
            this.TxtProbability.Location = new System.Drawing.Point(643, 175);
            this.TxtProbability.Name = "TxtProbability";
            this.TxtProbability.Size = new System.Drawing.Size(170, 29);
            this.TxtProbability.TabIndex = 1;
            this.TxtProbability.Text = "100";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(235, 175);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(170, 29);
            this.TxtAmount.TabIndex = 1;
            // 
            // LblAccount
            // 
            this.LblAccount.AutoSize = true;
            this.LblAccount.Location = new System.Drawing.Point(547, 71);
            this.LblAccount.Name = "LblAccount";
            this.LblAccount.Size = new System.Drawing.Size(90, 24);
            this.LblAccount.TabIndex = 0;
            this.LblAccount.Text = "Account :";
            this.LblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblProbability
            // 
            this.LblProbability.AutoSize = true;
            this.LblProbability.Location = new System.Drawing.Point(531, 178);
            this.LblProbability.Name = "LblProbability";
            this.LblProbability.Size = new System.Drawing.Size(106, 24);
            this.LblProbability.TabIndex = 0;
            this.LblProbability.Text = "Probability :";
            this.LblProbability.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Location = new System.Drawing.Point(136, 178);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(93, 24);
            this.LblAmount.TabIndex = 0;
            this.LblAmount.Text = "*Amount :";
            this.LblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(235, 122);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(170, 29);
            this.TxtDescription.TabIndex = 1;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(115, 127);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(114, 24);
            this.LblDescription.TabIndex = 0;
            this.LblDescription.Text = "Description :";
            this.LblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(235, 68);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(170, 29);
            this.TxtTitle.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(167, 71);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(62, 24);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "*Title :";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCancel.Location = new System.Drawing.Point(12, 441);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(94, 42);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.Location = new System.Drawing.Point(815, 441);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 42);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ChbExpectedDateNull
            // 
            this.ChbExpectedDateNull.AutoSize = true;
            this.ChbExpectedDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbExpectedDateNull.Location = new System.Drawing.Point(391, 253);
            this.ChbExpectedDateNull.Name = "ChbExpectedDateNull";
            this.ChbExpectedDateNull.Size = new System.Drawing.Size(49, 20);
            this.ChbExpectedDateNull.TabIndex = 4;
            this.ChbExpectedDateNull.Text = "Null";
            this.ChbExpectedDateNull.UseVisualStyleBackColor = true;
            this.ChbExpectedDateNull.CheckedChanged += new System.EventHandler(this.ChbExpectedDateNull_CheckedChanged);
            // 
            // ChbRealizedDateNull
            // 
            this.ChbRealizedDateNull.AutoSize = true;
            this.ChbRealizedDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbRealizedDateNull.Location = new System.Drawing.Point(606, 319);
            this.ChbRealizedDateNull.Name = "ChbRealizedDateNull";
            this.ChbRealizedDateNull.Size = new System.Drawing.Size(49, 20);
            this.ChbRealizedDateNull.TabIndex = 4;
            this.ChbRealizedDateNull.Text = "Null";
            this.ChbRealizedDateNull.UseVisualStyleBackColor = true;
            this.ChbRealizedDateNull.CheckedChanged += new System.EventHandler(this.ChbRealizedDateNull_CheckedChanged);
            // 
            // ChbExpectedDateEndNull
            // 
            this.ChbExpectedDateEndNull.AutoSize = true;
            this.ChbExpectedDateEndNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbExpectedDateEndNull.Location = new System.Drawing.Point(834, 253);
            this.ChbExpectedDateEndNull.Name = "ChbExpectedDateEndNull";
            this.ChbExpectedDateEndNull.Size = new System.Drawing.Size(49, 20);
            this.ChbExpectedDateEndNull.TabIndex = 4;
            this.ChbExpectedDateEndNull.Text = "Null";
            this.ChbExpectedDateEndNull.UseVisualStyleBackColor = true;
            this.ChbExpectedDateEndNull.CheckedChanged += new System.EventHandler(this.ChbExpectedDateEndNull_CheckedChanged);
            // 
            // LblScenarioType
            // 
            this.LblScenarioType.AutoSize = true;
            this.LblScenarioType.Location = new System.Drawing.Point(499, 125);
            this.LblScenarioType.Name = "LblScenarioType";
            this.LblScenarioType.Size = new System.Drawing.Size(138, 24);
            this.LblScenarioType.TabIndex = 0;
            this.LblScenarioType.Text = "ScenarioType :";
            this.LblScenarioType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbScenarioType
            // 
            this.CmbScenarioType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbScenarioType.FormattingEnabled = true;
            this.CmbScenarioType.Location = new System.Drawing.Point(643, 122);
            this.CmbScenarioType.Name = "CmbScenarioType";
            this.CmbScenarioType.Size = new System.Drawing.Size(170, 32);
            this.CmbScenarioType.TabIndex = 2;
            // 
            // ChbScenarioCategory
            // 
            this.ChbScenarioCategory.AutoSize = true;
            this.ChbScenarioCategory.Checked = true;
            this.ChbScenarioCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChbScenarioCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbScenarioCategory.Location = new System.Drawing.Point(819, 130);
            this.ChbScenarioCategory.Name = "ChbScenarioCategory";
            this.ChbScenarioCategory.Size = new System.Drawing.Size(77, 20);
            this.ChbScenarioCategory.TabIndex = 5;
            this.ChbScenarioCategory.Text = "Incomes";
            this.ChbScenarioCategory.UseVisualStyleBackColor = true;
            this.ChbScenarioCategory.CheckedChanged += new System.EventHandler(this.ChbScenarioCategory_CheckedChanged);
            // 
            // FrmAddScenarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(921, 495);
            this.Controls.Add(this.GrpAddScenario);
            this.Name = "FrmAddScenarios";
            this.Text = "FrmAddScenarios";
            this.Load += new System.EventHandler(this.FrmAddScenarios_Load);
            this.GrpAddScenario.ResumeLayout(false);
            this.GrpAddScenario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpAddScenario;
        private System.Windows.Forms.TextBox TxtAmount;
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
        private System.Windows.Forms.CheckBox CmbNecessary;
        private System.Windows.Forms.ComboBox CmbAccount;
        private System.Windows.Forms.Label LblAccount;
        private System.Windows.Forms.CheckBox ChbExpectedDateEndNull;
        private System.Windows.Forms.CheckBox ChbRealizedDateNull;
        private System.Windows.Forms.CheckBox ChbExpectedDateNull;
        private System.Windows.Forms.ComboBox CmbScenarioType;
        private System.Windows.Forms.Label LblScenarioType;
        private System.Windows.Forms.CheckBox ChbScenarioCategory;
    }
}