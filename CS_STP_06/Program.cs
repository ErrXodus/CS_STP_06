using System;

namespace CS_STP_06
{
    class Program
    {
        /// <summary>
        /// Расчет ЗП через обобщение
        /// </summary>
        /// <typeparam name="Type">Работник</typeparam>
        /// <param name="worker_">Объект работника</param>
        /// <returns>ЗП работника</returns>
        static double Calc<Type>(Type worker_) where Type : Worker
        {
            return worker_.GetSalary() * worker_.GetK();
        }
        /// <summary>
        /// Демонстрация работы обобщения
        /// </summary>
        /// <param name="args">стандартные аргументы для консоли</param>
        static void Main(string[] args)
        {
            Worker worker_ = new Worker(2, 2);
            //новый работник
            Advanced_Worker Advanced_worker_ = new Advanced_Worker(3, 5, 7);
            //новый улучшенный работник
            double res = Calc(worker_);
            //ЗП для работника
            Console.WriteLine("Результат Worker = " + res);
            res = Calc(Advanced_worker_);
            //ЗП для улучшеного работника
            Console.WriteLine("Результат Advanced_Worker = " + res);
            /*
             Этот метод нужен что бы консоль закрысь только после нажатия пользователя
             */
            Console.ReadKey();
        }
    }
}
