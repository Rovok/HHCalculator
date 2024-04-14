using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHCalculator
{
    internal class ClassFormulas
    {
        public static double CraftSmith(double QualityAnvil, double QualityHammer, double QualityIngridients)
        {
            return (QualityAnvil * 4 + QualityHammer * 3 + QualityIngridients * 9) / 16;
        }
        public static double BoiledInCauldron(double QualityCauldron, double QualityWater, double QualityIngridients)
        {
            return (QualityIngridients * 2 + QualityCauldron + QualityWater) / 4;
        }
        public static double[] WroughtIronSmith(double qualityAnvil, double qualityHammer, double qualityBloom)
        {
            return new double[] {
                Math.Round(((qualityBloom * 3 + qualityHammer) / 4 * 3 + qualityAnvil) / 4 * 1.2, 2),
                Math.Round(((qualityBloom * 3 + qualityHammer) / 4 * 3 + qualityAnvil) / 4, 2),
                Math.Round(((qualityBloom * 3 + qualityHammer) / 4 * 3 + qualityAnvil) / 4 * 0.8, 2) };
        }
        public static double BoardAndBranch(double qualityTool, double qualityWood)
        {
            return Math.Sqrt(qualityTool * qualityWood);
        }
    }
}
