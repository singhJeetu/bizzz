/*adding two numbers. Only condition is if the sum of number 
is odd it fires an event that print a message using delegates. */

using System;  
    class EvEx2          //This is Subscriber Class
{
        static void Main(string[] args)
        {
            AddTwoNumbers a = new AddTwoNumbers();
            //Event gets binded with delegates
            a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage);
            a.Add();
            Console.Read();
        }
        //Delegates calls this method when event raised.  
        static void EventMessage()
        {
            Console.WriteLine("****Event Executed : This is Odd Number****");
        }
    }
    class AddTwoNumbers    //This is Publisher Class
{
        public delegate void dg_OddNumber();     //Declared Delegate     
        public event dg_OddNumber ev_OddNumber; //Declared Events

        public void Add()
        {
            int result;
            result = 5 + 4;
            Console.WriteLine(result.ToString());
            //Check if result is odd number then raise event
            if ((result % 2 != 0) && (ev_OddNumber != null))
            {
                ev_OddNumber(); //Raised Event
            }
        }
    }