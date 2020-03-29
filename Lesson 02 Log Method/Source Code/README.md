<img style="float: right;" src="../../Images/aublogosmall.png"> 

**CMPS 253 Software Engineering - Spring 2019-2020 \
American University of Beirut \
Mahmoud Bdeir**


## Lesson 2: Log Method (Abstraction Through Methods)


A better solution would be to use a method to do the logging, this way you guarantee uniform log output (for example: time followed by message) and we achieve Reusability.
> Software Reusability is an attribute that refers to the expected reuse potential of a software component. Software reuse not only improves productivity but also has a positive impact on the quality and maintainability of software products.

```C#
using System;
using System.Threading;
namespace Logger.Lesson2
{
    class Program
    {
        static void Main(string[] args) //send email to all students
        {
            Log("Program Started");
            Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds
            Log("Program Ended");
        }
        static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now} {msg}");
        }
    }
}
```

###### Class Diagram
![Lesson 2 Class Diagram](../PlantUML/Class-Diagram.png)
###### Deployment Diagram
![Lesson 2 Deployment Diagram](../PlantUML/Deployment-Diagram.png)

____
![problem icon](../../Images/problem.png 'Problem') You can use this method in the `Program` class only. How do you share it with other classes? Making the method public allows other classes to call on this method. However, doing so would defeat SRP:
> Single Responsibility Principle or SRP: A class should have one, and only one, reason to change.

<table style='width=100%;'>
<tr>
<td><a href="../../../../tree/master/Lesson%2001%20Inline%20Logging"><img src='../../Images/leftarrow.png'> Back</a></td>
<td width="100%"></td>
<td><a href="../../../../tree/master/Lesson%2003%20Logger%20Class"><img src='../../Images/rightarrow.png'> Next</a></td>
</tr>
</table>
