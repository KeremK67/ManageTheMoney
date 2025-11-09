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
            this.BtnEditScenario = new System.Windows.Forms.Button();
            this.BtnDeleteScenario = new System.Windows.Forms.Button();
            this.BtnAddScenario = new System.Windows.Forms.Button();
            this.GrpScenariosTable = new System.Windows.Forms.GroupBox();
            this.DgvScenariosTable = new System.Windows.Forms.DataGridView();
            this.GrpEditScenarios.SuspendLayout();
            this.GrpScenariosTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvScenariosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpEditScenarios
            // 
            this.GrpEditScenarios.Controls.Add(this.BtnEditScenario);
            this.GrpEditScenarios.Controls.Add(this.BtnDeleteScenario);
            this.GrpEditScenarios.Controls.Add(this.BtnAddScenario);
            this.GrpEditScenarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpEditScenarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrpEditScenarios.Location = new System.Drawing.Point(0, 0);
            this.GrpEditScenarios.Name = "GrpEditScenarios";
            this.GrpEditScenarios.Size = new System.Drawing.Size(1568, 133);
            this.GrpEditScenarios.TabIndex = 0;
            this.GrpEditScenarios.TabStop = false;
            this.GrpEditScenarios.Text = "Edit";
            // 
            // BtnEditScenario
            // 
            this.BtnEditScenario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEditScenario.Location = new System.Drawing.Point(284, 43);
            this.BtnEditScenario.Name = "BtnEditScenario";
            this.BtnEditScenario.Size = new System.Drawing.Size(130, 60);
            this.BtnEditScenario.TabIndex = 1;
            this.BtnEditScenario.Text = "Edit Scenario";
            this.BtnEditScenario.UseVisualStyleBackColor = true;
            this.BtnEditScenario.Click += new System.EventHandler(this.BtnEditScenarios_Click);
            // 
            // BtnDeleteScenario
            // 
            this.BtnDeleteScenario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnDeleteScenario.Location = new System.Drawing.Point(148, 43);
            this.BtnDeleteScenario.Name = "BtnDeleteScenario";
            this.BtnDeleteScenario.Size = new System.Drawing.Size(130, 60);
            this.BtnDeleteScenario.TabIndex = 0;
            this.BtnDeleteScenario.Text = "Delete Scenario";
            this.BtnDeleteScenario.UseVisualStyleBackColor = true;
            this.BtnDeleteScenario.Click += new System.EventHandler(this.BtnDeleteScenarios_Click);
            // 
            // BtnAddScenario
            // 
            this.BtnAddScenario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnAddScenario.Location = new System.Drawing.Point(12, 43);
            this.BtnAddScenario.Name = "BtnAddScenario";
            this.BtnAddScenario.Size = new System.Drawing.Size(130, 60);
            this.BtnAddScenario.TabIndex = 0;
            this.BtnAddScenario.Text = "Add Scenario";
            this.BtnAddScenario.UseVisualStyleBackColor = true;
            this.BtnAddScenario.Click += new System.EventHandler(this.BtnAddScenarios_Click);
            // 
            // GrpScenariosTable
            // 
            this.GrpScenariosTable.Controls.Add(this.DgvScenariosTable);
            this.GrpScenariosTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpScenariosTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.DgvScenariosTable.AllowUserToDeleteRows = false;
            this.DgvScenariosTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvScenariosTable.ColumnHeadersHeight = 75;
            this.DgvScenariosTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvScenariosTable.Location = new System.Drawing.Point(3, 22);
            this.DgvScenariosTable.Name = "DgvScenariosTable";
            this.DgvScenariosTable.ReadOnly = true;
            this.DgvScenariosTable.RowHeadersWidth = 50;
            this.DgvScenariosTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvScenariosTable.Size = new System.Drawing.Size(1562, 683);
            this.DgvScenariosTable.TabIndex = 0;
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
        private System.Windows.Forms.Button BtnAddScenario;
        private System.Windows.Forms.Button BtnDeleteScenario;
        private System.Windows.Forms.DataGridView DgvScenariosTable;
        private System.Windows.Forms.Button BtnEditScenario;
    }
}