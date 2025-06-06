using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    internal class ClickerGame
    {
        public int points = 0;
        public int pointsPerClick = 1;
        public int pointsPerClickIncrease = 1;

        public void C_K()
        {
            // Increase points per click by 1 for 10 points
            if (points >= 10)
            {
                points -= 10;
                pointsPerClick += pointsPerClickIncrease;
            }
        }

        public void C_X()
        {
            Environment.Exit(0);
        }

        public void C_Space()
        {
            points += pointsPerClick;
        }

        public void C_S()
        {
            if (points >= 100)
            {
                points -= 100;
                pointsPerClickIncrease++;
            }
        }



    }
}
