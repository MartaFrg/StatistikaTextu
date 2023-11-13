using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatistikaTextu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "Tohle je pokusný text pro statistiku.";
            var serazenaPismena = text.GroupBy(x => x);
            Console.WriteLine($"Spočtená písmena v textu \"{text}\" ");
            foreach (var item in serazenaPismena.OrderBy(x=>x.Key))
            {
                Console.WriteLine(item.Key + " " + item.Count());
            }
            Console.ReadLine();
        }
    }
}
