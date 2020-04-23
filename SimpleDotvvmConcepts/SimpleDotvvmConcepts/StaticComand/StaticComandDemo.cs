using DotVVM.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleDotvvmConcepts.StaticComand
{
    public class StaticComandDemo
    {
        [AllowStaticCommand]
        public static string GetRandomFunnyAnimalUrl()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

            return $"img/seal{(random.Next() % 4 + 1)}.jpg";
        }
    }
}
