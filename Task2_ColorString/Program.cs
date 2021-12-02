#region Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Создайте статический класс с методом void Print (string stroka, int color), который выводит на 
//экран строку заданным цветом. Используя перечисление, создайте набор цветов, доступных 
//пользователю. Ввод строки и выбор цвета предоставьте пользователю. 
#endregion

Console.Write("Please, insert the text = ");
string? str = Console.ReadLine();

Console.Write("Please, insert the code of color = ");
int codeColor = Convert.ToInt16(Console.ReadLine());

Printer.Print(str, codeColor);

Console.ReadLine();


