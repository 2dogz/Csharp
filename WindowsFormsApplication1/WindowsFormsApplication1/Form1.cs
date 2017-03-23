using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool turn = true;
        // true = X turn; false = Y turn
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;//rotating turns
            b.Enabled = false;//cant override once button is clicked once

        }
        private void checkForWinner()
        {
            bool there_is_a_winner = false;
            //horizontal winners
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text)) && (!B1.Enabled))
                there_is_a_winner = true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text)) && (!C1.Enabled))
                there_is_a_winner = true;
            if(there_is_a_winner)
            {
                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + "HAS WON THE DUEL");
            }
                
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Kyle Webb", "Devoleper Info");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
