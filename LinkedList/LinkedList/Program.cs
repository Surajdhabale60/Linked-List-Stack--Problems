﻿namespace  LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            //linkedList.Add(56);
            //linkedList.Add(30);
            //linkedList.Add(70);

            //linkedList.AddInReverseOrder(70);
            //linkedList.AddInReverseOrder(30);
            //linkedList.AddInReverseOrder(56);

            linkedList.Add(56);
            linkedList.Add(70);
            linkedList.Add(30);
            //linkedList.InsertAtParticularPosition(1,30);

            linkedList.RemoveFirstNode();

            linkedList.Display();
        }
    }
}
