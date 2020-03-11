using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE
{
    class Array
    {
        public int[] a;
        public int n { get; set; }
        public Array(int n) {
            a = new int[n];
        }
        public Array() {
            n = 0;
            a = new int[n];
        }
        public void InputArray() {
            Console.Write(" input size of array: ");
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++) {
                Console.Write("a[" + (i +1) + "]: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void OutputArray() {
            for (int i = 0; i < n; i++) {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public void SortArrayByAccending() {
            for (int i = 0; i < n-1; i++) {
                for (int j = i + 1; j < n; j++) {
                    if (a[i] > a[j]) {
                        int tempt = a[i];
                        a[i] = a[j];
                        a[j] = tempt;
                        a[j] = tempt;
                    }
                }
            }
        }
        public void CheckMissing() {
            int checkPoint = 0;
            if (a[0] != 1)
            {
                Console.WriteLine("You are looking for number: " + 1);
            }
            else {
                for (int i = 0; i < n - 1; i++)
                {
                    int tempt = a[i + 1] - a[i];
                    if (tempt != 1)
                    {
                        Console.WriteLine("You are looking for number: " + tempt);
                        checkPoint = 1;
                        break;
                    }
                }
                if (checkPoint == 0)
                {
                    Console.WriteLine("Your array is perfect");
                }
            }
           
        }
    }
}
