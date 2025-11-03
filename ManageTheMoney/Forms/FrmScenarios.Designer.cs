namespace ManageTheMoney.Forms
{
    partial class FrmScenarios
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
            this.GrpEditScenarios = new System.Windows.Forms.GroupBox();
            this.BtnDeleteScenarios = new System.Windows.Forms.Button();
            this.BtnAddScenarios = new System.Windows.Forms.Button();
            this.GrpScenariosTable = new System.Windows.Forms.GroupBox();
            this.DgvScenariosTable = new System.Windows.Forms.DataGridView();
            this.BtnEditScenarios = new System.Windows.Forms.Button();
            this.GrpEditScenarios.SuspendLayout();
            this.GrpScenariosTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvScenariosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpEditScenarios
            // 
            this.GrpEditScenarios.Controls.Add(this.BtnEditScenarios);
            this.GrpEditScenarios.Controls.Add(this.BtnDeleteScenarios);
            this.GrpEditScenarios.Controls.Add(this.BtnAddScenarios);
            this.GrpEditScenarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpEditScenarios.Location = new System.Drawing.Point(0, 0);
            this.GrpEditScenarios.Name = "GrpEditScenarios";
            this.GrpEditScenarios.Size = new System.Drawing.Size(1568, 133);
            this.GrpEditScenarios.TabIndex = 0;
            this.GrpEditScenarios.TabStop = false;
            this.GrpEditScenarios.Text = "Edit";
            // 
            // BtnDeleteScenarios
            // 
            this.BtnDeleteScenarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteScenarios.Location = new System.Drawing.Point(129, 43);
            this.BtnDeleteScenarios.Name = "BtnDeleteScenarios";
            this.BtnDeleteScenarios.Size = new System.Drawing.Size(100, 55);
            this.BtnDeleteScenarios.TabIndex = 0;
            this.BtnDeleteScenarios.Text = "Delete Scenarios";
            this.BtnDeleteScenarios.UseVisualStyleBackColor = true;
            this.BtnDeleteScenarios.Click += new System.EventHandler(this.BtnDeleteScenarios_Click);
            // 
            // BtnAddScenarios
            // 
            this.BtnAddScenarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddScenarios.Location = new System.Drawing.Point(12, 43);
            this.BtnAddScenarios.Name = "BtnAddScenarios";
            this.BtnAddScenarios.Size = new System.Drawing.Size(100, 55);
            this.BtnAddScenarios.TabIndex = 0;
            this.BtnAddScenarios.Text = "Add Scenarios";
            this.BtnAddScenarios.UseVisualStyleBackColor = true;
            this.BtnAddScenarios.Click += new System.EventHandler(this.BtnAddScenarios_Click);
            // 
            // GrpScenariosTable
            // 
            this.GrpScenariosTable.Controls.Add(this.DgvScenariosTable);
            this.GrpScenariosTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpScenariosTable.Location = new System.Drawing.Point(0, 133);
            this.GrpScenariosTable.Name = "GrpScenariosTable";
            this.GrpScenariosTable.Size = new System.Drawing.Size(1568, 708);
            this.GrpScenariosTable.TabIndex = 1;
            this.GrpScenariosTable.TabStop = false;
            this.GrpScenariosTable.Text = "Scenarios Table";
            // 
            // DgvScenariosTable
            // 
            this.DgvScenariosTable.AllowUserToAddRows = false;
            this.DgvScenariosTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvScenariosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvScenariosTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvScenariosTable.Location = new System.Drawing.Point(3, 16);
            this.DgvScenariosTable.Name = "DgvScenariosTable";
            this.DgvScenariosTable.ReadOnly = true;
            this.DgvScenariosTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvScenariosTable.Size = new System.Drawing.Size(1562, 689);
            this.DgvScenariosTable.TabIndex = 0;
            // 
            // BtnEditScenarios
            // 
            this.BtnEditScenarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditScenarios.Location = new System.Drawing.Point(251, 43);
            this.BtnEditScenarios.Name = "BtnEditScenarios";
            this.BtnEditScenarios.Size = new System.Drawing.Size(100, 55);
            this.BtnEditScenarios.TabIndex = 1;
            this.BtnEditScenarios.Text = "Edit Scenarios";
            this.BtnEditScenarios.UseVisualStyleBackColor = true;
            this.BtnEditScenarios.Click += new System.EventHandler(this.BtnEditScenarios_Click);
            // 
            // FrmScenarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1568, 841);
            this.Controls.Add(this.GrpScenariosTable);
            this.Controls.Add(this.GrpEditScenarios);
            this.Name = "FrmScenarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmScenarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmScenarios_Load);
            this.GrpEditScenarios.ResumeLayout(false);
            this.GrpScenariosTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvScenariosTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpEditScenarios;
        private System.Windows.Forms.GroupBox GrpScenariosTable;
        private System.Windows.Forms.Button BtnAddScenarios;
        private System.Windows.Forms.Button BtnDeleteScenarios;
        private System.Windows.Forms.DataGridView DgvScenariosTable;
        private System.Windows.Forms.Button BtnEditScenarios;
    }
}