<img style="float: right;" src="../../Images/aublogosmall.png"> 

**CMPS 253 Software Engineering - Spring 2019-2020 \
Mahmoud Bdeir \
American University of Beirut**




## Lesson 1: Inline Logging (The Need for Reusability)


To provide logging functionality to your application, you might start by using inline calls to logging (like a simple `Console.Writeline()`, `print()`, `printf()`, etc.)

 
 ```c#
using System;
using System.Threading;
 
namespace Logger.Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{DateTime.Now} Program Started");
            Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds
            Console.WriteLine($"Program Ended"); //programmer forgot to include time stamp
        }
    }
}
```

###### Class Diagram
![Lesson 1 Class Diagram](../PlantUML/Class-Diagram.png)
###### Deployment Diagram
![Lesson 1 Deployment Diagram](../PlantUML/Deployment-Diagram.png)


_____

![problem icon](../../Images/problem.png 'Problem') This solution is not optimal because you want the logging output to be standard: What if you forget to include a date/time stamp in one of your inline methods? Notice how the second call to logging does not output any timestamp.

<table style='width=100%;'>
<tr>
<td><a href="../../../../"><img src='../../Images/leftarrow.png'> Back</a></td>
<td width="100%"></td>
<td><a href="../../../../tree/master/Lesson%2002%20Log%20Method"><img src='../../Images/rightarrow.png'> Next</a></td>
</tr>
</table>
