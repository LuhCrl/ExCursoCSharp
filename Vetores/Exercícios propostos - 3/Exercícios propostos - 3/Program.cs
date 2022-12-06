using System.Globalization;

int N;
int[] A;
int[] B;
int[] C;

N = int.Parse(Console.ReadLine());
A = new int[N];
B = new int[N];
C = new int[N];

string[] d1 = Console.ReadLine().Split(' ');
string[] d2 = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++)
{
    A[i] = int.Parse(d1[i]);
    B[i] = int.Parse(d2[i]);

    C[i] = A[i] + B[i];
}

foreach (int X in C)
{
    Console.Wr