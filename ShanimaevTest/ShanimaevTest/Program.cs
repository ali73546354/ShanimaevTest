using System;
using InspectorLib;

namespace IvanovTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp insp = new FunctionInsp();

            // Тестирование методов
            Console.WriteLine("Информация об инспекции:");
            Console.WriteLine(insp.GetCarInspection());

            Console.WriteLine("\nГлавный инспектор:");
            Console.WriteLine(insp.GetInspector());

            Console.WriteLine("\nИзменение главного инспектора:");
            bool isUpdated = insp.SetInspector("Иванов И.И.");
            Console.WriteLine(isUpdated ? "Успешно изменен." : "Не удалось изменить.");

            Console.WriteLine("\nНовый главный инспектор:");
            Console.WriteLine(insp.GetInspector());

            Console.WriteLine("\nСписок сотрудников:");
            foreach (var employee in insp.GetWorker())
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("\nДобавление нового сотрудника:");
            insp.AddWorker("Новичок Н.Н.");
            foreach (var employee in insp.GetWorker())
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("\nСгенерированный номер:");
            string number = insp.GenerateNumber("123", "а", 75);
            Console.WriteLine(number);
        }
    }
}
