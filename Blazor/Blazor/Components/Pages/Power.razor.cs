using System.Numerics;



namespace Blazor.Components.Pages
{
    public partial class Power
    {
         double a = 1;
         int b = 1;
         double result = 1;
        private bool isBabaFlying = false;

        private async Task CalculateAsync()
        {
            result = Math.Pow(a, b);

            isBabaFlying = false;

            await Task.Delay(50);

            isBabaFlying = true;
        }

    }
}
