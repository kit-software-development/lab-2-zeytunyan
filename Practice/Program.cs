﻿using Practice.HR;
using System;

namespace Practice
{
    /// <summary>
    ///     Цели работы:
    ///     1. на практике познакомиться с механизмом наследования;
    ///     2. научиться использовать полиморфизм;
    ///     3. научиться разделять контексты;
    ///     4. научиться использовать инкапсуляцию на уровне библиотеки;
    ///     5. научиться использовать абстрактные типы данных.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IClient client = Builders.ClientBuilder()
                .Name("Иванов", "Иван", "Иванович") 
                .Discount(.1f)
                .Build();

            IEmployee employee = Builders.EmployeeBuilder()
                .Name("Сидоров", "Григорий", "Петрович")
                .Department("Бухгалтерия")
                .Build();

            /*
             * TODO #8: Собрать приложение. 
             */

            /*
             * TODO #9: При помощи отладчика проверить типы и структуру объектов, адресованных переменными client и employee.
             */

            Console.WriteLine(client.GetType());
            Console.WriteLine(client.Name.FullName);
            Console.WriteLine(client.Name.ShortName);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(employee.GetType());
            Console.WriteLine(employee.Name.FullName);
            Console.WriteLine(employee.Name.ShortName);

            Console.ReadLine();
        }
    }
}
