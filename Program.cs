// See https://aka.ms/new-console-template for more information


class Creature
{
	public static int Count = 0;

	public string Type { get; set; }
	public string Name { get; set; }
	public int Age { get; set; }
	public int Energy { get; set; }
	public int Health { get; set; } = 100;

	public Creature(string type, string name, int age, int energy)
	{
		Type = type;
		Name = name;
		Age = age;
		Energy = energy;
	}

	public void Report()
	{
		Console.WriteLine($"{Name} has {Energy} energy, {Health} health");
	}    

    public void Attack(Creature creature)
	{
		if(Energy < 100)
		{
			Console.WriteLine($"{Name} has insufficient energy to attack.");
		}
		else
		{
            Console.WriteLine($"{Name} attacks {creature.Name}");
            creature.Health -= 10;
            Energy -= 100;
        }	
		
	}

}

class Program
{
	public static void Main(string[] args)
	{
		Creature Anna = new Creature("Human", "Anna", 18, 100);
        Creature Gandalf = new Creature("Wizard", "Gandalf", 200, 1000);
        Creature Dragon = new Creature("Dragon", "Syrax", 4000, 300);

		//Code some battle
		Anna.Report();
		Dragon.Report();
		Dragon.Attack(Anna);
        Dragon.Attack(Anna);
        Dragon.Attack(Anna);
        Dragon.Attack(Anna);
        Anna.Report();
		Dragon.Report();
    }
}
