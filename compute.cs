using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_3
{
    public class Compute : Calculator
    {
       public String calculate(String result)
        {
           int count = 0;                                   //Keeps track of string traversal location
           String number = "";                              //String holding the number that the traversal is at
           Stack<char> operations = new Stack<char>();      //Stack created for holding the operations
           LinkedList<int> numList = new LinkedList<int>(); //Linked list holding each number in a link
           while (count < result.Length)                    //Traversing string 
            {
                
                //Allows integers and decimal to be added to the number string
                if ((result[count] == '1') || (result[count] == '2') || (result[count] == '3') || (result[count] == '4') ||
                    (result[count] == '5') || (result[count] == '6') || (result[count] == '7') || (result[count] == '8') ||
                    (result[count] == '9') || (result[count] == '0') || (result[count] == '.')){
                    number += result[count];
                    count++;
                }

                //Adds operations to the stack
                else {
                    operations.Push(result[count]);
                    count++;
                }
            }
            return "Test";
        }
    }
}
