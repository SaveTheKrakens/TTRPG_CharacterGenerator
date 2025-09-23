using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimerasCauldron.Utils
{
    internal static class DiceRoller
    {
        /*--ROLL D4-------------------------------------------------------------------------------------------------------------ROLL D4--*/
        public static int RollD4()
        {
            Random random = new Random();
            int roll = random.Next(1, 5);
            return roll;
        }

        public static int[] RollD4(int numRolls)
        {
            Random random = new Random();
            int[] rolls = new int[numRolls];
            for(int i = 0; i < numRolls; i++)
            {
                rolls[i] = random.Next(1, 5);
            }
            return rolls;
        }

        /*--ROLL D6-------------------------------------------------------------------------------------------------------------ROLL D6--*/
        public static int RollD6()
        {
            Random random = new Random();
            int roll = random.Next(1, 7);
            return roll;
        }

        public static int[] RollD6(int numRolls)
        {
            Random random = new Random();
            int[] rolls = new int[numRolls];
            for (int i = 0; i < numRolls; i++)
            {
                rolls[i] = random.Next(1, 7);
            }
            return rolls;
        }

        /*--ROLL D8-------------------------------------------------------------------------------------------------------------ROLL D8--*/
        public static int RollD8()
        {
            Random random = new Random();
            int roll = random.Next(1, 9);
            return roll;
        }

        public static int[] RollD8(int numRolls)
        {
            Random random = new Random();
            int[] rolls = new int[numRolls];
            for (int i = 0; i < numRolls; i++)
            {
                rolls[i] = random.Next(1, 9);
            }
            return rolls;
        }
        /*--ROLL D10-----------------------------------------------------------------------------------------------------------ROLL D10--*/
        public static int RollD10()
        {
            Random random = new Random();
            int roll = random.Next(1, 11);
            return roll;
        }

        public static int[] RollD10(int numRolls)
        {
            Random random = new Random();
            int[] rolls = new int[numRolls];
            for (int i = 0; i < numRolls; i++)
            {
                rolls[i] = random.Next(1, 11);
            }
            return rolls;
        }

        /*--ROLL D12-----------------------------------------------------------------------------------------------------------ROLL D12--*/
        public static int RollD12()
        {
            Random random = new Random();
            int roll = random.Next(1, 13);
            return roll;
        }

        public static int[] RollD12(int numRolls)
        {
            Random random = new Random();
            int[] rolls = new int[numRolls];
            for (int i = 0; i < numRolls; i++)
            {
                rolls[i] = random.Next(1, 13);
            }
            return rolls;
        }

        /*--ROLL D20-----------------------------------------------------------------------------------------------------------ROLL D20--*/
        public static int RollD20()
        {
            Random random = new Random();
            int roll = random.Next(1, 21);
            return roll;
        }

        public static int[] RollD20(int numRolls)
        {
            Random random = new Random();
            int[] rolls = new int[numRolls];
            for (int i = 0; i < numRolls; i++)
            {
                rolls[i] = random.Next(1, 21);
            }
            return rolls;
        }
    }
}
