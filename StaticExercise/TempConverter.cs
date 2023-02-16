using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter

    {
        public static double FahrenheitToCelsius(double num)
        {
            return (num - 32) * .555;
        }
        public static double CelsiusToFahrenheit(double num)
        {
            return (num * 1.8) + 32;
        }
    }

    }
