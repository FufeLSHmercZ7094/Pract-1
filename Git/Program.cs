// See https://aka.ms/new-console-template for more information
string Deistvie = "";
while (Deistvie != "9")
{
    Console.WriteLine("Выберите операцию для чисел от 1 до 8, если хотите выйти из программы нажмите 9: ");
    Deistvie = Console.ReadLine();
    if (Deistvie == "1")
    {
        Console.Write("Введите первое число: ");
        Console.Write("Введите второе число: ");
        int Number1 = Convert.ToInt32(Console.ReadLine());
        int Number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Number1 + Number2);
    }
    else if (Deistvie == "2")
    {
        Console.Write("Введите первое число: ");
        Console.Write("Введите второе число: ");
        int Number1 = Convert.ToInt32(Console.ReadLine());
        int Number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Number1 - Number2);
    }
    else if (Deistvie == "3")
    {
        Console.Write("Введите первое число: ");
        Console.Write("Введите второе число: ");
        int Number1 = Convert.ToInt32(Console.ReadLine());
        int Number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Number1 * Number2);
    }
    else if (Deistvie == "4")
    {
        Console.Write("Введите первое число: ");
        Console.Write("Введите второе число: ");
        int Number1 = Convert.ToInt32(Console.ReadLine());
        int Number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Number1 / Number2);
    }
    else if (Deistvie == "5")
    {
        Console.Write("Введите первое число: ");
        Console.Write("Введите второе число: ");
        int Number1 = Convert.ToInt32(Console.ReadLine());
        int Number2 = Convert.ToInt32(Console.ReadLine());
        for (int z = 1; z <= Number2; z++)
        {
            Number1 *= Number2;
        }
        Console.WriteLine(Number1);
    }
    else if (Deistvie == "6")
    {
        Console.Write("Введите первое число: ");
        int Number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(Number1));
    }
    else if (Deistvie == "7")
    {
        Console.WriteLine("Введите первое число: ");
        double Number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Number1 / 100);
    }
    else if (Deistvie == "8")
    {
        Console.Write("Введите первое число: ");
        int Number1 = Convert.ToInt32(Console.ReadLine());
        for (int z = 1; z < Number1; z++) ;
        Console.WriteLine(Number1);
    }
    else if (Deistvie == "9")
    {
        Console.WriteLine("Вы вышли из программы, ББ");
    }
    else
    {
        Console.WriteLine("Вы ввели значение, которого нет в списке. Попробуй есчё раз))");
    }
}
