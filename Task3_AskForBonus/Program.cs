#region Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант. 
//Присвойте каждой константе значение, задающее количество часов, которые должен отработать 
//сотрудник за месяц. 
//Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее
//давать или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему 
//положена премия.
#endregion


Console.WriteLine("Position: {0}, Standart: {1} hours, Hours: {2} hours, Bonus: {3}.",
                     Post.Driver, (int)Post.Driver, 180, Accountant.AskForBonus(Post.Driver, 180));

Console.ReadLine();
