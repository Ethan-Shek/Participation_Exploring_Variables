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

            heroFullName = heroFirstName + " " + heroLastName;

            /*Console.WriteLine("Behold the glorious hero!");
            Console.WriteLine(heroFullName);*/

            Console.WriteLine("Behold the legendary hero of programming, whose name is: " + heroFullName);

            villianName = "Gru";
            minion1Name = "Bob";
            minion2Name = "Kevin";

            Console.WriteLine(villianName +" the " + villianTitle + " is helped out by: " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);

        }
    }
}
