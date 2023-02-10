using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK_game_2023.Scripts
{
   public static class HelperMethods
    {
        public static float NextFloat(Random r, float min, float max)
        {
            double val = (r.NextDouble() * (max - min) + min);
            return (float)val;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[RandomSeeder.rnd.Next(s.Length)]).ToArray());
        }

        public static class RandomSeeder
        {
            public static Random rnd = new Random();
        }
    }
}
