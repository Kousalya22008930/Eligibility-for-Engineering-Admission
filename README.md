# Eligibility-for-Engineering-Admission
## Aim:
To write a C# program to check whether the student is eligibile for the engineering admission

## Algorithm:
### Step1: 
Get the maths, chemistry and physics marks from the user using ReadLine().

### Step2: 
Calculate the sum of all three subjects and check whether the sum is greater than and equal to 180.

### Step3:
Calculate the sum of physics and maths and check whether the sum is greater than or equal to 140.

### Step4:
Print the result.

## Program:
```
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

```
## Output:


## Result:
Thus the above C# program to check the eligibility of engineering admission is successfully executed

