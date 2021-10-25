using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Add the following to your console app and perform these actions:
1. A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
2. Save and execute your code.
3. A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
4. Save and execute your code.
*/
class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("This loop iterates while variable i is less than 10. This is iteration: " + i);
          
        }  
        for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("This loop iterates while variable j is less than i. This is iteration: " + j);
            }
        Console.ReadLine();
    }
}
