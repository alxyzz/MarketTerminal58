using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK_game_2023
{


    public static class Wallet
    {
        public static Dictionary<string, Currency> content;

        public static string Change(string coin, float q)
        {
            Currency b;
            if (content.TryGetValue(coin, out b))
            {
                b.Change(q);
                return coin + "- [" + q + " ]";
            }
            else
            {
                return "Error - invalid coin";
            }
        }

        public static void Initialize()
        {
            MongolianUraniumDollar MUD = new MongolianUraniumDollar();
            content.Add("MUD", MUD);


        }



    }

    public class Currency
    {
        //player holds a list of currencies. thes e are initialized even if player has none
        //a currency contains a quantity, a value, a random ID as a string
        //value changes periodically
        //the only static currency is the mongolian uranium-dollar, the main currency of the year 2099

        private string id;
        private float value;

        private double quantityPossessed;



        public void Change(float q)
        {
            value += q;
        }

    }


    class MongolianUraniumDollar : Currency
    {
        
    }

}
