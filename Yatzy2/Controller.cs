using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    class Controller
    {
        // Test
        //Tager som input en score-position og returnerer den mulige score
        public static int calculateScore(int scorePosition)
        {
            /* Scorekort inkl. bonus og totaler. Første plads bruges ikke!
            7:subtotal, 8:bonus, 9:1par, 10:2par, 11:3ens, 12:4ens,13:LS, 14:SS, 15:FH,
            16:Chance, 17:Yatzy, 18: Total */
            int[] scores = new int[19];

            //tæller hvor mange af hver terningværdi. Første plads bruges ikke!
            int[] counters = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            int[] dices = Dice.getDiceValues();


            foreach (int diceValue in dices)
            {
                //læg en til tælleren for den pågældende terningværdi
                counters[diceValue]++;

                //opdater scoren for den pågældende terningværdi
                scores[diceValue] = counters[diceValue] * diceValue;

                //Opdater scoren for chance
                scores[16] += diceValue;

                //par
                if (counters[diceValue] == 2)
                {
                    if (scores[9] == 0) //hvis ingen par i forvejen
                    {
                        scores[9] = diceValue * 2;
                    }
                    else if (scores[9] < diceValue * 2) //ny par større end den eksisterende
                    {
                        scores[10] = scores[9] + diceValue * 2; //2 par
                        scores[9] = diceValue * 2;
                    }
                    else //ny par mindre end den eksistrende. Kun score for 2 par opdateres
                    {
                        scores[10] = scores[9] + diceValue * 2;
                    }
                }

                //3 ens
                if (counters[diceValue] == 3)
                {
                    scores[11] = diceValue * 3;
                }

                //4 ens
                if (counters[diceValue] == 4)
                {
                    scores[12] = diceValue * 4;
                }


                //YATZY!
                if (counters[diceValue] == 5)
                {
                    scores[17] = diceValue * 5;
                }
            }

            //beregn total før øverste sektion
            scores[7] = scores[1] + scores[2] + scores[3] + scores[4] + scores[5] + scores[6];

            //beregn bonusscore
            if (scores[7] >= 63)
            { scores[8] = 50; }

            // Straight
            if (scores[9] == 0) //hvis der ingen par findes, må der være en straight!
            {
                if (scores[6] == 0) //hvis ingen seksere, må det være lille straight
                {
                    scores[13] = 15;
                }
                else //stor straight
                {
                    scores[14] = 20;
                }
            }

            //Fuldt hus
            if (scores[9] > 0 && scores[11] > 0) //hvis der findes både par og 3 ens
            {
                scores[15] = scores[9] + scores[11];
            }

            //Total score

            return scores[scorePosition];
        }
    }
}
