using DotVVM.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleDotvvmConcepts.StaticComand
{
    //Usable from DotVVM 2.0
    public class StaticComandDemo
    {
        [AllowStaticCommand]
        public static string GetRandomFunnyAnimalUrl()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

            return $"img/seal{(random.Next() % 4 + 1)}.jpg";
        }

        [AllowStaticCommand]
        public static async Task SnailCallAsync()
        {
            await Task.Delay(4000);
        }

        [AllowStaticCommand]
        public static void Parameters<T>(T body)
        {
        }

        [AllowStaticCommand]
        public static decimal RoundDown(decimal? number)
        {
            return Math.Floor(number?? 0);
        }
    }
}
