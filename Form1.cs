using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operations = "";
        bool enter_value = false;
        float iCelsius, iFahrenheit, iKevin;
        char iOperation;
        SqlConnection cnstring = new SqlConnection("Data Source = HNASEEM; initial catalog = myDB; user ID = sa; password = sgc");
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnstring.Open();



            cnstring.Close();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 287;
            textBox1.Width = 220;
        }

        private void scienteficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 530;
            textBox1.Width = 460;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 287;
            textBox1.Width = 220;
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 906;
            textBox1.Width = 460;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {

                if (!textBox1.Text.Contains("."))

                    textBox1.Text = textBox1.Text + num.Text;
            }

            else
                    textBox1.Text = textBox1.Text + num.Text;
            
            }

        private void buttonCE_Click(object sender, EventArgs e)
        {
                textBox1.Text = "0";
                lblShowOp.Text = ""; 
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
                 textBox1.Text = "0";
                 lblShowOp.Text = ""; 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {

                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length -1, 1);
            
            
            }

            if (textBox1.Text == "")
            {

                textBox1.Text = "0";


            }
        }

        private void Arithmetic_Operators(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operations = num.Text;
            results = double.Parse(textBox1.Text);
            textBox1.Text = "";
            lblShowOp.Text = Convert.ToString(results) + " " + operations;  

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

            lblShowOp.Text = "";
            switch (operations)
            {

                case "+":

                    textBox1.Text = (results + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":

                    textBox1.Text = (results - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":

                    textBox1.Text = (results * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":

                    textBox1.Text = (results / double.Parse(textBox1.Text)).ToString();
                    break;
                case "Mod":

                    textBox1.Text = (results % double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":

                    double i = Double.Parse(textBox1.Text);
                    double q;
                    q = (results);

                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;


            }
        }

            


        private void buttonPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592653589793";    
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            lblShowOp.Text = Convert.ToString("log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = Convert.ToString(ilog);

        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double iSqrt = Double.Parse(textBox1.Text);
            lblShowOp.Text = Convert.ToString("Square Root" + " (" + (textBox1.Text) + ")");
            iSqrt = Math.Sqrt(iSqrt);
            textBox1.Text = Convert.ToString(iSqrt);
        }

        private void buttonSinh_Click(object sender, EventArgs e)
        {
            double iSinh = Double.Parse(textBox1.Text);
            lblShowOp.Text = Convert.ToString("Sinh" + " (" + (textBox1.Text) + ")");
            iSinh = Math.Sinh(iSinh);
            textBox1.Text = Convert.ToString(iSinh);

        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            double iSin = Double.Parse(textBox1.Text);
            lblShowOp.Text = Convert.ToString("Sin" + " (" + (textBox1.Text) + ")");
            iSin = Math.Sin(iSin);
            textBox1.Text = Convert.ToString(iSin);
        }

        private void buttonCosh_Click(object sender, EventArgs e)
        {
            double iCosh = Double.Parse(textBox1.Text);
            lblShowOp.Text = Convert.ToString("Cosh" + " (" + (textBox1.Text) + ")");
            iCosh = Math.Cosh(iCosh);
            textBox1.Text = Convert.ToString(iCosh);
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            double iCos = Double.Parse(textBox1.Text);
            lblShowOp.Text = Convert.ToString("Cos" + " (" + (textBox1.Text) + ")");
            iCos = Math.Cos(iCos);
            textBox1.Text = Convert.ToString(iCos);
        }

        private void buttonTanh_Click(object sender, EventArgs e)
        {
            double iTanh = Double.Parse(textBox1.Text);
            lblShowOp.Text = Convert.ToString("Tanh" + " (" + (textBox1.Text) + ")");
            iTanh = Math.Cosh(iTanh);
            textBox1.Text = Convert.ToString(iTanh);
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            double iTan = Double.Parse(textBox1.Text);
            lblShowOp.Text = Convert.ToString("Tan" + " (" + (textBox1.Text) + ")");
            iTan = Math.Tan(iTan);
            textBox1.Text = Convert.ToString(iTan);
        }

        private void buttonBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 2);

        }

        private void buttonHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 16);
        }

        private void buttonOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 8);
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a);
        }

        private void buttonSq_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            lblShowOp.Text = Convert.ToString((textBox1.Text) + " ^2");
            textBox1.Text = Convert.ToString(a);
        }

        private void buttonCube_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            lblShowOp.Text = Convert.ToString((textBox1.Text) + " ^3");
            textBox1.Text = Convert.ToString(a);

        }

        private void buttonInverse_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text));
            lblShowOp.Text = Convert.ToString("1/ " + (textBox1.Text));
            textBox1.Text = Convert.ToString(a); 
            
        }

        private void buttonLnx_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            lblShowOp.Text = Convert.ToString("ln" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log(ilog);
            textBox1.Text = Convert.ToString(ilog); 
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = Convert.ToString(a);
        }

        private void rbCelToFaren_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void rbFarenToCel_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void rbKevin_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case 'C':

                    iCelsius = float.Parse(TempInput.Text);
                    TempOutput.Text = ((((9 * iCelsius) / 5) + 32)).ToString();

                    break;
                
                case 'F':

                    iFahrenheit = float.Parse(TempInput.Text);
                    TempOutput.Text = ((((iFahrenheit - 32) * 5) / 9)).ToString();

                    break;
                
                case 'K':

                    iKevin = float.Parse(TempInput.Text);
                    TempOutput.Text = ((((9 * iKevin) / 5) + 32)).ToString();

                    break;

            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            TempInput.Clear();
            TempOutput.Text = "";
            rbCelToFaren.Checked = false;
            rbFarenToCel.Checked = false;
            rbKevin.Checked = false;
        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
             a = -Math.Abs(a);
            textBox1.Text = Convert.ToString(a);

        }
        }

    }


