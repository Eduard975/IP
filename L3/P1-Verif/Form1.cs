using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Verif
{
    public partial class Form1 : Form
    {
        Assembly a;
        Type t;
        MethodInfo mi1;
        MethodInfo mi2;
        object o;
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.DecimalPlaces = 0;
            numericUpDown1.Maximum = 15000;
            a = Assembly.Load("P1");
            t = a.GetType("PrimLib.Prim");
            mi1 = t.GetMethod("IsPrime");
            mi2 = t.GetMethod("NumaraPrime");
            o = Activator.CreateInstance(t);
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            int myNum = Convert.ToInt32(numericUpDown1.Value);
            if (Prim.IsPrime(myNum)) 
            {
                label1.Text = "Este Prim";
            } 
            else
            {
                label1.Text = "Nu este Prim";
            }
        }
        */

        private void DescompunereBtn_Click(object sender, EventArgs e)
        {
            List<int> primes = new List<int>();
            int myNum = (int)numericUpDown1.Value;

            if (myNum < 4 || myNum == 5)
            {
                MessageBox.Show("Numar invlaid\nIntroduceti un numar:\nPar > 3\nImpar > 5", "Warning", MessageBoxButtons.OK);
                return;
            }

            object[] arg = new object[1];
            arg[0] = myNum;

            for (int i = 0; i <= myNum; i++)
            {
                arg[0] = i;
                if ((bool)mi1.Invoke(o, arg))
                {
                    primes.Add(i);
                }
            }

            arg[0] = myNum;
            int count = (int)mi2.Invoke(o, arg);
            label2.Text = "Exista " + count.ToString() + " numere prime pana la " + myNum.ToString() + "(inclusiv).";

            if (myNum % 2 == 0)
            {
                for (int i = 0; primes[i] <= Math.Floor(Math.Sqrt(myNum)); i++)
                {
                    int diffNum = myNum - primes[i];

                    if (primes.Contains(diffNum))
                    {
                        textBox1.Text = primes[i].ToString() + " + " + diffNum.ToString();
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; primes[i] <= Math.Floor(Math.Sqrt(myNum)); i++)
                {
                    int diffNum = myNum - primes[i];
                    for (int j = 0; primes[j] <= Math.Floor(Math.Sqrt(diffNum)); j++)
                     {
                        int diffNum2 = diffNum - primes[j];
                        if (primes.Contains(diffNum2))
                        {
                            textBox1.Text = primes[j].ToString() + " + " + primes[i].ToString() + " + " + diffNum2.ToString();
                            break;
                        } 
                    }
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("L3 - IP", "About", MessageBoxButtons.OK);
        }
    }
}
