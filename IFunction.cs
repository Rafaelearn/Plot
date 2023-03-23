using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plot
{
    public interface IFunction
    {
        bool IsValueOfXCorrect(float x);
        float Y(float x);
        bool TryPassParameters(string[] splitBySpace);
        string FormatAsString();
    }
}
