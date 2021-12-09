namespace Task_Additional_BirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание Дополнительное
            //Используя Visual Studio, создайте проект по шаблону Console Application. 
            //Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить 
            //количество дней до его следующего дня рождения. 
            #endregion


            // Input data
            Console.Write("Please, insert the day of your birth:");
            int dayBirth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please, insert the month of your birth:");
            int monthBirth = Convert.ToInt32(Console.ReadLine());


            // Read self-documented code! Ha -ha
            TimeSpan days = new DateTime(DateTime.Now.Year + 1, monthBirth, dayBirth) - DateTime.Now;


            Console.Write($"Please, wait {days.Days} days!");

            Console.ReadLine();
        }
    }
}

