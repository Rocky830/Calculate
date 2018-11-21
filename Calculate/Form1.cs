using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Initial();
        }

        public void Initial()
        {
            cmbAddAndSub.SelectedIndex = 0;
            txbNum1.Text = "0";
            txbNum2.Text = "0";
            txbNum3.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkType1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkType1.Checked)
            {
                cmbAddAndSub.Enabled = true;
                chkType2.Checked = false;
                rdoSymbolMul.Enabled = false;
                rdoSymbolDiv.Enabled = false;
            }
            else
            {
                cmbAddAndSub.Enabled = false;
                chkType2.Checked = true;
                rdoSymbolMul.Enabled = true;
                rdoSymbolDiv.Enabled = true;
            }
        }

        private void chkType2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkType2.Checked)
            {
                cmbAddAndSub.Enabled = false;
                chkType1.Checked = false;
                rdoSymbolMul.Enabled = true;
                rdoSymbolDiv.Enabled = true;
            }
            else
            {
                cmbAddAndSub.Enabled = true;
                chkType1.Checked = true;
                rdoSymbolMul.Enabled = false;
                rdoSymbolDiv.Enabled = false;
            }
        }

        private void chkNum1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNum1.Checked)
            {
                txbNum1.Enabled = true;
            }
            else
            {
                txbNum1.Enabled = false;
            }
        }

        private void chkNum2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNum2.Checked)
            {
                txbNum2.Enabled = true;
            }
            else
            {
                txbNum2.Enabled = false;
            }
        }

        private void chkNum3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNum3.Checked)
            {
                txbNum3.Enabled = true;
            }
            else
            {
                txbNum3.Enabled = false;
            }
        }

        private void butCompute_Click(object sender, EventArgs e)
        {
            try
            {
                method = SelectMethod();
                int i = SelectNumCount();
                SelectNumConvert();
                if (i > 1)
                {
                    ComputeMethod();
                }
                else
                {
                    result = 0;
                    MessageBox.Show("选择参与运算数据少于2个", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                txbResult.Text = result.ToString();
            }
        }

        int method = 0;
        Int32 num1 = 0, num2 = 0, num3 = 0, Temp = 0, result = 0;
        public int SelectMethod()
        {
            if (chkType1.Checked)
            {
                if (cmbAddAndSub.SelectedItem.ToString () == "+")
                {
                    method = 1;
                }
                if (cmbAddAndSub.SelectedItem.ToString() == "-")
                {
                    method = 2;
                }
            }
            if (chkType2.Checked)
            {
                if (rdoSymbolMul.Checked)
                {
                    method = 3;
                }
                if (rdoSymbolDiv.Checked)
                {
                    method = 4;
                }
            }
            return method;
        }

        public void SelectNumConvert()
        {
            if (chkNum1.Checked)
            {
                num1 = Convert.ToInt32(txbNum1.Text);
            }
            if (chkNum2.Checked)
            {
                num2 = Convert.ToInt32(txbNum2.Text);
            }
            if (chkNum3.Checked)
            {
                num3 = Convert.ToInt32(txbNum3.Text);
            }
        }

        public int SelectNumCount()
        {
            int i = 0;
            if (chkNum1.Checked)
            {
                i++;
            }
            if (chkNum2.Checked)
            {
                i++;
            }
            if (chkNum3.Checked)
            {
                i++;
            }
            return i;
        }

        public void ComputeMethod()
        {
            Temp = 0;
            result = 0;
            switch (method)
            {
                case 1:
                    if (chkNum1.Checked)
                        AddMethod(num1);
                    if (chkNum1.Checked)
                        AddMethod(num2);
                    if (chkNum1.Checked)
                        AddMethod(num3);
                    break;
                case 2:
                    if (chkNum1.Checked)
                        SubMethod(num1);
                    if (chkNum2.Checked)
                        SubMethod(num2);
                    if (chkNum3.Checked)
                        SubMethod(num3);
                    break;
                case 3:
                    if (chkNum1.Checked)
                        MulMethod(num1);
                    if (chkNum2.Checked)
                        MulMethod(num2);
                    if (chkNum3.Checked)
                        MulMethod(num3);
                    break;
                case 4:
                    if (chkNum1.Checked)
                        DivMethod(num1);
                    if (chkNum2.Checked)
                        DivMethod(num2);
                    if (chkNum3.Checked)
                        DivMethod(num3);
                    break;

                default:
                    Temp = 0;
                    result = 0;
                    break;
            }
        }

        public void AddMethod(Int32 i)
        {
            if (Temp == 0)
                Temp = i;
            else
                Temp += i;
            result = Temp;
        }

        public void SubMethod(Int32 i)
        {
            if (Temp == 0)
                Temp = i;
            else
                Temp -= i;
            result = Temp;
        }

        public void MulMethod(Int32 i)
        {
            if (Temp == 0)
                Temp = i;
            else
                Temp *= i;
            result = Temp;
        }

        public void DivMethod(Int32 i)
        {
            if (Temp == 0)
                Temp = i;
            else
                Temp /= i;
            result = Temp;
        }

 
    }
}
