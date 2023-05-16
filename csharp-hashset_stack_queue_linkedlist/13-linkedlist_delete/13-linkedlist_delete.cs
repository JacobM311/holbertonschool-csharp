using System;
using System.Collections.Generic;

public class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || myLList.First == null)
        {
            return; // Index out of bounds or list is empty
        }

        if (index == 0)
        {
            myLList.RemoveFirst();
            return;
        }

        int currentIndex = 0;
        LinkedListNode<int> current = myLList.First;

        while (current != null)
        {
            if (currentIndex == index)
            {
                myLList.Remove(current);
                return;
            }
            currentIndex++;
            current = current.Next;
        }
    }
}