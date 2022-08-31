using System;
using LinkedListLibrary;

namespace MarkovStateLibrary
{
    public class MarkovState
    {
        public string state;
        //public MyLinkedList<char> following; do i need this? 
        int count;

        public MarkovState(string state)
        {
            this.state = state;
            //this.following = new MyLinkedList<char>();
            this.count = 0;
        }
        public void AddSuffix(char ch)
        {
            //following.Add(ch);
            count++;
        }

        public override string ToString()
        {
            return $"{state} ({count})";
        }
    }   
}