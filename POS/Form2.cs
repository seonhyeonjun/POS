using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form2 : Form
    {
        string operand; // 피연산자1 저장

        string operand2; // 피연산자2 저장
        string sum0;
        string money;
        bool operand_check = false;
        int result;
        int clear;

        public Form2()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num_operand = System.Convert.ToInt16(operand);// 변환

            int num_operand2 = System.Convert.ToInt16(operand2);
            result = num_operand + num_operand2;
            string result2 = System.Convert.ToString(result);//변환
            textBox1.Text = result2;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = sum0;
            textBox1.Text = money;
            int sum = System.Convert.ToInt16(sum0);
            sum = 0;
            int M = System.Convert.ToInt16(money);
            M = 0;
            clear = sum - M;
            string clear2 = System.Convert.ToString(clear);//변환
            textBox3.Text = clear2;
        }

        private void AHH(object sender, EventArgs e)
        {
            listBox1.Items.Add(label1.Text);
            listBox1.Items.Add(AH.Text);
            if (operand_check == false)
            {
                operand += "3500";
                textBox1.Text = AH.Text;

            }


        }



        private void CH(object sender, EventArgs e)
        {
            listBox1.Items.Add(CFF.Text);
            listBox1.Items.Add(CF.Text);
            if (operand_check == false)
            {
                operand2 += "4500";
                textBox1.Text = AH.Text;

            }

        }

        private void AC(object sender, EventArgs e)
        {
            listBox1.Items.Add(ACC.Text);
            listBox1.Items.Add(ACCC.Text);

        }

        private void CC(object sender, EventArgs e)
        {
            listBox1.Items.Add(CCC.Text);
            listBox1.Items.Add(CCCC.Text);
        }

        private void NHHH(object sender, EventArgs e)
        {
            listBox1.Items.Add(NHH.Text);
            listBox1.Items.Add(NH.Text);
        }

        private void NCCC(object sender, EventArgs e)
        {
            listBox1.Items.Add(NCC.Text);
            listBox1.Items.Add(NC.Text);
        }

        private void SHHH(object sender, EventArgs e)
        {
            listBox1.Items.Add(SHH.Text);
            listBox1.Items.Add(SH.Text);
        }

        private void SCCC(object sender, EventArgs e)
        {
            listBox1.Items.Add(SCC.Text);
            listBox1.Items.Add(SC.Text);
        }

        private void NPPP(object sender, EventArgs e)
        {
            listBox1.Items.Add(NPP.Text);
            listBox1.Items.Add(NP.Text);
        }

        private void CPPP(object sender, EventArgs e)
        {
            listBox1.Items.Add(CPP.Text);
            listBox1.Items.Add(CP.Text);
        }

        private void YPPP(object sender, EventArgs e)
        {
            listBox1.Items.Add(YPP.Text);
            listBox1.Items.Add(YP.Text);
        }

        private void MCPPP(object sender, EventArgs e)
        {
            listBox1.Items.Add(MCPP.Text);
            listBox1.Items.Add(MCP.Text);
        }

        private void ATTT(object sender, EventArgs e)
        {
            listBox1.Items.Add(ATT.Text);
            listBox1.Items.Add(AT.Text);
        }

        private void PTTT(object sender, EventArgs e)
        {
            listBox1.Items.Add(PTT.Text);
            listBox1.Items.Add(PT.Text);
        }

        private void RTTT(object sender, EventArgs e)
        {
            listBox1.Items.Add(RTT.Text);
            listBox1.Items.Add(RT.Text);
        }

        private void CMPPP(object sender, EventArgs e)
        {
            listBox1.Items.Add(CMPP.Text);
            listBox1.Items.Add(CMP.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
