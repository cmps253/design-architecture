<img style="float: right;" src="../../../Images/aublogosmall.png"> 

**CMPS 253 Software Engineering - Spring 2019-2020 \
Mahmoud Bdeir \
American University of Beirut**

## Lesson 5.3: Refactoring
<a href="./"><img src='../../../Images/code.png'> Source Code</a>

![problem icon](../../../Images/refactoring.png 'Refactoring') 
### Code Refactoring 
Notice there are chances for improving the names (classes, methods, and namespaces) to be more uniform:

- `Logger.dll` is no longer an appropriate name for the library that logs to console, rename it to `ConsoleLogger.dll`

- `Logger` is no longer an appropriate name for the class that logs to console, rename it to `ConsoleLogger`

- Finally, there is no need to use a different name for each logging method (`Log`, `LogToFile`) now that each method is defined in a class of its own, simply use `Log`

```C#
using System.Threading;

namespace Lesson5.Solution2Refactored
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleLogger.Log("Program Started");
			FileLogger.Log(".\\log.txt","Program Started");
			
			Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds
			
			ConsoleLogger.Log("Program Ended");
			FileLogger.Log(".\\log.txt", "Program Ended");
		}
	}
}
```

```C#
using System;

namespace Lesson5.Solution2Refactored
{
    public static class ConsoleLogger
    {
        public static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now} {msg}");
        }
    }
}
```

```C#
using System;
using System.IO;

namespace Lesson5.Solution2Refactored
{
    public static class FileLogger
    {
        public static void Log(string fileName, string msg)
        {
            File.AppendAllText(fileName, $"{DateTime.Now} {msg}\n");
        }
    }
}
```
###### Class Diagram
![Lesson 5 Solution 1 Class Diagram](https://www.plantuml.com/plantuml/img/VS-n2i9030RW_PuYerBl1QH3GN7IuYuEmPxnuEu2oRKTn7Ut5IkAufhy7tzIQKR9RGocE0LKXHKdvU2sJEG4hWQWwDWtC0ncciKdWgWqDxS9RFp_z7dOrnZT0dxolJ09neUTz0vzUlB34L18H_1ML5hnTCdsfPVGgbFpUNnfrzodhr3bKZC-REu0)
###### Deployment Diagram
![Lesson 6 Solution 1 Deployment Diagram](https://www.plantuml.com/plantuml/img/SoWkIImgAStDuUBAoqz9LL1oASeiIotIIwr8LLAevb80WkY0elpqeiJSMAvQ1QWYv_oyuloSL9_yz7IWsfIS7BXQ51aa7MwPM9KZXC5gkU1sAUYcv9VdwTgXcwXWLLgSMenD7P9HK4KEgNafG9y10000)

<table style='width=100%;'>
<tr>
<td><a href="../Lesson%2005%20Log%20To%20File/Solution%201%20FileLogger%20Class/Source%20Code"><img src='../../../Images/leftarrow.png'> Back</a></td>
<td width="100%"></td>
<td><a href=""><img src='../../../Images/rightarrow.png'> Next</a></td>
</tr>
</table>
