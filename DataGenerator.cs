using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GALoseRateVisualtisation
{
    /// <summary>
    /// Generates data depending on the student's variant.
    /// </summary>
    public static class DataGenerator
    {
        /// <summary>
        /// Generates data depending on the student's variant.
        /// </summary>
        /// <param name="variant">Variant of the student (simply any int32 number).</param>
        /// <returns>100 stages.</returns>
        public static IEnumerable<StageInfo> GetStagesInfo(int variant)
        {
            // Set random seed depending on the user variant
            Random r = new Random(variant);

            // Find new players count
            int usersLeft = r.Next(7000, 10500);

            // For each of 100 stages of the game
            for (int i = 0; i < 100; ++i)
            {
                // Find rates
                double winRate = NextDouble(r, 0.25, 0.95);
                double almostWinRate = NextDouble(r, 0.05, 0.95);
                double continuedPlayingRate = NextDouble(r, 0.9, 1.0);

                // Calculate data to output
                int won = Convert.ToInt32((double)usersLeft * winRate);
                int almostWon = Convert.ToInt32((double)(usersLeft - won) * almostWinRate);

                // Output next element
                yield return new StageInfo
                {
                    StageIndex = i + 1,
                    Started = usersLeft,
                    Won = won,
                    AlmostWon = almostWon
                };

                // Decrease users count
                usersLeft = Convert.ToInt32((double)usersLeft * continuedPlayingRate);
            }
        }

        /// <summary>
        /// Generates number in the given range [min, max).
        /// </summary>
        /// <param name="r">Random object.</param>
        /// <param name="min">Minimum value to generate (inclusive lower bound).</param>
        /// <param name="max">Maximum value to generate (exclusive upper bound).</param>
        /// <returns>Floating point value in the range [min, max).
        /// Fraction is from 0.00 to 0.99</returns>
        private static double NextDouble(Random r, double min, double max)
        {
            // Some magic code here
            return Convert.ToDouble(r.Next(Convert.ToInt32(min * 100.0), Convert.ToInt32(max * 100.0))) / 100.0;
        }

    }

}
