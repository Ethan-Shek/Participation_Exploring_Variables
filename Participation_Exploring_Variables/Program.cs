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




        }
    }
}
