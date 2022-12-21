using System;
using ExProjeto1;


int changeone;
string oldemail;


Estudantes est = new Estudantes();
Estudantes[] rooms = new Estudantes[10];


Console.Write("How Many rooms will be rented? ");
int N = int.Parse(Console.ReadLine());

for(int i = 0; i < N; i++)
{
    Console.WriteLine($"Rent #{i}: ");
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

    

Console.WriteLine("Menu: ");
Console.WriteLine("[1] Profile");
Console.WriteLine("[2] See available rooms");
int? x = int.Parse(Console.ReadLine());

switch (x)
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
                    string newemail = Console.ReadLine();
                    est.Change(newemail);
                    changeone = 1;

                }
            } while (oldemail != est.Email && changeone == 0 );
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