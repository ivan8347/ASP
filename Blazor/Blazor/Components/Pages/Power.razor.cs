using System.Numerics;



namespace Blazor.Components.Pages
{
    public partial class Power
    {
         double a = 1;
         int b = 1;
         double result = 1;

        private void Calculate()
        {
            result = Math.Pow(a, b);

        }

    }
}
