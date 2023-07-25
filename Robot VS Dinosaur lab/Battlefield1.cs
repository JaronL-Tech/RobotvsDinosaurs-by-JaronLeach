namespace Robot_VS_Dinosaur_lab
    internal class Battlefield
{
    private Dinosaur dinosaur;
    private Robot robot;

    public Battlefield()
    {
        Dinosaur dinosaur = new Dinosaur("Ghidorah", 500, 100);
        Robot robot = new Robot("Barbatos", 400, 150);
    }

    public void RunGame()
    {
        DisplayWelcomeMessage();
        MainBattleSequence();
        AnnounceWinner();
    }

    public void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Greatest battle on Earth!");
        Console.WriteLine("Let the battle between our two combatations begin!");
    }

    public void MainBattleSequence()
    {
        while (dinosaur.Health > 0 && robot.Health > 0)
        {
            
            int dinosaurattackpower = dinosaur.Attack(robot);
            Console.WriteLine($"Dinosaur {dinosaur.Name} attacked Robot {robot.Name} for {dinosaurattackpower} damage!");
            Console.WriteLine($"Robot {robot.Name}'s health after the attack: {robot.Health}");

            
            if (robot.Health <= 0)
            {
                Console.WriteLine($"Robot {robot.Name} has been defeated!");

            }

            
            int robotattackpower = Robot.Attack(Dinosaurs);
            Console.WriteLine($"Robot {robot.Name} attacked Dinosaur {dinosaur.Name} for {robotattackpower} damage!");
            Console.WriteLine($"Dinosaur {dinosaur.Name}'s health after the attack: {dinosaur.Health}");

            
            if (dinosaur.Health <= 0)
            {
                Console.WriteLine($"Dinosaur {dinosaur.Name} has been defeated!");
            }
        }
    }

    public void AnnounceWinner()
    {
        if (dinosaur.Health > 0)
        {
            Console.WriteLine($"Dinosaur is the winner!");
        }
        else if (robot.Health > 0)
        {
            Console.WriteLine($"Robot is the winner!");
        }
        else
        {
            Console.WriteLine("It's a tie! Both Dinosaur and Robot have been defeated!");
        }
    }


    class Dinosaur
    {
        public string Name;
        public int Health;
        public int AttackPower;

        public Dinosaur(string name, int attackPower, int health)
        {
            this.Name = name;
            this.AttackPower = attackPower;
            this.Health = health;
        }

        public int Attack(Robot robot)
        {

            int damageInflicted = AttackPower;


            robot.Health -= damageInflicted;


            return damageInflicted;
        }


        public Robot(string name, int attackPower, int health)
        {
            this.Name = name;
            this.AttackPower = attackPower;
            this.Health = health;
        }

        public int Attack(Dinosaur dinosaur)
        {

            int damageInflicted = AttackPower;


            dinosaur.Health -= damageInflicted;


            return damageInflicted;
        }
    }

}