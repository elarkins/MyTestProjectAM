﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            For this problem, you must allow the user to enter exactly 5 numbers as initial input.
The program must then ask for an additional number.

The output of the program will indicate whether the last number is contained in the first 5 numbers.
Your output should resemble that provided in the example below.

All of the numbers that will be entered are integers.

Example 1

Enter a number: 1
Enter a number: 2
Enter a number: 5
Enter a number: 10
Enter a number: 15
Enter the number to be searched: 10

The number 10 appears in the first 5 numbers.

Example 2

Enter a number: 10
Enter a number: 20
Enter a number: 30
Enter a number: 40
Enter a number: 50
Enter the number to be searched: 60

The number 60 does not appear in the first 5 number

Ask user for 5 numbers
                    Ask for a additional number
                        go back and see if its appears in the first 5 numbers by checking if it is equals to number 1,2,3,4,6
                if so it prints it
                if not it returns 



        }
    }
}
