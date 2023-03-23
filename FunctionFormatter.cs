﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plot
{
    public class FunctionFormatter
    {
        public static string FormatPowerOf(string letter, int power)
        {
            if (power == 0)
                return string.Empty;
            if (power == 1)
                return letter;
            if (power < 0)
                return $"{letter}^({power})";
            return $"{letter}^{power}";
        }

        public static string FormatCoefficientWithPower(float coefficient, string letter, int power, int highestPower)
        {
            if (coefficient == 0f)
                return "0";
            if (power != highestPower && coefficient > 0f)
                return $"+{coefficient.ToString(CultureInfo.InvariantCulture)}{FormatPowerOf(letter, power)}";
            return $"{coefficient.ToString(CultureInfo.InvariantCulture)}{FormatPowerOf(letter, power)}";
        }
    }
}
