using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSkill_CSharpConsoleApp.Helpers
{
    public class Tea
    {
        public string MakeTea()
        {
            var water = BoilWater();

            Console.WriteLine("Take the cups out.");

            Console.WriteLine("Put tea in cups.");

            Console.WriteLine($"Pour {water} in cups");

            return "Tea";
        }

        private string BoilWater()
        {
            Console.WriteLine("Start the kettle");

            Console.WriteLine("Waiting for the kettle to heat.");

            Task.Delay(2000).GetAwaiter().GetResult();

            Console.WriteLine("Kettle finished boiling.");

            return "boiled water";
        }


        public async Task<string> MakeTeaAsync()
        {
            var boilingWater = BoilWaterAsync();

            Console.WriteLine("Take the cups out.");

            Console.WriteLine("Put tea in cups.");

            var water = await boilingWater;

            Console.WriteLine($"Pour {water} in cups");

            return "Tea";
        }

        private async Task<string> BoilWaterAsync()
        {
            Console.WriteLine("Start the kettle");

            Console.WriteLine("Waiting for the kettle to heat.");

            await Task.Delay(2000);

            Console.WriteLine("Kettle finished boiling.");

            return "boiled water";
        }
    }
}
