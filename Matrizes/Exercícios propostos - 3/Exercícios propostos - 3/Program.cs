using System.Globalization;

int N;
int[,] met;
int[] maior;

N = int.Parse(Console.ReadLine());
met = new int[N, N];
maior = new int[N];

for(int i = 0; i < N; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    for(int j =0; j < N; j++)
    {
        met[i, j] = int.Parse(s[j]);
    }
}
for(int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (met[i, j] > maior[i])
        {
            maior[i] = met[i, j];
        }
    }
    Console.WriteLine(maior[i]);
}