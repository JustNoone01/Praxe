using System.Diagnostics;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Praxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulacka K1 = new Kalkulacka();
            K1.vypis();
        }
    }
}
