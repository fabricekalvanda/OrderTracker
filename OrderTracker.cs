// Fabrice Kalvanda
// October 7th, 2020
// Order_Tracker
/* 
    Purpose: This program get the orders from the client,
    then print out the list of orders in ascending and descending order.
*/

using System;
using System.Collections;

namespace Order_Tracker
{
    class MainClass
    {
        public static void introMsg()//Method to print the welcome Message
        {
            Console.Clear();
            Console.WriteLine("Hi, Welcome to Tina’s Palace! " +
                "There is a long line ahead of us so let’s get started :)\n");
            Console.WriteLine("What would you like?");
        }

        public static void Main(string[] args)
        {
            string clientOrder;//set the variable to store user input
            Stack myStack = new Stack();//declaring the stack
            Queue myQueue = new Queue();//declaring the queue

            introMsg();//print the intro message 

            clientOrder = Console.ReadLine();//userinput
            string clientInput = clientOrder.ToUpper();

            /* 
                checking if the input is not equal to "QUIT" or "quit" 
                then keep storing orders in the stack and queue.
            */
            if (clientInput != "QUIT")
            {
                myStack.Push(clientOrder);
                myQueue.Enqueue(clientOrder);
                do
                {
                    Console.WriteLine("Next! What would you like? ");
                    clientOrder = Console.ReadLine();
                    myStack.Push(clientOrder);
                    myQueue.Enqueue(clientOrder);
                }
                while ((clientOrder != "QUIT") && (clientOrder != "quit"));

                Console.Clear();
                Console.WriteLine("\nOrder Summary for the day: \n");
                Console.WriteLine("List of orders: \n");
            }

            /* print the following if user input is "QUIT" or "quit"*/
            else
            {
                Console.Clear();
                Console.WriteLine("Order Summary for the day: \n");
                Console.WriteLine("List of orders: ");
                Console.WriteLine("NONE ");
            }
            

            string lastString;//To not print the last element "QUIT"
            int queueCounter = 1;//counter of orders
          
            foreach (var orders in myQueue)//printing order ascendent using queue
            {
                
                lastString = (string)orders;

                if((lastString != "QUIT") && (lastString != "quit"))
                {
                    Console.Write("Order #" + queueCounter + ": ");
                    Console.WriteLine(orders + " ");
                    queueCounter++;
                }

            }

            Console.WriteLine();

            string lastElmnt;//To not print the last element "QUIT"
            int stackCounter = myStack.Count - 1;//counter of orders

            foreach (var orders in myStack)//printing order descendent using stack
            {
                lastElmnt = (string)orders;

                if ((lastElmnt != "QUIT") && (lastElmnt != "quit"))
                {
                    Console.Write("Order #" + stackCounter + ": ");
                    Console.WriteLine(orders + " ");
                    stackCounter--;
                    
                }
            }
            Console.WriteLine();
        }
    }
}
