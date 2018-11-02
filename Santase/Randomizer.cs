using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase
{
    public class Randomizer
    {
        static Random random = new Random();
        public  List<int> GenerateRandom(int count)
        {
            // generate count random values.
            HashSet<int> candidates = new HashSet<int>();
            while (candidates.Count < count)
            {
                int randomNumber = random.Next(0, count);
                if (!candidates.Contains(randomNumber)) {
                    candidates.Add(randomNumber);
                }  
            }       

            var descendingOrder = candidates.OrderByDescending(gi => gi);
            // load them in to a list.
            List<int> result = new List<int>();
            result.AddRange(candidates);

            // shuffle the results:
            int i = result.Count;
            while (i > 1)
            {
                i--;
                int k = random.Next(i + 1);
                int value = result[k];
                result[k] = result[i];
                result[i] = value;
            }
            return result;
        }
    }
}
