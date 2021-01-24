using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Store myStore = new Store();

            myStore.AddPeopleIntoTheQueue("First Shopper");
            myStore.AddPeopleIntoTheQueue("Second Shopper");
            myStore.AddPeopleIntoTheQueue("Third Shopper");
            myStore.AddPeopleIntoTheQueue("Fourth Shopper");
            myStore.AddPeopleIntoTheQueue("Fifth Shopper");

            myStore.ShopperHasPaid();

            myStore.ShowMeTheActualShoppers();

            //myStore.ShowMeHowManyShoppersIHave();

            //Queue<string> myQueue = new Queue<string>();
            //myQueue.Enqueue("I'm first in line");
            //myQueue.Enqueue("Second in line");
            //myQueue.Enqueue("Third");
            //myQueue.Enqueue("How long am I going to wait");

            //string[] myNewArray = myQueue.ToArray();

            //Console.WriteLine(myNewArray[3]);

            //int result = myQueue.Count;

            //Console.WriteLine(result);

            //bool result = myQueue.Contains("Third");

            //Console.WriteLine(result);


            ////foreach(var item in myQueue)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //string result = myQueue.Dequeue();

            //Console.WriteLine(result);

        }
    }


    public class Store
    {
        private Queue<string> waitingQueue = new Queue<string>();

        public void AddPeopleIntoTheQueue(string parameter)
        {
            waitingQueue.Enqueue(parameter);
        }

        public void ShowMeHowManyShoppersIHave()
        {
            Console.WriteLine("I have these many shoppers: " + waitingQueue.Count);
        }

        public void ShowMeTheActualShoppers()
        {
            foreach(var item in waitingQueue)
            {
                Console.WriteLine("Shopper: " + item);
            }
        }

        public void ShopperHasPaid()
        {
            waitingQueue.Dequeue();
        }

    }
}
