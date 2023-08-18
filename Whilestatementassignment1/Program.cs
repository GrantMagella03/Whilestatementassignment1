using Whilestatementassignment1;

internal class Program
{
    private static void Main(string[] args)
    {
        //FIZZBUZZ();
        //SwitchTest1();
        //SumCubed();
        classtest();        
    }

    private static void classtest()
    {
        //Student.cohortnum = 41;
        //Console.WriteLine(Student.cohortnum);
        Student Megan = new Student("Megan");
        //Megan.name = "Megan";
        //Megan.state = "OH";
        Student Tony = new Student("Tony","Arizona");
        //Tony.name = "Tony";
        //Tony.state = "AZ";
        Console.WriteLine(Megan.name +" "+Megan.id+ " " + Tony.name+" "+Tony.id);
        //Student.cohortnum = 40;
        //Console.WriteLine(Student.cohortnum);
    }

    private static void FIZZBUZZ()
    {
        for(int i = 1; i <= 30; i++)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                Console.Write("FIZZBUZZ ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("FIZZ ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("BUZZ ");
            }
            else
            {
                Console.Write(i+" ");
            }
        }
    }

    private static void SwitchTest1()
    {
        string statecode = "OH";
        string statename = "";
        switch (statecode)
        {
            case "OH":
                statename = "Ohio";
                break;
            case "KY":
                statename = "Kentucky";
                break;
            case "IN":
                statename = "Indiana";
                break;
            default:
                statename = "idk";
                break;

        }
    }

    private static void SumCubed()
    {
        int sum = 0;
        for (int i = 0; i < 25; i++)
        {
            if (i % 2 != 0)
            {
                sum += (i * i * i);
                Console.WriteLine($"I^3={i * i * i}");
            }
        }
        Console.WriteLine(sum);
    }
}