using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK_game_2023
{


    public static class Wallet
    {
        public static float MUD; //Mongolian Uranium Dollars, the global currency in the current year, uranium having replaced petroleum as the most valuable and commonly used energy source. this is used as the basic value of any other coin...
        public static Dictionary<string, Currency> content = new Dictionary<string, Currency>();






        public static void Transaction(float price, Currency cgained, float cAmt)
        {
            MUD += price;
            content[cgained.GetName()].ChangeQuantity(cAmt); 
        }







        public static string ModifyAmount(string coin, float q)
        {
            try
            {
                content[coin].ChangeQuantity(q);

                return coin + "- [" + q + " ]";
            }
            catch (Exception)
            {

                return "Error. Coin does not exist";
            }
        }


        public static Currency GetRandomCurrency()
        {

            return content.ElementAt(Scripts.HelperMethods.RandomSeeder.rnd.Next(0, content.Count)).Value;
        }


        public static void ChangePrices()
        {
            foreach (var item in content)
            {
                item.Value.DoValueDrift();
            }
        }

        public static void Initialize()
        {
            MUD = Presets.startingMoney;
            GenerateCurrencies();

        }

        private static void GenerateCurrencies()
        {
            content = new Dictionary<string, Currency>();
            for (int i = 0; i < Presets.currAmt; i++)
            {

                
                string newname = Scripts.HelperMethods.RandomString(Presets.coinNameLength);
                System.Diagnostics.Debug.WriteLine("Generated new coin" + newname);
                Currency c = new Currency(newname, Scripts.HelperMethods.NextFloat(Scripts.HelperMethods.RandomSeeder.rnd, 0.5f, 5f), Scripts.HelperMethods.RandomSeeder.rnd.Next(1, 100), Scripts.HelperMethods.NextFloat(Scripts.HelperMethods.RandomSeeder.rnd, 0.1f, 0.5f));
                content.Add(c.GetName(), c);
            }
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
        private float amount  = 0;
        public float lastValueChange;
        private int volatility; //1-100
        private float maxValueChange;
        
        public string GetName()
        {
            return id;
        }

        public float GetValue()
        {
            return value;
        }
        public float GetAmt()
        {
            return amount;
        }

        public void ChangeQuantity(float q)
        {
            amount += q;
        }

        public void ChangeValue(float q)
        {
            value += q;
        }

        public Currency(string name, float val, int vol, float changeMax)
        {
            id = name;
            value = val;
            volatility = vol;
            maxValueChange = changeMax;
        }


        public void DoValueDrift()
        {
            if (Scripts.HelperMethods.RandomSeeder.rnd.Next(0, 100) > (100-volatility))
            {
                lastValueChange = Scripts.HelperMethods.NextFloat(Scripts.HelperMethods.RandomSeeder.rnd, -maxValueChange, maxValueChange);
               
                value = value+lastValueChange > 0.1f ? value + lastValueChange : 0.1f;


            }

        }

    }




}
