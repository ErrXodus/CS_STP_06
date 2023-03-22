using System;

namespace CS_STP_06
{
    [Serializable]
    public class Worker
    {
        /// <summary>
        /// ЗП работника
        /// </summary>
        protected double salary;
        /// <summary>
        /// Квалификация работника
        /// </summary>
        protected double k;

        public Worker()
        {

        }
        /// <summary>
        /// Задание параметров нового работника через конструктор
        /// </summary>
        /// <param name="_salary">ЗП работника</param>
        /// <param name="_k">Квалификация работника</param>
        public Worker(double _salary, double _k)
        {
            this.salary = _salary;
            this.k = _k;
        }
        /// <summary>
        /// Задание параметров нового работника
        /// </summary>
        /// <param name="_salary">ЗП работника</param>
        /// <param name="_k">Квалификация работника</param>
        public void Init(double _salary, double _k)
        {
            salary = _salary;
            k = _k;
        }
        /// <summary>
        /// Получение ЗП сотрудника
        /// </summary>
        /// <returns>ЗП сотрудника без учета квалификации</returns>
        public double GetSalary()
        {
            return salary;
        }
        /// <summary>
        /// Получение коэфициента квалификации сотрудника
        /// </summary>
        /// <returns>Коэфициент квалификации сотрудника</returns>
        public double GetK()
        {
            return k;
        }

        /// <summary>
        /// Считвыание данных работника
        /// </summary>
        public void Read()
        {

            Console.WriteLine("Введите зарплату = ");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите квалификацию = ");
            k = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Отображение свойств работника
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Зарплата = " + salary);
            Console.WriteLine("Квалификация = " + k + "\n");
        }
        /// <summary>
        /// Получение ЗП работника с учетом квалификации
        /// </summary>
        /// <returns>Расчетная ЗП сотрудника</returns>
        public double Calc()
        {
            return salary * k;
        }

    }
}
