namespace Calculate
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAddAndSub = new System.Windows.Forms.ComboBox();
            this.chkType1 = new System.Windows.Forms.CheckBox();
            this.chkType2 = new System.Windows.Forms.CheckBox();
            this.rdoSymbolMul = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkType1);
            this.groupBox1.Controls.Add(this.chkType2);
            this.groupBox1.Controls.Add(this.rdoSymbolMul);
            this.groupBox1.Controls.Add(this.cmbAddAndSub);
            this.groupBox1.Location = new System.Drawing.Point(74, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 93);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Select Calculation Method";
            // 
            // cmbAddAndSub
            // 
            this.cmbAddAndSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddAndSub.FormattingEnabled = true;
            this.cmbAddAndSub.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbAddAndSub.Location = new System.Drawing.Point(20, 42);
            this.cmbAddAndSub.Name = "cmbAddAndSub";
            this.cmbAddAndSub.Size = new System.Drawing.Size(100, 20);
            this.cmbAddAndSub.TabIndex = 1;
            // 
            // chkType1
            // 
            this.chkType1.AutoSize = true;
            this.chkType1.Checked = true;
            this.chkType1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkType1.Location = new System.Drawing.Point(20, 19);
            this.chkType1.Name = "chkType1";
            this.chkType1.Size = new System.Drawing.Size(54, 16);
            this.chkType1.TabIndex = 16;
            this.chkType1.Text = "Type1";
            this.chkType1.UseVisualStyleBackColor = true;
            // 
            // chkType2
            // 
            this.chkType2.AutoSize = true;
            this.chkType2.Location = new System.Drawing.Point(159, 19);
            this.chkType2.Name = "chkType2";
            this.chkType2.Size = new System.Drawing.Size(54, 16);
            this.chkType2.TabIndex = 15;
            this.chkType2.Text = "Type2";
            this.chkType2.UseVisualStyleBackColor = true;
            // 
            // rdoSymbolMul
            // 
            this.rdoSymbolMul.AutoSize = true;
            this.rdoSymbolMul.Checked = true;
            this.rdoSymbolMul.Enabled = false;
            this.rdoSymbolMul.Location = new System.Drawing.Point(159, 41);
            this.rdoSymbolMul.Name = "rdoSymbolMul";
            this.rdoSymbolMul.Size = new System.Drawing.Size(29, 16);
            this.rdoSymbolMul.TabIndex = 3;
            this.rdoSymbolMul.TabStop = true;
            this.rdoSymbolMul.Text = "*";
            this.rdoSymbolMul.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkType1;
        private System.Windows.Forms.CheckBox chkType2;
        private System.Windows.Forms.RadioButton rdoSymbolMul;
        private System.Windows.Forms.ComboBox cmbAddAndSub;
    }
}