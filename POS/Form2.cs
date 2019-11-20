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

        string operand = "0"; // 피연산자1 저장
        string operand2 = "0"; // 피연산자2 저장
        string operand3 = "0"; // 피연산자2 저장
        string operand4 = "0"; // 피연산자2 저장
        string operand5 = "0"; // 피연산자2 저장
        string operand6 = "0"; // 피연산자2 저장
        string operand7 = "0"; // 피연산자2 저장
        string operand8 = "0"; // 피연산자2 저장
        string operand9 = "0"; // 피연산자2 저장
        string operand10 = "0"; // 피연산자2 저장
        string operand11 = "0"; // 피연산자2 저장
        string operand12 = "0"; // 피연산자2 저장
        string operand13 = "0"; // 피연산자2 저장
        string operand14 = "0"; // 피연산자2 저장
        string operand15 = "0"; // 피연산자2 저장

        string sum0;
        string money;
        bool meun_check = true;
        int result;
        int clear;
        public Form2()
        {
            InitializeComponent();
        }
        public void total()
        {
            int num_operand = System.Convert.ToInt32(operand);// 변환
            int num_operand2 = System.Convert.ToInt32(operand2);//변환
            int num_operand3 = System.Convert.ToInt32(operand3);//변환
            int num_operand4 = System.Convert.ToInt32(operand4);//변환
            int num_operand5 = System.Convert.ToInt32(operand5);//변환
            int num_operand6 = System.Convert.ToInt32(operand6);//변환
            int num_operand7 = System.Convert.ToInt32(operand7);//변환
            int num_operand8 = System.Convert.ToInt32(operand8);//변환
            int num_operand9 = System.Convert.ToInt32(operand9);//변환
            int num_operand10 = System.Convert.ToInt32(operand10);//변환
            int num_operand11 = System.Convert.ToInt32(operand11);//변환
            int num_operand12 = System.Convert.ToInt32(operand12);//변환
            int num_operand13 = System.Convert.ToInt32(operand13);//변환
            int num_operand14 = System.Convert.ToInt32(operand14);//변환
            int num_operand15 = System.Convert.ToInt32(operand15);//변환
            result = num_operand + num_operand2 + num_operand3 + num_operand4 + num_operand5 + num_operand6 + num_operand7 +
               num_operand8 + num_operand9 + num_operand10 + num_operand11 + num_operand12 + num_operand13 + num_operand14 + num_operand15;
            string result2 = System.Convert.ToString(result);//변환
            textBox1.Text = result2;
        }
        private void button1_Click(object sender, EventArgs e)//확인
        {
            if (textBox2.Text != "")
            {
                sum0 = textBox2.Text;
                money = textBox1.Text;
                int sum = System.Convert.ToInt32(sum0);
                int M = System.Convert.ToInt32(money);
                clear = sum - M;
                string clear2 = System.Convert.ToString(clear);//변환
                textBox3.Text = clear2;
            }
            else
            {
                MessageBox.Show("받은 금액을 입력해주세요");
            }
        }
        private void button18_Click(object sender, EventArgs e)// 현금
        {

            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("결제 완료");
            operand = "";
            operand2 = "";
            operand4 = "";
            operand5 = "";
            operand6 = "";
            operand7 = "";
            operand8 = "";
            operand9 = "";
            operand10 = "";
            operand11 = "";
            operand12 = "";
            operand13 = "";
            operand14 = "";
            operand15 = "";


        }
        private void AHH(object sender, EventArgs e)//아메리카노H
        {
            listBox1.Items.Add(label1.Text);
            listBox1.Items.Add(AH.Text);
            if (meun_check == true)
            {
                operand = "3500";
                textBox1.Text = AH.Text;
                //meun_check = false;
                total();

            }
            else
            {
                operand = "0";
                textBox1.Text = AH.Text;
                total();
            }

        }



        private void CH(object sender, EventArgs e)//카페라떼H
        {
            listBox1.Items.Add(CFF.Text);
            listBox1.Items.Add(CF.Text);
            if (meun_check == true)
            {
                operand2 += "4500";
                textBox1.Text = AH.Text;
                total();

            }
            else
            {
                operand2 += "0";
                textBox1.Text = AH.Text;
                total();
            }

        }

        private void AC(object sender, EventArgs e)//아메리카노C
        {
            listBox1.Items.Add(ACC.Text);
            listBox1.Items.Add(ACCC.Text);
            if (meun_check == true)
            {
                operand3 += "3500";
                textBox1.Text = AH.Text;
                total();

            }
            else
            {
                operand3 += "0";
                textBox1.Text = AH.Text;
                total();
            }

        }

        private void CC(object sender, EventArgs e)//카페라떼C
        {
            listBox1.Items.Add(CCC.Text);
            listBox1.Items.Add(CCCC.Text);
            if (meun_check == true)
            {
                operand4 += "4500";
                textBox1.Text = AH.Text;
                total();
            }
            else
            {
                operand4 += "0";
                textBox1.Text = AH.Text;
                total();
            }
        }

        private void NHHH(object sender, EventArgs e)//녹차라떼H
        {
            listBox1.Items.Add(NHH.Text);
            listBox1.Items.Add(NH.Text);
            if (meun_check == true)
            {
                operand5 += "4500";
                textBox1.Text = AH.Text;
                total();
            }
            else
            {
                operand5 += "0";
                textBox1.Text = AH.Text;
                total();
            }
        }

        private void NCCC(object sender, EventArgs e)//녹차라떼C
        {
            listBox1.Items.Add(NCC.Text);
            listBox1.Items.Add(NC.Text);
            if (meun_check == true)
            {
                operand6 += "4500";
                textBox1.Text = AH.Text;
                total();
            }
            else
            {
                operand6 += "0";
                textBox1.Text = AH.Text;
                total();
            }
        }

        private void SHHH(object sender, EventArgs e)//고구마라떼H
        {
            listBox1.Items.Add(SHH.Text);
            listBox1.Items.Add(SH.Text);
            if (meun_check == true)
            {
                operand7 += "4500";
                textBox1.Text = AH.Text;
                total();
            }
            else
            {
                operand7 += "0";
                textBox1.Text = AH.Text;
                total();
            }
        }

        private void SCCC(object sender, EventArgs e)//고구마라떼C
        {
            listBox1.Items.Add(SCC.Text);
            listBox1.Items.Add(SC.Text);
            if (meun_check == true)
            {
                operand8 += "4500";
                textBox1.Text = AH.Text;
                total();
            }
            else
            {
                operand8 += "0";
                textBox1.Text = AH.Text;
                total();
            }
        }

        private void NPPP(object sender, EventArgs e)//녹차프라치노
        {
            listBox1.Items.Add(NPP.Text);
            listBox1.Items.Add(NP.Text);
            if (meun_check == true)
            {
                operand9 += "4500";
                textBox1.Text = AH.Text;
                total();
            }
            else
            {
                operand9 += "0";
                textBox1.Text = AH.Text;
                total();
            }
        }

        private void CPPP(object sender, EventArgs e)//초코프라치노
        {
            listBox1.Items.Add(CPP.Text);
            listBox1.Items.Add(CP.Text);
            if (meun_check == true)
            {
                operand9 += "4500";
                textBox1.Text = AH.Text;
                total();
            }
            else
            {
                operand9 += "0";
                textBox1.Text = AH.Text;
                total();
            }
        }

        private void YPPP(object sender, EventArgs e)//요거트프라치노
        {
            listBox1.Items.Add(YPP.Text);
            listBox1.Items.Add(YP.Text);
            if (meun_check == true)
            {
                operand11 += "4500";
                textBox1.Text = AH.Text;
                total();
            }
            else
            {
                operand11 += "0";
                textBox1.Text = AH.Text;
                total();
            }
        }

        private void MCPPP(object sender, EventArgs e)//민트초코프라치노
        {
            listBox1.Items.Add(MCPP.Text);
            listBox1.Items.Add(MCP.Text);
            if (meun_check == true)
            {
                operand12 += "4500";
                textBox1.Text = AH.Text;
                total();
            }
            else
            {
                operand12 += "0";
                textBox1.Text = AH.Text;
                total();
            }
        }

        private void ATTT(object sender, EventArgs e)//얼그레이
        {
            listBox1.Items.Add(ATT.Text);
            listBox1.Items.Add(AT.Text);
            if (meun_check == true)
            {
                operand13 += "4500";
                textBox1.Text = AH.Text;
                total();
            }
            else
            {
                operand13 += "0";
                textBox1.Text = AH.Text;
                total();
            }
        }

        private void PTTT(object sender, EventArgs e)//페퍼민트
        {
            listBox1.Items.Add(PTT.Text);
            listBox1.Items.Add(PT.Text);
            if (meun_check == true)
            {
                operand14 += "4500";
                textBox1.Text = AH.Text;
                total();
            }
            else
            {
                operand14 += "0";
                textBox1.Text = AH.Text;
                total();
            }
        }

        private void RTTT(object sender, EventArgs e)//레몬
        {
            listBox1.Items.Add(RTT.Text);
            listBox1.Items.Add(RT.Text);
            if (meun_check == true)
            {
                operand15 += "4500";
                textBox1.Text = AH.Text;
                total();
            }
            else
            {
                operand15 += "0";
                textBox1.Text = AH.Text;
                total();
            }
        }

        private void CMPPP(object sender, EventArgs e)//민트초코프라치노
        {
            listBox1.Items.Add(CMPP.Text);
            listBox1.Items.Add(CMP.Text);
            if (meun_check == true)
            {
                operand15 += "4500";
                textBox1.Text = AH.Text;
                total();
            }
            else
            {
                operand15 += "0";
                textBox1.Text = AH.Text;
                total();
            }
        }

        private void button19_Click(object sender, EventArgs e)//닫기
        {
            Close();
        }


    }
}
