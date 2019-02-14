using System;
namespace task2
{
   public class Student

    {
        public int id, YOS; 
        public string name; //decribing which type of are name id and yos

        public void Input() //does not return value
        {
            Console.WriteLine("Student name: ");
            name = Console.ReadLine(); //entering name through console
            Console.WriteLine("Students id: ");
            id = int.Parse(Console.ReadLine()); //entering id through console
            Console.WriteLine("Year of study:");
            YOS = int.Parse(Console.ReadLine()); //entering YOS through console

        }
    }
    public class College : Student //creating new class which displays name, id, incremented YOS. the new class is connected to class Student and has new functions 
    {
        public void Display()
        {
            Console.WriteLine("Name:" + name); 
            Console.WriteLine("id:" + id);
            Console.WriteLine("Year of study: " + ++YOS); //displaying name, id, YOS with increment
        }
        public static void Main(string[] args)
        {
            College t1 = new College();
            t1.Input(); // entering name, id, YOS through Console
            t1.Display(); //printing name, id, YOS with change

        }
    }
}
