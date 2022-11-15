long[] res = new long[51];
res[0] = 0;
res[1] = 1;

for (int i = 2; i < 51; i++)
{
    res[i] = res[i-1] + res[i-2];
}

Console.WriteLine($"Wynik to {res[50]}");
