using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTestApp
{
    public interface ISampleInterface
    {
        void Test();
    }

    public struct SampleStruct
    {
        public string Test { get; set; }

        public SampleStruct(string test)
        {
            Test = test;

        }

    }

    public struct AnotherStruct : ISampleInterface
    {
        public void Test()
        {
            throw new NotImplementedException();
        }
    }



    public class MyLinkedList<T>
    {
        private class Node<T1>
        {
            public T1 Data { get; set; }
            public Node<T1> Next { get; set; }

            public Node(T1 data)
            {
                Data = data;
                Next = null;     
            }
        }

        private Node<T> head = null;

        public void Add(T nodeData)
        {
            if (head != null)
            {
                Node<T> tmp = head;
                Node<T> node = new Node<T>(nodeData);

                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }

                tmp.Next = node;
            }
            else
            {
                head = new Node<T>(nodeData);                
            }
        }

        public IEnumerable<T> GetEnumerator()
        {
            Node<T> tmp = head;
            while(tmp != null)
            {
                yield return tmp.Data;
                tmp = tmp.Next;
            }
        }

    }
}
