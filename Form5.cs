using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waterfallPro
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private double Farenheit;
        private double Celsius;
        private double Kelvin;

        private double FarenheitToCelsius
        {
            get { return (Farenheit - 32) * 5/9; }
            set { Farenheit = value; }

        }
        private double FarenheitToKelvin
        {
            get { return (Farenheit - 32) * 5/9 + 273.15; }
            set { Farenheit = value; }

        }
        private double CelsiusToKelvin
        {
            get { return Celsius+ 273.15; }
            set { Celsius = value; }

        }
        private double CelsiusToFarenheit
        {
            get { return (Celsius * 9 / 5) + 32; }
            set { Celsius = value; }

        }
        private double KelvinToCelsius
        {
            get { return Kelvin - 273.15; }
            set { Kelvin = value; }

        }
        private double KelvinToFarenheit
        {
            get { return (Kelvin - 273.15) * 9/5 + 32; }
            set { Kelvin = value; }

        }



        private void Converter()
        {
             
            if(string.IsNullOrEmpty(textBox3.Text) || textBox3.Text == "-")
            {
                textBox4.Text = "";
            }
            else if(comboBox2.Text== "Farenheit to Celsius") 
            {
                FarenheitToCelsius = Convert.ToDouble(textBox3.Text);
                textBox4.Text = FarenheitToCelsius.ToString();
            }
            else if (comboBox2.Text == "Farenheit to Kelvin")
            {
                FarenheitToKelvin = Convert.ToDouble(textBox3.Text);
                textBox4.Text = FarenheitToKelvin.ToString();
            }
            else if (comboBox2.Text == "Celsius to Farenheit")
            {
                CelsiusToFarenheit = Convert.ToDouble(textBox3.Text);
                textBox4.Text = CelsiusToFarenheit.ToString();
            }
            else if (comboBox2.Text == "Celsius to Kelvin")
            {
                CelsiusToKelvin = Convert.ToDouble(textBox3.Text);
                textBox4.Text = CelsiusToKelvin.ToString();
            }
            else if (comboBox2.Text == "Kelvin to Celsius")
            {
                KelvinToCelsius = Convert.ToDouble(textBox3.Text);
                textBox4.Text = KelvinToCelsius.ToString();
            }
            else if (comboBox2.Text == "Kelvin to Farenheit")
            {
                KelvinToFarenheit = Convert.ToDouble(textBox3.Text);
                textBox4.Text = KelvinToFarenheit.ToString();
            }
           
            
        }
            
        private void Form5_Load_5(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
        }

        

       // private void label2_Click(object sender, EventArgs e)
        //{

       // }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch == 46 && textBox3.Text.IndexOf(".") != -1) ||
               (ch == 45 && textBox3.Text.IndexOf("-") != -1) ||
                (ch == 45 && textBox3.Text.IndexOf(".") != -1) ||
               (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45))
            {
                e.Handled = true;
                
            }

        }
        private void ChangeLabel()
            {
            switch(comboBox2.Text)
            {
                case "Farenheit to Celsius":
                    label3.Text = "Farenheit";
                    label4.Text = "Celsius";
                    break;
                case "Farenheit to Kelvin":
                    label3.Text = "Farenheit";
                    label4.Text = "Kelvin";
                    break;
                case "Celsius to Kelin":
                    label3.Text = "Celsius";
                    label4.Text = "Kelvin";
                    break;
                case "Celsius to Farenheit":
                    label3.Text = "Celsius";
                    label4.Text = "Farenheit";
                    break;
                case "Kelvin to Farenheit":
                    label3.Text = "Kelvin";
                    label4.Text = "Farenheit";
                    break;
                case "Kelvin to Celsius":
                    label3.Text = "Kelvin";
                    label4.Text = "Celsius";
                    break;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Converter();
            ChangeLabel();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Converter();
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
        }

        
        

        private void Form5_Load_1(object sender, EventArgs e)
        {
            throw new NotSupportedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException();
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch == 46 && textBox3.Text.IndexOf(".") != -1) ||
               (ch == 45 && textBox3.Text.IndexOf("-") != -1) ||
                (ch == 45 && textBox3.Text.IndexOf(".") != -1) ||
               (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45))
            {
                e.Handled = true;
                
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    }

