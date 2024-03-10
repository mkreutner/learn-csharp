using System;
namespace QuizzCapitales
{
	internal class OutilsMaths
	{
        public static (double, double) GetValeursMinMax(params double[] nombres)
        {
            double min = double.MaxValue;
            double max = double.MinValue;
            foreach (double nombre in nombres)
            {
                if (nombre > max) max = nombre;
                if (nombre < min) min = nombre;
            }

            return (min, max);
        }

        public static void GetValeursMinMax(out double min, out double max, params double[] nombres)
        {
            min = double.MaxValue;
            max = double.MinValue;
            foreach (double nombre in nombres)
            {
                if (nombre > max) max = nombre;
                if (nombre < min) min = nombre;
            }
        }
    }
}

