using System;
using System.Linq;

namespace CS_STP_06
{
    [Serializable]
    public abstract class Galera
    {
        /// <summary>
        /// Название компании
        /// </summary>
        protected String Galera_name;
        private Worker[] Workers;

        /// <summary>
        /// Задание параметров компании
        /// </summary>
        /// <param name="_name">Имя компании</param>
        /// <param name="_workers">Работники компании</param>
        public Galera(string _name, Worker[] _workers)
        {
            Galera_name = _name;
            Workers = _workers;
        }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Galera()
        { }

        /// <summary>
        /// Инициализация, задание работников
        /// </summary>
        /// <param name="_Workers"></param>
        public void Init(Worker[] _Workers)
        {
            /*
             Метод называется инициализация, но по факту задаются только работники
             */
            Workers = _Workers;
        }
        /// <summary>
		/// Считывание данных компании
		/// </summary>
        public void Read()
        {
            /*
             Считывание только имени компании
             */
            Console.WriteLine("Название компании = ");
            Galera_name = Console.ReadLine();
        }
        /// <summary>
        /// Получение всех работников
        /// </summary>
        /// <returns>Worker[] работники компании</returns>
        public Worker[] GetWorkers()
        {
            return Workers;
        }

        /// <summary>
        /// Получение работника с наибольшей зарплатой
        /// </summary>
        /// <returns></returns>
        public Worker GetHighestSalarys()
        {
            double maxSal = 0;
            int max_el_index = 0;
            for (int i = 0; i < Workers.Length; i++)
            {

                if (Workers[i].Calc() > maxSal)
                {
                    maxSal = Workers[i].Calc();
                    max_el_index = i;

                }

            }
            return Workers[max_el_index];
        }
        /// <summary>
        /// Абстрактный метод для расчета суммы всех ЗП
        /// </summary>
        /// <returns>сумма ЗП всех работников</returns>
        public abstract double SumAllSalarys();
        /// <summary>
        /// Метод для расчета суммы всех ЗП
        /// </summary>
        /// <returns>сумма ЗП всех работников</returns>
        public double GaleraSumAllSalarys()
        {
            double maxSal = 0;
            foreach (Worker el in Workers)
            {
                maxSal += el.Calc();
            }
            return maxSal;
        }
        /// <summary>
        /// Отображение информации о компании и ее работниках
        /// </summary>
        public void Display()
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("\nКомпания называется " + Galera_name + "\n");
            int count = 1;
            foreach (Worker el in Workers)
            {
                Console.WriteLine("Работник №" + count);
                el.Display();
                Console.WriteLine("Зарплата сотрудника \n");
                Console.WriteLine(el.Calc() + "\n");
            }
            Console.WriteLine("______________________________\n");
        }
        /// <summary>
        /// Изменение имени компании
        /// </summary>
        public void ChangeName()
        {
            /*
             В данный момент не применяется
             */
            string res = "";
            string[] el = Galera_name.Split(' ');
            for (int i = 0; i < el.Length; i++)
            {
                res += new string(el[i].Reverse().ToArray()) + ' ';
            }
            Galera_name = res;
        }

    }
}
