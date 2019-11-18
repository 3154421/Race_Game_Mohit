using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_Game_Mohit
{
    public partial class Form1 : Form
    {
        validate valid = new validate();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check and validate the bet amount 
            if (valid.chkDog(Convert.ToInt32(hDog.Value)) || valid.chkDog(Convert.ToInt32(mDog.Value)) || valid.chkDog(Convert.ToInt32(tDog.Value)) && valid.chkAmount(Convert.ToInt32(tBet.Value)) || valid.chkAmount(Convert.ToInt32(mBet.Value)) || valid.chkAmount(Convert.ToInt32(hBet.Value)))
            {
                // check and validate the bet amount 
                if (hDog.Value > 0 && hBet.Value <= hBudget.Value && hBet.Value>0 )
                {
                    button2.Visible = true;
                }
                // check and validate the bet amount 
                else if (tDog.Value > 0 && tBet.Value <= tBudget.Value)
                {

                    button2.Visible = true;
                }
                // check and validate the bet amount 
                else if (mDog.Value > 0 && mBet.Value <= mBudget.Value)
                {
                    button2.Visible = true;
                }
                else
                {
                    MessageBox.Show("bet is saved in the details ");
                }
            }
            else {
                MessageBox.Show("select atleast one player ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // at last this code is used to find thewinner and reset the whole game
        public void decalre_result(int winner)
        {
            if (mDog.Value>0 ){

                if (mDog.Value == winner)
                {
                    mBudget.Value += mBet.Value;
                }
                else {
                    mBudget.Value -= mBet.Value;
                }
                    
            }

            if (tDog.Value > 0)
            {

                if (tDog.Value == winner)
                {
                    tBudget.Value += tBet.Value;
                }
                else
                {
                    tBudget.Value -= tBet.Value;
                }

            }

            if (hDog.Value > 0)
            {

                if (hDog.Value == winner)
                {
                    hBudget.Value += hBet.Value;
                }
                else
                {
                    hBudget.Value -= hBet.Value;
                }

            }


            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            pictureBox4.Left = 0;
            button2.Visible = false;

            mBet.Value = 0;
            mDog.Value = 0;

            tBet.Value = 0;
            tDog.Value = 0;

            hBet.Value = 0;
            hDog.Value = 0;


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // caling the method to run the dog
            if (valid.findWinner(pictureBox1.Left,1)!=0) {
                timer1.Stop();
                MessageBox.Show("Dog 1 is the winner");
                decalre_result(1);
            }

             if (valid.findWinner(pictureBox4.Left, 4) != 0)
            {
                timer1.Stop();
                MessageBox.Show("Dog 4 is the winner");
                decalre_result(4);
            }
            if (valid.findWinner(pictureBox2.Left, 2) != 0)
            {
                timer1.Stop();
                MessageBox.Show("Dog 2 is the winner");
                decalre_result(2);
            }

            if (valid.findWinner(pictureBox3.Left, 3) != 0)
            {
                timer1.Stop();
                MessageBox.Show("Dog 3 is the winner");
                decalre_result(3);
            }

            pictureBox1.Left += valid.genNumber();
            pictureBox4.Left +=  valid.genNumber();
            pictureBox2.Left +=  valid.genNumber();
            pictureBox3.Left +=  valid.genNumber();



        }
    }
}
