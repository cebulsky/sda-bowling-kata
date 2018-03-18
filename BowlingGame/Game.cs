using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        List<Roll> _rolls;

        public Game()
        {
            _rolls = new List<Roll>();
        }

        public void Roll(int pins)
        {
            _rolls.Add(new Roll()
            {
                KnockedPinsCount = pins
            });
        }

        public int TotalScores()
        {
            int result = 0;

            foreach (var roll in _rolls)
            {
                result += roll.KnockedPinsCount;
            }
            return result;
        }

    }
}
