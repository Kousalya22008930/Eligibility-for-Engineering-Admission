using System;
using System.Numerics;
class Eligibility
{
    static void Main(string[] args)
    {
        int maths, physics, chemistry,total;
        Console.WriteLine("Enter the Maths mark:");
        maths = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Physics mark");
        physics= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Chemistry mark");
        chemistry= Convert.ToInt32(Console.ReadLine());
        total = maths + physics + chemistry;
        if (maths >= 65 && physics >= 55 && chemistry >= 50)
        {
            if (total>= 180 || (maths + physics)>= 140)
            {
                Console.WriteLine("Eligible for admission with total marks of {0} out of 300",total);
            }
            else
            {
                Console.WriteLine("Not Eligible for admission with total marks of {0} out of 300",total);
            }
        }
        else
        {
            Console.WriteLine("Not Eligible for admission with total marks {0} out of 300",total);
        }
    }
}

