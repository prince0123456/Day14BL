using DataStructureDay14;

public class Program
{
    static void Main(string[] args)
    {
          Console.WriteLine("Welcome to Data Structures");

            LinkedList list = new LinkedList();

            list.Add(56);
            
            list.Add(70);

            list.InsertAtParticularPosition(1, 30);
            list.Display();
    }
}
