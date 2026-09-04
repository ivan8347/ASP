/*using System.Numerics;

namespace Blazor.Components.Pages
{
	public partial class Fibonacci
	{
		int a = 0, b = 1, c = 0, i = 0, n = 0;
		//       cout << "Введите число :";

		//cin >> n;
		//cout << "Ряд Фибоначи числа:" << n << endl;
		void Calculate()
		{
			while (i < n)
			{
				a = b;
				b = c;
				c = a + b;

				//	cout << "\t" << c << endl;
				i++;
			}
		}
	}
}*/
using System.Numerics;
using System.Collections.Generic;

namespace Blazor.Components.Pages
{
    public partial class Fibonacci
    {
        private int n = 0;
        private List<BigInteger> F = new();

        private void Calculate()
        {
            F.Clear();
            if (n <= 0) return;

            BigInteger a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                F.Add(a);
                BigInteger next = a + b;
                a = b;
                b = next;
            }
        }
    }
}

