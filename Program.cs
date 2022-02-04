// Task16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Введите номер дня недели: ");
string day = Console.ReadLine();

if (day == "1" || day == "2"|| day == "3" || day == "4" || day =="5") 
{
    Console.WriteLine("Это рабочий день");
}

else if (day == "6" || day == "7")
{
    Console.WriteLine("Это выходной");
}

else Console.WriteLine("Такого дня не существует!");