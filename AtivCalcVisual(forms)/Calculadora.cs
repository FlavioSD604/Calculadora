﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtivCalcVisual_forms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1, n2, result;
        bool flag = false;
        string operador;        

        private void button14_Click(object sender, EventArgs e)
        {            
                n1 = double.Parse(Linha2.Text);
                Linha1.Text += "*";
                Linha2.Text = "";
                operador = "*";                                  
        }

        private void button13_Click(object sender, EventArgs e)
        {
                n1 = double.Parse(Linha2.Text);
                Linha1.Text += "/";
                Linha2.Text = "";
                operador = "/";         
        }

        private void button15_Click(object sender, EventArgs e)
        {
                n1 = double.Parse(Linha2.Text);
                Linha1.Text += "-";
                Linha2.Text = "";
                operador = "-";            
        }

        private void button12_Click(object sender, EventArgs e)
        {
                n1 = double.Parse(Linha2.Text);
                Linha1.Text += "+";
                Linha2.Text = "";
                operador = "+";            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            flag = true; 
            n2 = double.Parse(Linha2.Text);            
            Linha2.Text = "";
            switch (operador)
            {
                case "*":                    
                        result = n1 * n2;                                    
                    break;                
                case "/":

                    if (n2 != 0)
                    {
                        result = n1 / n2;
                    }
                    else { MessageBox.Show("Erro"); }
                    break;
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
            }            
                Linha1.Text = Convert.ToString(result);
                Linha2.Text = Convert.ToString(result);
                result = 0;            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Linha1.Text.Length > 0 )
            {
                Linha1.Text = Linha1.Text.Substring(0, Linha1.Text.Length - 1);
                if (Linha2.Text.Length > 0)          
                    Linha2.Text = Linha2.Text.Substring(0, Linha2.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(Linha2.Text) / 100;
            Linha1.Text = Convert.ToString(a);
            Linha2.Text = Convert.ToString(a);
        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (flag == true) {                
                Linha2.Text = "";
                Linha1.Text += bt.Text;
                Linha2.Text += bt.Text;
                flag = false;
            }
            else
            {
                Linha1.Text += bt.Text;
                Linha2.Text += bt.Text;                               
            }            
        }

        private void btC_Click(object sender, EventArgs e)
        {
            Linha1.Text = "";
            Linha2.Text = "";
        }  
    }
}
