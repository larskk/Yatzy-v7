using System;

namespace Yatzy
{
	public class Scorecard
	{
		// Score Card Array defineres til 18 pladser
		private int[] scoreCardArray = new int[18];
		// Retur variabel for CheckScorePos
		private bool scoreCheck;

		// Tom Constructor
		public Scorecard ()
		{
		}

		// Metode til at kontrollere om given plads i scorecard er ledig.
		public bool CheckScorePos(int scoreCardPos)
		{
			if (scoreCardArray [scoreCardPos] == 0) {
				scoreCheck = true;
			} else if (scoreCardArray [scoreCardPos] != 0) {
				scoreCheck = false;
			}
			return scoreCheck;
		}

		// Henter specifik Score fra position
		public int GetScorePos(int scoreCardPos)
		{
			return scoreCardArray[scoreCardPos];
		}

		// Opdatere score på scorecardet, kontrollere plads ved brug af metode CheckScorePos
		public bool UpdateScore(int diceSum, int scoreCardPos)
		{
			if (CheckScorePos (scoreCardPos)) {
				scoreCardArray [scoreCardPos] = diceSum;
				return true;
			}
			return false;
		}

	
	}
}