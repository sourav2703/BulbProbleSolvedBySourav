using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Coding_Word_Problem_Practice
{
   
    class Program 
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many bulbs you want to add:- ");
            int UserNumberOfBulb = Convert.ToInt32( Console.ReadLine());
            int[] arr = new int[UserNumberOfBulb+1];
            //sab me 0 store h(mtlb sb ON hai)...................
            for(int round = 2; round <= UserNumberOfBulb; round++)
            {
                for (int i = round; i < arr.Length ; i++)
                {
                   
                    if (i % round == 0)
                    {
                        if (arr[i] == 0)
                        {
                            arr[i] = 1;
                        }
                        else if (arr[i] == 1)
                        {
                            arr[i] = 0;
                        }
                        
                    }
                   
                }
                for (int i = 1; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("\n");
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    Console.WriteLine($"Bulb Number {i} will be ON");
                }
                
            }
            Console.ReadLine();
      
           
        }

    }
  
}
