using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4_1
{
    class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            head = tail = null;
        }
        
        public Node<T> Head { get => head; }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> temp=Head;
            while (temp != null)
            {
                action(temp.Data);
                temp=temp.Next;
            }
        }
    }
}
