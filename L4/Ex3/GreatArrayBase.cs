namespace Ex2
{
    internal static class GreatArrayBase
    {
        public static int[] FixArray(int n, int min, int max)
        {
            int[] a;
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
            Div.Div3(a);
            return a;
        }
        public static int[] MakeArray(int n, int f, int s)
        {
            int[] a;
            a = new int[n];
            a[0] = f;
            for (int i = 1; i < n; i++)
                a[i] = a[i] + s;
            return a;
        }
    }
}