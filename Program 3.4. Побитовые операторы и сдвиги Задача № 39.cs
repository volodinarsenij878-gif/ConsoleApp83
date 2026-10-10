using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program39
{
    internal class Program
    {
        static void Main()
        {
            int n = 24;                 // 0001 1000 (4‑й и 3‑й биты установлены)
            int bitIndex = 4;          // хотим сбросить именно 4‑й бит

            // Создаём маску: 1 << 4 = 16 (0001 0000)
            // ~ инвертирует: ...1110 1111
            int mask = ~(1 << bitIndex);

            int result = n & mask;     // сбрасываем 4‑й бит
            n &= mask;                 // то же самое, но меняет саму переменную

            string binN = Convert.ToString(n, 2).PadLeft(8, '0');
            string binMask = Convert.ToString(mask & 0xFF, 2).PadLeft(8, '0'); // показываем младшие 8 бит маски
            string binResult = Convert.ToString(result, 2).PadLeft(8, '0');

            Console.WriteLine($"Исходное n = {n} → двоичное: {binN}");
            Console.WriteLine($"Маска ~(1 << {bitIndex}) → младшие 8 бит: {binMask}");
            Console.WriteLine($"Результат после сброса 4‑го бита: {result} → двоичное: {binResult}");
        }
    }
}
