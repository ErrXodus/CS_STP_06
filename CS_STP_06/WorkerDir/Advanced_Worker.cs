using System;

namespace CS_STP_06
{
    public class Advanced_Worker: Worker
    {
		/// <summary>
		/// Показатель вреда на работе
		/// </summary>
		double harm = 0.1;

		/// <summary>
		/// Конструктор по умолчанию, вред 0
		/// </summary>
		public Advanced_Worker() : base()
		{
			harm = 0;
		}

		/// <summary>
		/// Конструктор, задание параметров работника
		/// </summary>
		/// <param name="salary">ЗП</param>
		/// <param name="k">Коэфициент квалификации</param>
		/// <param name="harm">Коэфициент вреда</param>
		public Advanced_Worker(double salary, double k, double harm): base(salary, k)
		{
			this.harm = harm;
		}

		/// <summary>
		/// Инициализация, задание параметров
		/// </summary>
		/// <param name="salary">ЗП</param>
		/// <param name="k">Имя работника</param>
		/// <param name="harm">Показатель вреда</param>
		public void Init(double salary, double k, double harm)
		{
			base.Init(salary, k);
			this.harm = harm;
		}
		/// <summary>
		/// Считывание данных работника
		/// </summary>
		public void Read()
		{
			base.Read();
			Console.WriteLine("Введите коэфицент вреда = ");
			harm = Convert.ToDouble(Console.ReadLine());
		}
		/// <summary>
		/// Отображение данных работника
		/// </summary>
		public void Display()
		{
			Console.WriteLine( "Коэфицент вреда = " + harm + "\n");
		}
		/// <summary>
		/// Расчет ЗП работника
		/// </summary>
		/// <returns>ЗП работника с учетом параметров</returns>
		public double Calc()
		{
			if (harm >= 1)
				return base.Calc() * 2;
			return base.Calc();
		}
	}
}
