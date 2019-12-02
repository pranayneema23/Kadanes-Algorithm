using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadanes_Algo
{  
    class Program
    {
        static int KadanesAlgo(int[] arr)//Algo to compute MaxSumSubArray
        {
            //int n = arr.Length;//Length of array
            int local_max = 0,global_max = Int32.MinValue;
            foreach(int a in arr)
            {
                local_max = Math.Max(a, a + local_max);
                if (local_max > global_max)
                    global_max = local_max;
            }

            return global_max;
        }
        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("Enter total no of elements");
            length = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[length];
            Console.WriteLine("Enter elements : ");
            for(int i=0; i < A.Length;i++ )
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(KadanesAlgo(A));
            Console.ReadLine();
        }
    }
}
