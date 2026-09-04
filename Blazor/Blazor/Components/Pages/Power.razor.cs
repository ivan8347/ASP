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

            // 1. Убираем класс
            isBabaFlying = false;
            StateHasChanged(); // Принудительно просим Blazor обновить DOM

            // 2. Ждем 1 кадр (минимум 16мс, ставим 50мс для надежности)
            await Task.Delay(50);

            // 3. Добавляем класс обратно -> Браузер видит изменение и запускает animation
            isBabaFlying = true;
        }

    }
}
