using System.Globalization;

int N;
int soma = 0;
int[,] mat;

N = int.Parse(Console.ReadLine());
mat = new int[N, N];

for (int i = 0; i < N; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    for(int j = 0; j < N; j++)
    {
        mat[i, j] = int.Parse(s[j]);
    }
}

for(int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (i == 0 && j >= 1 )
        {
            soma += mat[i, j];
            
        }
    }
}
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (i == 1 && j == 2)
        {
            soma += mat[i, j];

        }
    }
}


Console.WriteLine(soma);