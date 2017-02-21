using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            //This assignment is to practice using loops to manipulate arrays
            // Create a program that does the following:

            //Declare an array of 50 integers called myIntArray1
            int[] myintArray1 = new int[50];
            //Declare an array of 100 integers called myIntArray2
            int[] myintArray2 = new int[100];
            //Declare an array of 100 doubles called myIntArray3
            int[] myintArray3 = new int[100];
            //Declare an array of 200 doubles called myDblArray1
            double[] myDblArray = new double[200];
            //set the elements of myIntArray1 to hold numbers 0-49;
            int k = 0;
            while (k < myintArray1.Length)
            {
                myintArray1[k] = k;
                k = k + 1;
            }

            //set the elements of myIntArray2 to hold the first 100 even numbers
            int x = 0;
            while(x < 100){
                myintArray2[x] = x*2;
                x = x + 1;
            }


            //set the elements of myIntArray3 to hold the first 100 odd numbers
            x = 0;
            while(x < 100)
            {
                myintArray3[x] = x * 2 + 1;
                x = x + 1;
            }


            //set the elements of myDblArray1 to hold 0-99.5 including every half number
            x = 0;
            while (x < 200) 
            {
                myDblArray[x] = x/2.0;
                 x = x + 1;
            }


            //print out the all of the values of myIntArray1
            x = 0;
            while (x < 50)
            {
                Console.WriteLine(myintArray3[x]);
                x = x + 1;
            }

            //print out the all of the values of myIntArray2
                     
            Console.WriteLine(myintArray2[100]);
            //print out the all of the values of myIntArray3
            Console.WriteLine(myintArray3[100]);
            //print out the all of the values of myDblArray1
            Console.WriteLine(myintArray1[50]);
            //update the values of each element of myIntArray1 to be the current value + the value of the element before it.
            Console.ReadLine(print out Value of myintArray1);
            //Ex: if myIntArray1[0] == 0, myIntArray1[1] == 1, myIntArray1[2]==2, myIntArray1[3] ==3, and myIntArray1[4] ==4  then:
            Console.ReadLine(print value of myintArray1);
            // myIntArray1[0] should be unchanged (element 0 is first element)
            Console.ReadLine(Go through element of myintArray1);
            // myIntArray1[1] should be updated to be 1 (0+1)
            Console.ReadLine(myintArray1 Go up by 1);
            // myIntArray1[2] should be updated to be 3 (1+2)
            Console.ReadLine(myIntArray1 go up by 2);
            // myIntArray1[3] should be updated to be 6 (3+3) //note this uses the new value for element 2.
            Console.ReadLine(myIntArray1 go up by element 2);
            // myIntArray1[4] should be updated to be 10 (6+4) //note this uses the new value for element 2.
            //etc. 
            Console.Readline(now set myIntArray1 to 10);