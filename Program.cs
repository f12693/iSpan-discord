namespace _20._10._20._40_類別的繼承_練習virtual_method
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>();
			people.Add(new Person { Name = "小美", Gender = false, Salary = 26000});
			people.Add(new Person { Name = "小帥", Gender = true, Salary = 26000 });
			people.Add(new Employee { Name = "小員", Gender = false , BadgeNumber = "EP001",Salary = 26000});
			people.Add(new Cleaner { Name = "小清", Gender = true, BadgeNumber = "CL001", cleaningArea = "辦公室", Salary = 26000 });
			people.Add(new Engineer { Name = "小工", Gender = true, BadgeNumber = "EN001", Salary = 26000, OvertimePay = 12000 });
			people.Add(new Salesman { Name = "小銷", Gender = false, BadgeNumber = "SM001", Salary = 26000, SalesBonus = 15000 });
			people.Add(new Manager { Name = "小管", Gender = false, BadgeNumber = "MG001", Salary = 26000, ManagerBonus = 24000 });

			foreach (Person person in people)
			{
                Console.WriteLine(person.GetDescription());
            }
		}
	}

	public class Person
	{
        public string Name { get; set; }
        public bool Gender { get; set; }

		public int Salary { get; set; } = 0;

		public virtual string GetDescription()
		{
			return $"我是{Name}, 性別:{Gender}, 薪水:{Salary}元";
		}
	}

	public class Employee : Person
	{
        public string BadgeNumber { get; set; }
		public override string GetDescription()
		{
			return $"我是{Name}, 性別:{Gender}, 員工編號:{BadgeNumber}, 薪水:{Salary}元";
		}
	}

	public class Cleaner : Employee
	{
		public string cleaningArea { get; set; }
		public override string GetDescription()
		{
			return $"我是{Name}, 性別:{Gender}, 員工編號:{BadgeNumber}, 清潔區:{cleaningArea}, 薪水:{Salary}元";
		}
	}

	public class Engineer : Employee
	{
        public int OvertimePay { get; set; }
        public override string GetDescription()
		{
			int TotalSalary = Salary + OvertimePay;
			return $"我是{Name}, 性別:{Gender}, 員工編號:{BadgeNumber}, 薪水:{TotalSalary}元";
		}

	}

	public class Salesman : Employee
	{
		public int SalesBonus { get; set; }
		public override string GetDescription()
		{
			int TotalSalary = Salary + SalesBonus;
			return $"我是{Name}, 性別:{Gender}, 員工編號:{BadgeNumber}, 薪水:{TotalSalary}元";
		}

	}

	public class Manager : Employee
	{
		public int ManagerBonus { get; set; }
		public override string GetDescription()
		{
			int TotalSalary = Salary + ManagerBonus;
			return $"我是{Name}, 性別:{Gender}, 員工編號:{BadgeNumber}, 薪水:{TotalSalary}元";
		}

	}
}