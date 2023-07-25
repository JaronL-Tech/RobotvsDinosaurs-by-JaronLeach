using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Robot_VS_Dinosaur_lab
{
    public class Robot
    {
        //Members Variable
        public string Name;
        public int Health;
        public int activeweapon;

        //Constructor 
        public Robot(string name, int health, int activeweapon)
        {
            this.Name = name;
            this.Health = 350;
            this.activeweapon = activeweapon;
        }

        public void Attack(Dinosaur dinosaur)
        {
            Console.WriteLine($"{Name} attacks {dinosaur.Name}");
            dinosaur.health -= activeweapon;
        }

        
        
    {
}



