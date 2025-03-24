
using System;
namespace CounterTask
{
    public class Counter
    {
        private int _count;
        private string _name;

        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }
        // Incremenet method 
        public void Increment()
        {
            _count++;
        }
        // Reset method 
        public void Reset()
        {
            _count = 0;
        }
        // Name proprety 
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        // Tick property for Counter class 
        public int Tick
        {
            get
            {
                return _count;
            }
        }
    }
}