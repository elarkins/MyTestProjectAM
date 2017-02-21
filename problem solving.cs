using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem 9.6 Parallelogram Words

General Statement:
Output a given word horizontally and multiple times vertically so that each letter in the horizontal word matches the position of that letter vertically.

Input:
            a word;

Output:
            The horizontal word is to be in the center of the output.Each vertical word is to read down from the top.The first vertical word uses the first letter of the horizontal word.The last vertical word uses the last letter of the horizontal word.

All outputs are to have the same left edge vertically.

The output is to be formatted exactly like that for the sample output given below.

Assumptions: 
All letters are upper case. The maximum word length is 10.

Sample Input:
TEST;
;
Sample output:
   T; 
            TE;
            TES;
            TEST;
            EST;
            ST;
            T;


Sample Input:
SAMPLE

Sample Output:
     S;
            SA;
            SAM;
            SAMP;
            SAMPL;
           SAMPLE;
            AMPLE;
            PLE;
            LE;
            E;

Sample Input:
ART;

Sample Output:
  A
 AR;
ART; 
RT;
T;
        }
    }
}
