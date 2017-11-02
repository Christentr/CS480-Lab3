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
           int totalCount = 0;                              //Keeps track of string traversal location
           String curNum = "";                              //String holding the number that the traversal is at
           Stack<String> operations = new Stack<String>();      //Stack created for holding the operations
           LinkedList<String> numList = new LinkedList<String>(); //Linked list holding each number in a link
           while (totalCount < result.Length)                    //Traversing string 
            {
                
                //Allows integers and decimal to be added to the number string
                if ((result[totalCount] == '1') || (result[totalCount] == '2') || (result[totalCount] == '3') || (result[totalCount] == '4') ||
                    (result[totalCount] == '5') || (result[totalCount] == '6') || (result[totalCount] == '7') || (result[totalCount] == '8') ||
                    (result[totalCount] == '9') || (result[totalCount] == '0') || (result[totalCount] == '.')){
                    curNum += result[totalCount];
                    Console.WriteLine("Adding number to string: " + result[totalCount]);
                    totalCount++;
                   
                }

                //Adds operations to the stack
                else {
                    //Makes sure a parenthesis isnt first
                    if (curNum != "")
                    {
                        Console.WriteLine("Adding number to list: " + curNum);
                        numList.AddLast(curNum);                //Current num to linkList
                        curNum = "";                            //Resets the current number string for next integer
                    }
                    if (result[totalCount] == ')')
                    {   
                        while (operations.Peek() != "(")   //Continutes to pop the stack until the previous parentheis
                        {                                    //is found
                                Console.WriteLine("Adding operation to list: " + operations.Peek());
                                numList.AddLast(operations.Pop());
                         
                        }
                        operations.Pop();                   //Gets rid of the first parenthesis
                        totalCount++;                       //Moving past the parenthesis
                    }
                    //Only adds operation to stack if its not last parenthesis
                    else
                    {
                        Console.WriteLine("Checking operation to stack: " + result[totalCount]);
                        if (result[totalCount] == '(')
                        {
                            Console.WriteLine("Putting operation to stack: ( ");
                            operations.Push(result[totalCount].ToString());
                            totalCount++;
                        }
                        else if (operations.Count != 0)
                        {
                            //Pops the less precedence operations off the stack and onto the linkedList
                            //until the current one is the largest and then is added to the stack
                            int current = checkPrecedence(result[totalCount].ToString());
                            int previous = checkPrecedence(operations.Peek());
                            Console.WriteLine("The current operand is: " + current);
                            Console.WriteLine("The previous operand is: " + previous);
                            while (current > previous)
                            {
                                Console.WriteLine("Popping off operation and adding to list: " + operations.Peek());
                                numList.AddLast(operations.Pop());
                                
                                if (operations.Count != 0)                  //Makes sure there are prior operations on the stack
                                {
                                    previous = checkPrecedence(operations.Peek());
                                }
                                else
                                {                                           //If there are no prior operations on stack, exit loop
                                    previous = 4;
                                }
                            }

                            //Adds the current opperation onto the stack once it is highest presedence
                            Console.WriteLine("Pushing operation: " + result[totalCount].ToString());
                            operations.Push(result[totalCount].ToString()); //Puts the string of current operator into the stack
                            totalCount++;
                        }
                        else
                        {
                            //Adds the current opperation onto the stack since there is no other operations on the stack
                            Console.WriteLine("Pushing operation: " + result[totalCount].ToString());
                            operations.Push(result[totalCount].ToString()); //Puts the string of current operator into the stack
                            totalCount++;
                        }
                    }
                }
            }
           //Adding the last number into the linked list
           numList.AddLast(curNum);
           while(operations.Count != 0){

               numList.AddLast(operations.Pop());
           }
           //String temp = numList.First.Value;
           //Console.WriteLine("The link list start is: " + temp);
           String finalResult = "";
           Console.WriteLine("Linked List data: ");
           foreach (String ch in numList)
           {
               Console.Write(ch + " ");
               finalResult += ch + " ";
              
           }
            return finalResult;
        }
        //Returns numeric value of the opperand to decide presedence
       public int checkPrecedence(String current)
       {
           if(current.Equals("+") || current.Equals("-")){
               return 1;
               }
           else if(current.Equals("/") || current.Equals("x")){
               return 2;
           }
           else if(current.Equals("(")){
               return 4;
           }
           else
           {
               return 3;                            //Exponenial
           }
       }
    }
}
