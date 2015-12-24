using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    public class Dice
    {
        public static int currentRoll { get; set; } //antal terningekast

        private int faceValue; //antal øjne på terningen
        public int FaceValue
        {
            get { return faceValue; }
            set
            {
                if (value <= 6 && value >= 0)
                    faceValue = value;
                else
                    throw new Exception
                        ("Terningen kan kun tildeles en værdi fra 1-6");
            }
        }
        //De forskellige tilstande terningen kan have på skærmen
        public enum DiceState
        {
            NotRolled, //før første kast
            NotSelected, //før andet og tredje kast (kastes igen)
            Selected, //før andet og tredje kast (beholdes)
            Frozen, //efter 3. kast
        }

        public DiceState State { get; set; }

        //constructor for dice objektet
        public Dice()
        {
            this.State = DiceState.NotRolled;
        }

        // array med 5 terninger = et terningebæger
        public static Dice[] diceCup = new Dice[5];

        //4 Genveje til at ændre state:
        public void freeze()
        {
            this.State = DiceState.Frozen;
        }

        public void hold()
        {
            this.State = DiceState.Selected;
        }

        public void unhold()
        {
            this.State = DiceState.NotSelected;
        }

        public void reset()
        {
            this.State = DiceState.NotRolled;
            this.faceValue = 0;
        }

        public static int[] getDiceValues()
        {
            int[] diceValues = new int[5];
            for (int i = 0; i < diceValues.Length; i++)
            {
                diceValues[i] = diceCup[i].faceValue;
                System.Diagnostics.Debug.WriteLine(diceValues[i]);
            }
            return diceValues;
        }

        //Kast med terninger
        public static void rollDices()
        {
            currentRoll++;
            Random rnd = new Random();

            for (int i = 0; i < diceCup.Length; i++)
            {
                switch (currentRoll)
                {
                    case 1:
                        diceCup[i].faceValue = (rnd.Next(1, 7));
                        diceCup[i].unhold(); //make selectable
                        break;
                    case 2:
                        if (diceCup[i].State == DiceState.NotSelected)
                            diceCup[i].FaceValue = (rnd.Next(1, 7));
                        break;
                    case 3:
                        if (diceCup[i].State == DiceState.NotSelected)
                            diceCup[i].FaceValue = (rnd.Next(1, 7));
                        diceCup[i].freeze();
                        break;
                    case 4: //skal nok flyttes til en særlig endRoll metode
                        diceCup[i].reset();
                        break;
                }
            }
            if (currentRoll == 4)
                currentRoll = 0;
        }
    }
}
