using System;

namespace ArrayLibrary
{
    public class Calc
    {
        public static int[] Inverse(int[] a)//метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),
        {
            int[] b = a;
            for (int i = 0; i < a.Length; i++)
                b[i] = a[i] * -1;
            return b;
        }
        public static int[] Multy(int[] a, int b)//метод Multi, умножающий каждый элемент массива на определённое число,
        {
            int[] c = a;
            for (int i = 0; i < a.Length; i++)
                c[i] = a[i] * b;
            return c;
        }
    }
    struct Sum
    {
        int[] a;
        public int SumArr//Создать свойство Sum, которое возвращает сумму элементов массива,
        {
            get
            {
                int sum = 0;
                int n = a.Length;
                for (int i = 0; i < n; i++)
                    sum += a[i];
                return sum;
            }
        }
    }
    struct MaxCount
    {
        int[] a;
        public int MaxCountArr//свойство MaxCount, возвращающее количество максимальных элементов. 
        {
            get
            {
                int maxcount = 0;
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                maxcount++;
                return maxcount;
            }
        }
    }

}
