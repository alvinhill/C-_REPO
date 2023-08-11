using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    class TwentyOneRules
    {
        
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1

        };

        // ACE LOGIC
        private static int[] GetAllPossibleValues(List<CARD> HAND)
        {
            
            int aceCount = HAND.Count(x => x.Face == Face.Ace);

            
            int[] result = new int[aceCount + 1];
            int value = HAND.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1) return result;


            //VALUE IS THE LOWEEST VALUE OF ACE
            for (int i = 1;i<result.Length;i++)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }



        public static bool CheckForBlackJack(List<CARD> HAND)
        {
            int[] PossibleValues = GetAllPossibleValues(HAND);
            int value = PossibleValues.Max();
            if (value == 21) return true;
            else return false;

        }

        public static bool isBusted(List<CARD> HAND)
        {
            int value = GetAllPossibleValues(HAND).Min();
            if (value > 21) return true;
            else return false;


        }
            
        public static bool ShouldDealerStay(List<CARD>HAND)
        {
            int[] PossibleValues = GetAllPossibleValues(HAND);
            
            foreach (int value in PossibleValues)
            {
                if (value >16 && value<22)
                {
                    return true;
                }

            }
            return false;

        }
       


        public static bool? CompareHands(List<CARD> playerHand, List<CARD>DealerHand)
            
        {
            int[] PlayerResults = GetAllPossibleValues(playerHand);
            int[] DealerResults = GetAllPossibleValues(DealerHand);

            int playerScore = PlayerResults.Where(x => x < 22).Max();
            int DealerScore = DealerResults.Where(x => x < 22).Max();

            if (playerScore > DealerScore) return true;
            else if (playerScore < DealerScore) return false;
            else return null;

        }

        
    }
}
