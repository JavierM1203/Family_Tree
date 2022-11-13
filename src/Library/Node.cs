using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
        private T t;
        

        private List<Node<T>> children = new List<Node<T>>();

        public T Type 
        {
            get
            {
                return this.t;
            }
        }

        public ReadOnlyCollection<Node<T>> Children 
        { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T t)
        {
            this.t = t;
        }

        public void AddChildren(Node<T> t)
        {
            this.children.Add(t);
        }

        public void Accept(Visitor<T> visitor)
        {
            visitor.Visit(this);
        }        
    }
}
