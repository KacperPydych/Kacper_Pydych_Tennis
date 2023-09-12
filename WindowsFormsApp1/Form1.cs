using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1.Tests_folder;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int result1 = 0;                                 
        public int result2 = 0;
        public string winner;
        
        
        public void setTo40()
        {
            result1 = 40;
            textResult1.Text = result1.ToString();
            result2 = 40;
            textResult2.Text = result2.ToString();
        }

        public string pointForServer()
        {

            if (result1 == 0)
            {
                result1 = 15;
                textResult1.Text = result1.ToString();
                return result1.ToString();
            }
            else if (result1 == 15)
            {
                result1 = 30;
                textResult1.Text = result1.ToString();
                return result1.ToString();
            }
            else if (result1 == 30)
            {
                result1 = 40;
                textResult1.Text = result1.ToString();
                return result1.ToString();
            }
            else if (result1 == 40)
            {
                if (result2 < 40)
                {
                    wins("Server");
                    return winner;

                }
                else if (result2 > 40)
                {
                    setTo40();
                    return result1.ToString();
                }

                else
                {
                    result1++;
                    textResult1.Text = "A";
                    return "A";
                }
            }
            else if (result1 == 41)
            {
                if (result2 != 41)
                {

                    wins("Server");
                    return winner;
                }

                else
                {
                    setTo40();
                    return result1.ToString();

                }
            }
            return winner;
        }

        public string pointForReciever()
        {
            if (result2 == 0)
            {
                result2 = 15;
                textResult2.Text = result2.ToString();
                return result2.ToString();
            }
            else if (result2 == 15)
            {
                result2 = 30;
                textResult2.Text = result2.ToString();
                return result2.ToString();

            }
            else if (result2 == 30)
            {
                result2 = 40;
                textResult2.Text = result2.ToString();
                return result2.ToString();
            }
            else if (result2 == 40)
            {
                if (result1 < 40)
                {
                    wins("Reciever");
                    return winner;

                }
                else if (result1 > 40)
                {
                    setTo40();
                    return result2.ToString();
                }

                else
                {
                    result2++;
                    textResult2.Text = "A";
                    return "A";
                }
            }
            else if (result2 == 41)
            {
                if (result1 != 41)
                {

                    wins("Reciever");
                    return winner;
                }

                else
                {
                    setTo40();
                    return result2.ToString();

                }
            }
            return winner;
        }

        public void wins(String winner)
        {                           
            this.winner = winner;
            if (winner == "Server")

            {
                textResult1.BackColor = Color.LightGreen;        //if server wins, method changes background of his code to green, reciever's to red, make it impossible to change score,
                textResult2.BackColor = ColorTranslator.FromHtml("#FA5D51");                // displays winner and allows to start new game
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
                labelWin.Visible = true;
                labelWin.Text = winner + "\nWINS!";
                winner = "Server";
                
            }
            else if (winner == "Reciever")
            {
                textResult1.BackColor = ColorTranslator.FromHtml("#FA5D51");        //if server wins, method changes background of his code to green, reciever's to red, make it impossible to change score,
                textResult2.BackColor = Color.LightGreen;                // displays winner and allows to start new game
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
                labelWin.Visible = true;
                labelWin.Text = winner + "\nWINS!";                
            }
                   
        }


        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button3.Visible = false;
            labelWin.Visible = false;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            pointForServer();
        }

       

        

        private void button2_Click(object sender, EventArgs e)
        {
            pointForReciever();
            
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            result1 = 0;
            result2 = 0;

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;

            labelWin.Visible = false;

            textResult1.BackColor = Color.White;
            textResult1.Text = result1.ToString();

            textResult2.BackColor = Color.White;
            textResult2.Text = result2.ToString();      
        }

        
    }
}
