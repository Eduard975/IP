using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace L1
{
    public partial class Form1 : Form
    {
        private TextBox X2ValBox;
        private TextBox X1ValBox;
        private TextBox X0ValBox;
        private TextBox TrigValBox;
        private TextBox SolutieBox;
        private ComboBox TrigEcuationComboBox;
        private Button CalcButton;
        private Button DespreButton;
        private Button IesireButton;
        private RadioButton PolinomButton;
        private RadioButton TrigonometricButton;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;

        public Form1()
        {
            InitializeComponent();
            this.TrigEcuationComboBox.SelectedIndex = 0;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.X2ValBox = new System.Windows.Forms.TextBox();
            this.X1ValBox = new System.Windows.Forms.TextBox();
            this.X0ValBox = new System.Windows.Forms.TextBox();
            this.TrigEcuationComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.DespreButton = new System.Windows.Forms.Button();
            this.IesireButton = new System.Windows.Forms.Button();
            this.SolutieBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PolinomButton = new System.Windows.Forms.RadioButton();
            this.TrigonometricButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TrigValBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "x^2 + ";
            // 
            // X2ValBox
            // 
            this.X2ValBox.Location = new System.Drawing.Point(48, 91);
            this.X2ValBox.Name = "X2ValBox";
            this.X2ValBox.Size = new System.Drawing.Size(48, 22);
            this.X2ValBox.TabIndex = 1;
            this.X2ValBox.TextChanged += new System.EventHandler(this.X2ValBox_TextChanged);
            // 
            // X1ValBox
            // 
            this.X1ValBox.Location = new System.Drawing.Point(142, 91);
            this.X1ValBox.Name = "X1ValBox";
            this.X1ValBox.Size = new System.Drawing.Size(48, 22);
            this.X1ValBox.TabIndex = 2;
            this.X1ValBox.TextChanged += new System.EventHandler(this.X1ValBox_TextChanged);
            // 
            // X0ValBox
            // 
            this.X0ValBox.Location = new System.Drawing.Point(228, 91);
            this.X0ValBox.Name = "X0ValBox";
            this.X0ValBox.Size = new System.Drawing.Size(48, 22);
            this.X0ValBox.TabIndex = 3;
            this.X0ValBox.TextChanged += new System.EventHandler(this.X0ValBox_TextChanged);
            // 
            // TrigEcuationComboBox
            // 
            this.TrigEcuationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrigEcuationComboBox.FormattingEnabled = true;
            this.TrigEcuationComboBox.Items.AddRange(new object[] {
            "sin(x)",
            "cos(x)",
            "tg(x)"});
            this.TrigEcuationComboBox.Location = new System.Drawing.Point(48, 206);
            this.TrigEcuationComboBox.Name = "TrigEcuationComboBox";
            this.TrigEcuationComboBox.Size = new System.Drawing.Size(121, 24);
            this.TrigEcuationComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "= ";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(394, 88);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 9;
            this.CalcButton.Text = "Calculeaza";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // DespreButton
            // 
            this.DespreButton.Location = new System.Drawing.Point(394, 170);
            this.DespreButton.Name = "DespreButton";
            this.DespreButton.Size = new System.Drawing.Size(75, 23);
            this.DespreButton.TabIndex = 10;
            this.DespreButton.Text = "Despre";
            this.DespreButton.UseVisualStyleBackColor = true;
            this.DespreButton.Click += new System.EventHandler(this.DespreButton_Click);
            // 
            // IesireButton
            // 
            this.IesireButton.Location = new System.Drawing.Point(394, 253);
            this.IesireButton.Name = "IesireButton";
            this.IesireButton.Size = new System.Drawing.Size(75, 23);
            this.IesireButton.TabIndex = 11;
            this.IesireButton.Text = "Iesire";
            this.IesireButton.UseVisualStyleBackColor = true;
            this.IesireButton.Click += new System.EventHandler(this.IesireButton_Click);
            // 
            // SolutieBox
            // 
            this.SolutieBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutieBox.Location = new System.Drawing.Point(48, 329);
            this.SolutieBox.Name = "SolutieBox";
            this.SolutieBox.ReadOnly = true;
            this.SolutieBox.Size = new System.Drawing.Size(421, 30);
            this.SolutieBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Solutie:";
            // 
            // PolinomButton
            // 
            this.PolinomButton.AutoSize = true;
            this.PolinomButton.Location = new System.Drawing.Point(3, 0);
            this.PolinomButton.Name = "PolinomButton";
            this.PolinomButton.Size = new System.Drawing.Size(152, 21);
            this.PolinomButton.TabIndex = 14;
            this.PolinomButton.TabStop = true;
            this.PolinomButton.Text = "Ecuatie Polinomiala";
            this.PolinomButton.UseVisualStyleBackColor = true;
            this.PolinomButton.CheckedChanged += new System.EventHandler(this.PolinomButton_CheckedChanged);
            // 
            // TrigonometricButton
            // 
            this.TrigonometricButton.AutoSize = true;
            this.TrigonometricButton.Location = new System.Drawing.Point(0, 115);
            this.TrigonometricButton.Name = "TrigonometricButton";
            this.TrigonometricButton.Size = new System.Drawing.Size(175, 21);
            this.TrigonometricButton.TabIndex = 15;
            this.TrigonometricButton.TabStop = true;
            this.TrigonometricButton.Text = "Ecuatie Trigonometrica";
            this.TrigonometricButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PolinomButton);
            this.panel1.Controls.Add(this.TrigonometricButton);
            this.panel1.Location = new System.Drawing.Point(48, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 139);
            this.panel1.TabIndex = 16;
            // 
            // TrigValBox
            // 
            this.TrigValBox.Location = new System.Drawing.Point(228, 206);
            this.TrigValBox.Name = "TrigValBox";
            this.TrigValBox.Size = new System.Drawing.Size(48, 22);
            this.TrigValBox.TabIndex = 17;
            this.TrigValBox.TextChanged += new System.EventHandler(this.TrigValBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "x +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = " = 0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(503, 417);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrigValBox);
            this.Controls.Add(this.X0ValBox);
            this.Controls.Add(this.X1ValBox);
            this.Controls.Add(this.X2ValBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SolutieBox);
            this.Controls.Add(this.IesireButton);
            this.Controls.Add(this.DespreButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrigEcuationComboBox);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PolinomButton.Checked)
                {
                    double x2 = double.Parse(X2ValBox.Text);
                    double x1 = double.Parse(X1ValBox.Text);
                    double x0 = double.Parse(X0ValBox.Text);

                    PolyEquation ecuatie = new PolyEquation(x2, x1, x0);

                    SolutieBox.Text = ecuatie.Solve();
                }
                else if (TrigonometricButton.Checked)
                {
                    int functionIdex = TrigEcuationComboBox.SelectedIndex;
                    double arg = double.Parse(TrigValBox.Text);
                    TrigEquation ecuatie = new TrigEquation((TrigonometricFunction)functionIdex, arg);
                    SolutieBox.Text = ecuatie.Solve();
                }
                else
                {
                    MessageBox.Show("Selectati un tip de ecuatie", "Warning", MessageBoxButtons.OK);
                }
            }
            catch(PolyException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
            }
            catch (TrigException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
            }
        }

        private void DespreButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Laboratorul 2 IP\nPetrisor Eduard-Gabriel\n1311A", "Despre", MessageBoxButtons.OK);
        }

        private void IesireButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PolinomButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void X2ValBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(X2ValBox.Text, "[^0-9.-]"))
            {
                MessageBox.Show("Please enter only numbers.");
                X2ValBox.Clear();
            }
        }

        private void X1ValBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(X1ValBox.Text, "[^0-9.-]"))
            {
                MessageBox.Show("Please enter only numbers.");
                X1ValBox.Clear();
            }
        }

        private void X0ValBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(X0ValBox.Text, "[^0-9.-]"))
            {
                MessageBox.Show("Please enter only numbers.");
                X0ValBox.Clear();
            }
        }

        private void TrigValBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TrigValBox.Text, "[^0-9.-]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TrigValBox.Clear();
            }
        }
    }
}
