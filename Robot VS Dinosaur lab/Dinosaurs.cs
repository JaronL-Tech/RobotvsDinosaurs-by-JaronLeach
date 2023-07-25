using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Robot_VS_Dinosaur_lab
{
    internal class Dinosaurs
    {
        //Members Variable
        public string Name;
        public int Health;
        public int AttackPower;

        //Constructor 
        public Dinosaurs(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }
        
        //member methods

    }
}
