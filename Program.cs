// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
 //(делится ли оно на два без остатка).4 -> Четное
int Prompt(string message)
    {   
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
    };
int value = Prompt("Введите число");
    if (value%2==0)
        {
            Console.WriteLine("Число четное");
        }
    else 
        {
            Console.WriteLine("Число нечетное");
        }

