Console.Write("Rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
Random rand  = new Random();

Console.WriteLine("Created array:");
for (int i = 0; i < m; ++i)
{
    for(int j = 0; j < n; ++j)
    {
        array[i, j] = rand.Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.Write("Which column to change? ");
int ch1 = Convert.ToInt32(Console.ReadLine());
--ch1;

Console.Write("Which column to change to? ");
int ch2 = Convert.ToInt32(Console.ReadLine());
--ch2;

if (ch1>=0 && ch1<n && ch2>=0 && ch2<n && ch1!=ch2)
{
    Console.WriteLine("Changed array:");
    for (int i = 0; i < m; ++i)
    {
        int temp = array[i, ch1];
        array[i, ch1] = array[i, ch2];
        array[i, ch2] = temp;
        for (int j = 0; j < n; ++j) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}