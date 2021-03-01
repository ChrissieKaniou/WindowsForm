using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        RectangleArea Rectangle;
        TriangleArea Triangle;
        CircleArea Circle;
        CalcQuadratic Quadratic;
        CalcPolynomial Polynomial;
        public Form1()
        {
            InitializeComponent();
            Rectangle = new RectangleArea();
            Triangle = new TriangleArea();
            Circle = new CircleArea();
            Quadratic = new CalcQuadratic();
            Polynomial = new CalcPolynomial();
        }

        private void btmRecArea_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtRecHeight.Text);
            int b = Convert.ToInt32(txtRecWidth.Text);

            lblRecArea.Text = Rectangle.RectArea(a, b).ToString("0.##");
        }

        private void btmTriArea_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtTriA.Text);
            int b = Convert.ToInt32(txtTriB.Text);
            int c = Convert.ToInt32(txtTriC.Text);

            lblTriArea.Text = Triangle.TriArea(a, b, c).ToString("0.##");
        }

        private void btmCirArea_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(txtCirR.Text);

            lblCirArea.Text = Circle.CirArea(r).ToString("0.##");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtQuaA.Text);
            int b = Convert.ToInt32(txtQuaB.Text);
            int c = Convert.ToInt32(txtQuaC.Text);

            double[] answers = Quadratic.CalcX(a, b, c);

            if (answers.Length > 2)
            {
                lblQuaX1.Text = "";
                lblQuaX2.Text = "";
                lblQuaOr.Text = "";
                lblQuaEmpty.Text = "No Solution";
            }
            else if(answers[0] == answers[1])
            {
                lblQuaX1.Text = answers[0].ToString("0.##");
                lblQuaX2.Text = "";
                lblQuaOr.Text = "";
                lblQuaEmpty.Text = "";
            }
            else
            {
                lblQuaX1.Text = answers[0].ToString("0.##");
                lblQuaX2.Text = answers[1].ToString("0.##");
                lblQuaOr.Text = "or";
                lblQuaEmpty.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i <= 19; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int txtno = Int32.Parse(comboBox1.Text);
            int pointX = 21;
            int pointY = 66;
            //tabPage3.Controls.Clear();
            for (int i = 0; i <= txtno; i++)
            {
                TextBox input = new TextBox();
                input.Name = "TextBox" + i.ToString();
                input.Text = i.ToString();
                input.Location = new Point(pointX, pointY);
                tabPage3.Controls.Add(input);
                tabPage3.Show();
                pointY += 21;
                if (i == 7)
                {
                    pointX = 134;
                    pointY = 37;
                }
                if (i == 16)
                {
                    pointX = 247;
                    pointY = 37;
                }
            }
        }

        private void btmPolX_Click(object sender, EventArgs e)
        {
            int txtno = Int32.Parse(comboBox1.Text);
            double[] inputArr = new double[txtno + 1];
            for(int i = 0; i <= txtno; i++)
            {
                inputArr[i] = double.Parse(((TextBox)tabPage3.Controls["TextBox" + i.ToString()]).Text);
            }
            String[] answers = Polynomial.solve(inputArr);
            if (answers.Length == 1)
            {
                lblPolX.Text = answers[0];
            }
            else if (answers.Length == 2)
            {
                lblPolX.Text = answers[0] + " or " + answers[1];
            }
            else
            {
                lblPolX.Text = "No Solution";
            }
        }
    }
}