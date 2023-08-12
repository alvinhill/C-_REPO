using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BLACKJACK
{
    public class DEALER
    {
        //adding a class as a property instead of inheriting it
        public string Name { get; set; }
        public DECK DECK { get; set; }
        public int Balance { get; set; }


        public void Deal(List<CARD> HAND)
        {
            HAND.Add(DECK.CARDS.First());
            string card = string.Format(DECK.CARDS.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file= new StreamWriter(@"C:\Users\rainf\DATA\log.txt",true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            
            DECK.CARDS.RemoveAt(0);

        }


    }
}
