using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_Simulation.Calculations
{
    public static class RouletteWheel
    {
        public static KeyValuePair<TKey, Double>[] GetRandomWeigthedElements<TKey>(KeyValuePair<TKey, Double>[] elements, int size)
        {
            KeyValuePair<TKey, Double>[] ret = new KeyValuePair<TKey, Double>[size];
            double randomProb;
            Random random = new Random();
            double accumulatedWeight = 0.0;
            double[] upperBounds = new double[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                double probability = elements[i].Value;
                accumulatedWeight += probability;
                upperBounds[i] = accumulatedWeight;
            }
            randomProb = random.NextDouble() * accumulatedWeight;
            int count = 0;
            for (int i = 0; i < elements.Length && count < size; )
            {
                if (randomProb < upperBounds[i])
                {
                    ret[count] = elements[i];
                    randomProb = random.NextDouble() * accumulatedWeight;
                    i = 0;
                    count++;
                }
                else
                    i++;
            }
            for (int i = count; i < size; i++)
                ret[i] = elements[elements.Length - 1];
            return ret;
        }
    }
}
