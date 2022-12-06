using System.Globalization;

int N;
double menos10 = 0.0;
double entre10e20 = 0.0;
double maior20 = 0.0;
double totalCompra = 0.0;
double totalVenda = 0.0;
double totalLucro = 0.0;

string[] produtos;
double[] compras;
double[] vendas;

double[] lucro10;
double[] lucro20;
double[] lucro;


N = int.Parse(Console.ReadLine());
produtos = new string[N];
compras = new double[N];
vendas = new double[N];
lucro10 = new double[N];
lucro20 = new double[N];
lucro = new double[N];

for (int i = 0; i < N; i++)
{
    string[] lista = Console.ReadLine().Split(' ');
    produtos[i] = lista[0];
    compras[i] = double.Parse(lista[1], CultureInfo.InvariantCulture);
    vendas[i] = double.Parse(lista[2], CultureInfo.InvariantCulture);
}
for(int i = 0; i < N; i++)
{
    lucro10[i] = compras[i] / 100 * 10;
    lucro20[i] = compras[i] / 100 * 20; 
}

for (int i = 0; i < N; i++)
{
    lucro[i] = vendas[i] - compras[i];
    if (lucro[i] < lucro10[i])
    {
        menos10++;
    }else if (lucro[i] >= lucro10[i] && lucro[i] <= lucro20[i])
    {
        entre10e20++;
    }else
    {
        maior20++;
    }
}

for(int i = 0; i < N; i++)
{
    totalCompra += compras[i];
    totalVenda += vendas[i];
    totalLucro += lucro[i];
}


Console.WriteLine("Lucro abaixo de 10%:  " + menos10);
Console.WriteLine("Lucro entre 10% e 20%: " + entre10e20);
Console.WriteLine("Lucro acima de 20%: " + maior20);
Console.WriteLine("Valor total de compra: " + totalCompra.ToString("f2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor total de venda: " + totalVenda.ToString("f2", CultureInfo.InvariantCulture));
Console.WriteLine("Lucro total: " + totalLucro.ToString("f2", CultureInfo.InvariantCulture));


