using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzy
{
    public partial class Form1 : Form
    {

        private static int currentRound = 0;
        private static Button[] terninger = new Button[5];

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Dice.diceCup[i] = new Dice();
            }
            //kunne dette mon gøres inde i ovenstående for-løkke?
            terninger[0] = terning0;
            terninger[1] = terning1;
            terninger[2] = terning2;
            terninger[3] = terning3;
            terninger[4] = terning4;

        }

        private void dice_Click(object sender, EventArgs e)
        {
            int diceNumber = 0; //get this from sending object?
            if (Dice.diceCup[diceNumber].State == Dice.DiceState.Selected)
            {
                Dice.diceCup[diceNumber].unhold();
                terninger[diceNumber].ForeColor = Color.Black;
            } else if (Dice.diceCup[diceNumber].State == Dice.DiceState.NotSelected &&
                (Dice.currentRoll == 1 || Dice.currentRoll == 2))
            {
                Dice.diceCup[diceNumber].hold();
                terninger[diceNumber].ForeColor = Color.Red;
            }
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            Dice.rollDices();

            // Teksten på den grafiske terning sættes til den værdi
            // som den tilsvarende terning i bægeret har
            for (int i = 0; i < terninger.Length; i++)
            {
                terninger[i].Text = Dice.diceCup[i].FaceValue.ToString();
                if (Dice.diceCup[i].State == Dice.DiceState.NotRolled)
                {
                    terninger[i].ForeColor = Color.Black;

                }
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int[] array = Dice.getDiceValues();
            int score = Controller.calculateScore(9);
            MessageBox.Show("test: " + score);
        }
    }
}
