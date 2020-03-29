<img style="float: right;" src="../../Images/aublogosmall.png"> 

**CMPS 253 Software Engineering - Spring 2019-2020 \
Mahmoud Bdeir \
American University of Beirut**




## Lesson 3: Logger Class (Abstraction Through Classes)


A better approach would be to create a class whose sole responsibility is to log _(achieving SRP)_.
Any other class can use the static method in the `Logger` class




```C#
using System;
namespace Logger.Lesson3
{
    public class Logger
    {
        public static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now} {msg}");
        }
    }
}
```

```C#
using System;
using System.Threading;
namespace Logger.Lesson3
{
    class Program
    {
        static void Main(string[] args) //send email to all students
        {
            Logger.Log("Program Started");
            Thread.Sleep(3000); //Simulating work by having the progr
            Logger.Log("Program Ended");
        }
    }
}
```


###### Class Diagram
![Lesson 3 Class Diagram](../images/Class-Diagram.png)
###### Deployment Diagram
![Lesson 3 Deployment Diagram](../images/Deployment-Diagram.png)
____

![problem icon](../../Images/problem.png 'Problem') You can’t easily share the `Logger` class with other applications. Sharing the source code of `Logger` is never a solution.

<table style='width=100%;'>
<tr>
<td><a href="../../../../tree/master/Lesson%2002%20Log%20Method"><img src='../../Images/leftarrow.png'> Back</a></td>
<td width="100%"></td>
<td><a href="../../../../tree/master/Lesson%2004%20Logger%20Library/Source%20Code"><img src='../../Images/rightarrow.png'> Next</a></td>
</tr>
</table>
