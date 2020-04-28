using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathProblem
{

    class Program
    {
        static void Main(string[] args)
        {
            //create of list of all palidroms between 111,111 and 999,999
            List<int> palindrome = new List<int>();
            for(int i= 1;i< 10; i++)
            {
                for (int j = 1; j < 10;j++)
                {
                    for(int k = 1;k< 10;k++)
                    {
                       string StringI =  Convert.ToString(i);
                        string StringJ = Convert.ToString(j);
                        string StringK = Convert.ToString(k);
                       string pallandrom = (StringI + StringJ + StringK + StringK + StringJ + StringI);
                        palindrome.Add(Convert.ToInt32(pallandrom));
                    }
                    
                }
            }
           
            for(int i = 0; i< palindrome.Count(); i++)
            {

                bool stop = false;
                List<int> viableNumbers = new List<int>();
                //for each palindrom generate a list of factors above 100 and less then 1000
                for (int b = 1; b <= palindrome.ElementAt(i); b++)
                {            
                    if (palindrome.ElementAt(i) % b == 0 && b > 100 && b < 1000)
                    { 
                        
                        viableNumbers.Add(b);
                       // Console.WriteLine(b + " is a factor of " + palindrome.ElementAt(i));
                    }
                }

                //check the viable number list for numbers that will the plaindrom when multiplyed together
                for(int j = 0; j < viableNumbers.Count(); j++)
                {
                    for (int k = 0; k < viableNumbers.Count(); k++)
                    {

                        if(palindrome.ElementAt(i)==viableNumbers.ElementAt(k) * viableNumbers.ElementAt(j))
                        {
                            Console.WriteLine("Num1:" + Convert.ToString(viableNumbers.ElementAt(j)) +"Num 2:" + Convert.ToString(viableNumbers.ElementAt(k)));
                            Console.ReadKey();
                        }


                    }
                }
                if(stop)
                {
                    Console.ReadKey();
                }
            }
           
        }
    }
}
