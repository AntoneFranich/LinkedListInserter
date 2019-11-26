using System;

namespace LinkedListInserter
{
    class LinkedListManager
    {
        //Can't use a struct for a node, as you can't have a parameter of the struct inside itself in C#.
        public class LinkedListNode
        {
            public LinkedListNode next = null;
            public LinkedListNode prev = null;

            int value;
            public int Value { get { return value; } }

            public LinkedListNode(int _value)
            {
                value = _value;
            }
        }
        private LinkedListNode first = null;
        public LinkedListNode First { get { return first; } }

        public void InsertValue(int newValue)
        {
            //If we don't have a first node, then set this value to the first node.
            if (first == null)
            {
                first = new LinkedListNode(newValue);
            }
            else
            {
                //Otherwise create a node for it, and setup some iteration values.
                LinkedListNode node = new LinkedListNode(newValue);
                LinkedListNode curr = first;
                LinkedListNode prev = null;
                //Loop through the linked list until we find the end or a node with a lower number.
                while (node.Value > curr.Value)
                {
                    prev = curr;
                    curr = curr.next;

                    //We hit the end, so break out.
                    if (curr == null)
                        break;
                }
                //Set the next and prev values of our node.
                node.next = curr;
                node.prev = prev;

                //If prev is null, then we were lower than the first element.
                if (prev == null)
                    first = node;
                else
                    prev.next = node;
                //If curr isn't null, we're not at the end of list and need to se the prev node.
                if (curr != null)
                    curr.prev = node;
            }
        }

        public void AutomatedTest()
        {

            int[] testArray = new int[] { 54, 68, 17, 1, 43, 1002, 432, 523, 186, 275, 8324, 832, 947, 4, 13, 0 };
            //Insert out values into the linked list.
            foreach (int i in testArray)
                InsertValue(i);

            //setup debug output.
            string output = "...";
            LinkedListNode curr = first;
            //iterate through and add each value to the debug output.
            while (curr != null)
            {
                output += curr.Value + "...";
                curr = curr.next;
            }
            //write the output to the console.
            Console.WriteLine(output);
        }
    }
}
