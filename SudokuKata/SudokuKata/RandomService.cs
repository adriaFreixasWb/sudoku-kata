using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuKata
{
    public class RandomService
    {
        private readonly Random _randomizer;

        public RandomService()
        {
            _randomizer = new Random();
        }
        public RandomService(int seed) 
        { 
            _randomizer = new Random(seed); 
        }
        public int Next() => _randomizer.Next();
        public int Next(int maxValue) => _randomizer.Next(maxValue);
    }
}
