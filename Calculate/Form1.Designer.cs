namespace Calculate
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbAddAndSub = new System.Windows.Forms.ComboBox();
            this.rdoSymbolMul = new System.Windows.Forms.RadioButton();
            this.rdoSymbolDiv = new System.Windows.Forms.RadioButton();
            this.chkNum1 = new System.Windows.Forms.CheckBox();
            this.chkNum2 = new System.Windows.Forms.CheckBox();
            this.chkNum3 = new System.Windows.Forms.CheckBox();
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.txbNum3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkType1 = new System.Windows.Forms.CheckBox();
            this.chkType2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.butCompute = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // rdoSymbolDiv
            // 
            this.rdoSymbolDiv.AutoSize = true;
            this.rdoSymbolDiv.Enabled = false;
            this.rdoSymbolDiv.Location = new System.Drawing.Point(159, 63);
            this.rdoSymbolDiv.Name = "rdoSymbolDiv";
            this.rdoSymbolDiv.Size = new System.Drawing.Size(29, 16);
            this.rdoSymbolDiv.TabIndex = 4;
            this.rdoSymbolDiv.Text = "/";
            this.rdoSymbolDiv.UseVisualStyleBackColor = true;
            // 
            // chkNum1
            // 
            this.chkNum1.AutoSize = true;
            this.chkNum1.Location = new System.Drawing.Point(20, 32);
            this.chkNum1.Name = "chkNum1";
            this.chkNum1.Size = new System.Drawing.Size(48, 16);
            this.chkNum1.TabIndex = 5;
            this.chkNum1.Text = "Num1";
            this.chkNum1.UseVisualStyleBackColor = true;
            this.chkNum1.CheckedChanged += new System.EventHandler(this.chkNum1_CheckedChanged);
            // 
            // chkNum2
            // 
            this.chkNum2.AutoSize = true;
            this.chkNum2.Location = new System.Drawing.Point(20, 68);
            this.chkNum2.Name = "chkNum2";
            this.chkNum2.Size = new System.Drawing.Size(48, 16);
            this.chkNum2.TabIndex = 6;
            this.chkNum2.Text = "Num2";
            this.chkNum2.UseVisualStyleBackColor = true;
            this.chkNum2.CheckedChanged += new System.EventHandler(this.chkNum2_CheckedChanged);
            // 
            // chkNum3
            // 
            this.chkNum3.AutoSize = true;
            this.chkNum3.Location = new System.Drawing.Point(20, 104);
            this.chkNum3.Name = "chkNum3";
            this.chkNum3.Size = new System.Drawing.Size(48, 16);
            this.chkNum3.TabIndex = 7;
            this.chkNum3.Text = "Num3";
            this.chkNum3.UseVisualStyleBackColor = true;
            this.chkNum3.CheckedChanged += new System.EventHandler(this.chkNum3_CheckedChanged);
            // 
            // txbNum1
            // 
            this.txbNum1.Enabled = false;
            this.txbNum1.Location = new System.Drawing.Point(113, 30);
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.Size = new System.Drawing.Size(100, 21);
            this.txbNum1.TabIndex = 8;
            // 
            // txbNum2
            // 
            this.txbNum2.Enabled = false;
            this.txbNum2.Location = new System.Drawing.Point(113, 66);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(100, 21);
            this.txbNum2.TabIndex = 9;
            // 
            // txbNum3
            // 
            this.txbNum3.Enabled = false;
            this.txbNum3.Location = new System.Drawing.Point(113, 102);
            this.txbNum3.Name = "txbNum3";
            this.txbNum3.Size = new System.Drawing.Size(100, 21);
            this.txbNum3.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkType1);
            this.groupBox1.Controls.Add(this.rdoSymbolDiv);
            this.groupBox1.Controls.Add(this.chkType2);
            this.groupBox1.Controls.Add(this.rdoSymbolMul);
            this.groupBox1.Controls.Add(this.cmbAddAndSub);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 93);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Select Calculation Method";
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
            this.chkType1.CheckedChanged += new System.EventHandler(this.chkType1_CheckedChanged);
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
            this.chkType2.CheckedChanged += new System.EventHandler(this.chkType2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txbResult);
            this.groupBox2.Controls.Add(this.txbNum3);
            this.groupBox2.Controls.Add(this.txbNum2);
            this.groupBox2.Controls.Add(this.txbNum1);
            this.groupBox2.Controls.Add(this.chkNum3);
            this.groupBox2.Controls.Add(this.chkNum2);
            this.groupBox2.Controls.Add(this.chkNum1);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 188);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Calculation Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Result";
            // 
            // txbResult
            // 
            this.txbResult.Enabled = false;
            this.txbResult.Location = new System.Drawing.Point(113, 139);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(100, 21);
            this.txbResult.TabIndex = 11;
            // 
            // butCompute
            // 
            this.butCompute.Location = new System.Drawing.Point(262, 211);
            this.butCompute.Name = "butCompute";
            this.butCompute.Size = new System.Drawing.Size(75, 23);
            this.butCompute.TabIndex = 13;
            this.butCompute.Text = "Compute";
            this.butCompute.UseVisualStyleBackColor = true;
            this.butCompute.Click += new System.EventHandler(this.butCompute_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 311);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butCompute);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAddAndSub;
        private System.Windows.Forms.RadioButton rdoSymbolMul;
        private System.Windows.Forms.RadioButton rdoSymbolDiv;
        private System.Windows.Forms.CheckBox chkNum1;
        private System.Windows.Forms.CheckBox chkNum2;
        private System.Windows.Forms.CheckBox chkNum3;
        private System.Windows.Forms.TextBox txbNum1;
        private System.Windows.Forms.TextBox txbNum2;
        private System.Windows.Forms.TextBox txbNum3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butCompute;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkType1;
        private System.Windows.Forms.CheckBox chkType2;
    }
}

