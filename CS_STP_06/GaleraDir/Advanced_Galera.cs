using System;

namespace CS_STP_06
{
    public class Advanced_Galera: Galera
    {
		/// <summary>
		/// Работник
		/// </summary>
		private Worker Rab;
		/// <summary>
		/// Расширенная версия работника
		/// </summary>
		private Advanced_Worker Advaned_Rab;

		/// <summary>
		/// Конструктор по умолчанию, имя не задано
		/// </summary>
		public Advanced_Galera()
		{
			Galera_name = "Не задано";
		}
		/// <summary>
		/// Конструктор с параметрами
		/// </summary>
		/// <param name="name">Имя компании</param>
		/// <param name="Rab">Работник в компании</param>
		/// <param name="Adv_Rab">Улучшенный работник в компании</param>
		public Advanced_Galera(string name, Worker Rab, Advanced_Worker Adv_Rab)
		{
			Galera_name = name;
			this.Rab = Rab;
			this.Advaned_Rab = Adv_Rab;
		}
		/// <summary>
		/// Получения объекта работника
		/// </summary>
		/// <returns>Работник компании</returns>
		public Worker GetWorker()
		{
			return Rab;
		}
		/// <summary>
		/// Получения объекта улучшенного работника
		/// </summary>
		/// <returns>Улучшенный паботник компании</returns>
		public Advanced_Worker GetAdvancedWorker()
		{
			return Advaned_Rab;
		}
		/// <summary>
		/// Получение суммы зарплат работников компании
		/// </summary>
		/// <returns>Сумма зарплат</returns>
		public override double SumAllSalarys()
		{
			return Rab.Calc() + Advaned_Rab.Calc();
		}
		/// <summary>
		/// Отображение работника с наибольшей зарплатой
		/// </summary>
		public void GetHighestSalarys()
		{
			/*
			 В этой версии программы метод сразу выводит данные работника,
			 хоть и название начинается с Get 
			 что предполагает возврат и получение объекта работника
			 */
			Console.WriteLine("Наибольшая зарплата у работника");
			if (Advaned_Rab.Calc() > Rab.Calc())
				Advaned_Rab.Display();
			Rab.Display();
		}
		/// <summary>
		/// Отображение данных работников
		/// </summary>
		public void Display()
		{
			Rab.Display();
			Advaned_Rab.Display();
		}
		/// <summary>
		/// Считывание данных работников
		/// </summary>
		public void Read()
		{
			base.Read();
		}
    }
}
