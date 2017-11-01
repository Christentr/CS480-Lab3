using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Calculator : Form {
        int count = 0;
       public String finalString = "";            //Saved textbox string for calculation

        public Calculator(){
            InitializeComponent();
        }

        //Number 1
        private void button2_Click(object sender, EventArgs e){
            textBox1.Text += "1";
            count++;
        }

        //Number 2
        private void button3_Click(object sender, EventArgs e){
            textBox1.Text += "2";
            count++;
        }

        //Number 3
        private void button4_Click(object sender, EventArgs e){
            textBox1.Text += "3";
            count++;
        }

        //Number 4
         private void button6_Click(object sender, EventArgs e){
             textBox1.Text += "4";
             count++;
         }

         //Number 5
         private void button7_Click(object sender, EventArgs e){
             textBox1.Text += "5";
             count++;
         }

         //Number 6
         private void button8_Click(object sender, EventArgs e){
             textBox1.Text += "6";
             count++;
         }

         //Number 7
         private void button9_Click(object sender, EventArgs e){
             textBox1.Text += "7";
             count++;
         }

         //Number 8
         private void button10_Click(object sender, EventArgs e){
             textBox1.Text += "8";
             count++;
         }

         //Number 9
         private void button11_Click(object sender, EventArgs e){
             textBox1.Text += "9";
             count++;
         }

         //Zero
         private void o_Click(object sender, EventArgs e){
             textBox1.Text += "0";
             count++;
         }

         //Decimal
         private void button5_Click(object sender, EventArgs e){
             textBox1.Text += ".";
             count++;
         }

         //Plus
         private void button1_Click(object sender, EventArgs e){
             textBox1.Text += "+";
             count++;
         }
         //Minus
         private void button12_Click(object sender, EventArgs e){
             textBox1.Text += "-";
             count++;
         }

         //Enter
         public void button15_Click(object sender, EventArgs e){
             finalString = textBox1.Text;
             
             //Passing the sub class the strig to do computation
             Compute compute = new Compute();
             textBox1.Text = compute.calculate(finalString);
            
         }

         //Power
         private void button21_Click(object sender, EventArgs e){
             textBox1.Text += "^(";
             count++;
         }
         //Divide
         private void button14_Click(object sender, EventArgs e){
             textBox1.Text += "/";
             count++;
         }

         //Multipy
         private void button13_Click(object sender, EventArgs e)
         {
             textBox1.Text += "x";
             count++;
         }

         //Left parenthesis
         private void button16_Click(object sender, EventArgs e){
             textBox1.Text += "(";
             count++;
         }

         //Right parenthesis
         private void button17_Click(object sender, EventArgs e){
             textBox1.Text += ")";
             count++;
         }
         //Delete
         private void button20_Click(object sender, EventArgs e){
             string s = textBox1.Text;
             if (count > 1)
             {
                 s = s.Substring(0, --count);
             }
             else
             {
                 s = " ";
             }
             textBox1.Text = s;
         }

         //Clear
         private void button19_Click(object sender, EventArgs e){
             textBox1.Text = "";
             count = 0;
         }
        

        /* 
         * 
         * 
         * Unused methods
         * 
         * 
         **/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Calculator label, do nothing
        private void label1_Click(object sender, EventArgs e){
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
        }
        
  
       

        
        
        
        
        
        
        

        

        

        

      

   
       
    }
}
