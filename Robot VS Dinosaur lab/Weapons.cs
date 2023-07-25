using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Weapon
{ 


    public string Type;
    public int AttackPower;

    public Weapon(string type, int attackPower)
    {
        this.Type = type;
        AttackPower = attackPower;
    }




    public Weapon()
    {
        string type = "lightsaber";
        int attackPowerValue = 75;



        Weapon lightsaber = new Weapon(type, attackPowerValue);

        
        Console.WriteLine($"Weapon: {lightsaber.Type}, Attack Power: {lightsaber.AttackPower}");
 
    }
}
