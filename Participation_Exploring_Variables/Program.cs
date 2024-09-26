namespace Participation_Exploring_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string heroFirstName = "Ethan";
            string heroLastName = "Shek";
            string heroFullName;
            string minionTitle = "NoOb";
            string villianTitle= "MaStEr oF tHe NoObS";
            string villianName;
            string minion1Name;
            string minion2Name;

            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;

            heroFullName = heroFirstName + " " + heroLastName;

            /*Console.WriteLine("Behold the glorious hero!");
            Console.WriteLine(heroFullName);*/

            Console.WriteLine("Behold the legendary hero of programming, whose name is: " + heroFullName);

            villianName = "Gru";
            minion1Name = "Bob";
            minion2Name = "Kevin";

            Console.WriteLine(heroFullName + "'s" + " arch rivial is " + villianName + " " + villianTitle);
            Console.WriteLine(villianName + " the " + villianTitle + " is helped out by: " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);
            Console.WriteLine();

            //prepared to fight?
            Console.WriteLine("The fighters enter the room!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine("Minion 1's health:" + minion1Health);
            Console.WriteLine("Minion 2's health:" + minion2Health);
            Console.WriteLine();

            //Time to Fight!!!
            Console.WriteLine("The fight has begun!!!");
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage with the freeze ray!");
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFirstName + " now has " + heroHealth + " health!");
            Console.WriteLine("The evil minion attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage with the banana!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFirstName + " now has " + heroHealth + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage with the banana!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFirstName + " now has " + heroHealth + " health!");
            Console.WriteLine();

            //Hero fight
            Console.WriteLine(heroFullName + " attacks each villian for " + heroStrength + " damage!");
            bossHealth = bossHealth - heroStrength;
            minion1Health = minion1Health - heroStrength;
            minion2Health = minion2Health - heroStrength;
            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minion1Health + " the " + minionTitle + " now has " + minion1Health + " health!");
            Console.WriteLine(minion2Health + " the " + minionTitle + " now has " + minion2Health + " health!");
            Console.WriteLine(minion1Name + " and" + minion2Name + "has been defeated!");
            Console.WriteLine();

            //buff
            Console.WriteLine(heroFirstName + " has " + heroHealth + " health!");
            Console.WriteLine(heroFirstName + " eats a cupcake to restore health!");
            heroHealth++;
            Console.WriteLine(heroFirstName + " has " + heroHealth + " health!");
            Console.WriteLine();

            //Final fight
            Console.WriteLine();







        }
    }
}
