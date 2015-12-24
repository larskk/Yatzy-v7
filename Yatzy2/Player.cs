using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    public class Player
    {
        public static string[] players = new string[4]
            {
                "Tobias",
                "Thomas",
                "Computer1",
                "Computer2",
            };
        public static string currentPlayer = players[0];
    }
}
