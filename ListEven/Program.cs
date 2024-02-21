using System.Collections;
using System.Collections.Generic;

namespace ListEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listEven = new List<int>();
            List<int> listOdd = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]%2 == 0)
                {
                    listEven.Add(list[i]);
                }
            }
            Console.WriteLine("Chetni" + string.Join(" ", GetEvenElement(list)));
            Console.WriteLine("Nechetni" + string.Join(" ", GetOddElement(list)));



                
         
            
        }
        static List<int> GetEvenElement(List<int> inputs)
        {
            List<int> listEven = new List<int>();
            for (int i = 0; i < inputs.Count; i++)
            {
                if (inputs[i] % 2 == 0)
                {
                    listEven.Add(inputs[i]);
                }              
            }
            return listEven;
        }
        static List<int> GetOddElement (List<int> inputs)
        {
            List<int> listOdd = new List<int>();
            for (int i = 0; i < inputs.Count;i++)
            {
                if (inputs[i] % 2 != 0)
                {
                    listOdd.Add(inputs[i]);
                }
            }
            return listOdd;
        }
        
    }
}
