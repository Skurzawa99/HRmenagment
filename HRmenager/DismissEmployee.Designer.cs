namespace HRmenager
{
    partial class DismissEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameDismiss = new System.Windows.Forms.TextBox();
            this.tbLastNameDismiss = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateDimsiss = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btConfirmDismiss = new System.Windows.Forms.Button();
            this.btCancelDismiss = new System.Windows.Forms.Button();
            this.tbIdEmployeeDismiss = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // tbNameDismiss
            // 
            this.tbNameDismiss.Location = new System.Drawing.Point(124, 57);
            this.tbNameDismiss.Name = "tbNameDismiss";
            this.tbNameDismiss.ReadOnly = true;
            this.tbNameDismiss.Size = new System.Drawing.Size(106, 20);
            this.tbNameDismiss.TabIndex = 1;
            // 
            // tbLastNameDismiss
            // 
            this.tbLastNameDismiss.Location = new System.Drawing.Point(124, 83);
            this.tbLastNameDismiss.Name = "tbLastNameDismiss";
            this.tbLastNameDismiss.ReadOnly = true;
            this.tbLastNameDismiss.Size = new System.Drawing.Size(106, 20);
            this.tbLastNameDismiss.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // dtpDateDimsiss
            // 
            this.dtpDateDimsiss.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpDateDimsiss.CustomFormat = "dd-MM-yyyy";
            this.dtpDateDimsiss.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDimsiss.Location = new System.Drawing.Point(124, 118);
            this.dtpDateDimsiss.Name = "dtpDateDimsiss";
            this.dtpDateDimsiss.Size = new System.Drawing.Size(106, 20);
            this.dtpDateDimsiss.TabIndex = 18;
            this.dtpDateDimsiss.Value = new System.DateTime(2022, 4, 9, 18, 1, 49, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Data zwolnienia:";
            // 
            // btConfirmDismiss
            // 
            this.btConfirmDismiss.Location = new System.Drawing.Point(36, 162);
            this.btConfirmDismiss.Name = "btConfirmDismiss";
            this.btConfirmDismiss.Size = new System.Drawing.Size(75, 23);
            this.btConfirmDismiss.TabIndex = 20;
            this.btConfirmDismiss.Text = "Potwierdź";
            this.btConfirmDismiss.UseVisualStyleBackColor = true;
            this.btConfirmDismiss.Click += new System.EventHandler(this.btConfirmDismiss_Click);
            // 
            // btCancelDismiss
            // 
            this.btCancelDismiss.Location = new System.Drawing.Point(155, 162);
            this.btCancelDismiss.Name = "btCancelDismiss";
            this.btCancelDismiss.Size = new System.Drawing.Size(75, 23);
            this.btCancelDismiss.TabIndex = 21;
            this.btCancelDismiss.Text = "Anuluj";
            this.btCancelDismiss.UseVisualStyleBackColor = true;
            // 
            // tbIdEmployeeDismiss
            // 
            this.tbIdEmployeeDismiss.Location = new System.Drawing.Point(124, 31);
            this.tbIdEmployeeDismiss.Name = "tbIdEmployeeDismiss";
            this.tbIdEmployeeDismiss.ReadOnly = true;
            this.tbIdEmployeeDismiss.Size = new System.Drawing.Size(106, 20);
            this.tbIdEmployeeDismiss.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Id pracownika:";
            // 
            // DismissEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 220);
            this.Controls.Add(this.tbIdEmployeeDismiss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCancelDismiss);
            this.Controls.Add(this.btConfirmDismiss);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateDimsiss);
            this.Controls.Add(this.tbLastNameDismiss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNameDismiss);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(276, 259);
            this.MinimumSize = new System.Drawing.Size(276, 259);
            this.Name = "DismissEmployee";
            this.Text = "Zwolnianie pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameDismiss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateDimsiss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btConfirmDismiss;
        private System.Windows.Forms.Button btCancelDismiss;
        private System.Windows.Forms.TextBox tbIdEmployeeDismiss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLastNameDismiss;
    }
}