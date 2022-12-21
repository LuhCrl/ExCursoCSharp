using System;
using ExProjeto1;

string newemail;
string cnewemail;
int changeone;
string oldemail;

Estudantes est = new Estudantes();
Estudantes[] rooms = new Estudantes[10];


Console.Write("How Many rooms will be rented? ");
int N = int.Parse(Console.ReadLine());

for(int i = 0; i < N; i++)
{
    Console.WriteLine($"Rent #{i+1}: ");
    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Email: ");
    string email = Console.ReadLine();

    Console.Write("Room: ");
    int room = int.Parse(Console.ReadLine());

    rooms[room] = new Estudantes(name);

    est.Name = name;
    est.Email = email;
}


do
{
    Console.Clear();
    Console.WriteLine("Menu: ");
    Console.WriteLine("[1] Profile");
    Console.WriteLine("[2] See available rooms");
    menu = int.Parse(Console.ReadLine());
} while (menu != 1 || menu !=2);
Console.Clear();
switch (menu)
{
    case 1:
        Console.WriteLine($"Name: {est.Name}");
        Console.WriteLine($"Email: {est.Email}");
        Console.WriteLine();
        Console.WriteLine("do you want to change email? [s/n]");
        string resp = Console.ReadLine();
        if (resp == "s" || resp == "S")
        {
            do
            {
                Console.WriteLine("enter your old email: ");
                changeone = 0;
                oldemail = Console.ReadLine();
                if (oldemail == est.Email)
                {
                    Console.WriteLine("New Email: ");
                    newemail = Console.ReadLine();                 
                    do {
                        Console.WriteLine("Confirm Email: ");
                        cnewemail = Console.ReadLine();
                        Console.Clear();
                    }while(cnewemail != newemail);
                    if (newemail == cnewemail)
                    {
                        est.Change(cnewemail);
                    }

                    Console.WriteLine();
                    changeone = 1;
                }
                Console.Clear();
            } while (oldemail != est.Email && changeone == 0 );

            Console.WriteLine("successful exchange: ");
        }
        break;

    case 2:
        Console.WriteLine("available rooms");
        for(int i = 0; i < 10; i++)
        {
            if (rooms[i] == null)
            {
                Console.WriteLine($"Room: #{i} available rooms");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Room: #{i} unavailable rooms ");
                Console.WriteLine();
            }
        }
        break;
    
}