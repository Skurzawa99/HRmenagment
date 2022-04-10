namespace HRmenager
{
    partial class Main
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
            this.btDismiss = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btEdit = new System.Windows.Forms.Button();
            this.btToEmployee = new System.Windows.Forms.Button();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btDismiss
            // 
            this.btDismiss.Location = new System.Drawing.Point(195, 12);
            this.btDismiss.Name = "btDismiss";
            this.btDismiss.Size = new System.Drawing.Size(75, 23);
            this.btDismiss.TabIndex = 1;
            this.btDismiss.Text = "Zwolnij";
            this.btDismiss.UseVisualStyleBackColor = true;
            this.btDismiss.Click += new System.EventHandler(this.btDismiss_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(13, 42);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(776, 396);
            this.dgvEmployee.TabIndex = 4;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(104, 12);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 3;
            this.btEdit.Text = "Edytuj";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btToEmployee
            // 
            this.btToEmployee.Location = new System.Drawing.Point(13, 12);
            this.btToEmployee.Name = "btToEmployee";
            this.btToEmployee.Size = new System.Drawing.Size(75, 23);
            this.btToEmployee.TabIndex = 4;
            this.btToEmployee.Text = "Zatrudnij";
            this.btToEmployee.UseVisualStyleBackColor = true;
            this.btToEmployee.Click += new System.EventHandler(this.btToEmployee_Click);
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(292, 13);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbGroup.TabIndex = 5;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.btToEmployee);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btDismiss);
            this.Name = "Main";
            this.Text = "HR-menagment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btDismiss;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btToEmployee;
        private System.Windows.Forms.ComboBox cmbGroup;
    }
}

