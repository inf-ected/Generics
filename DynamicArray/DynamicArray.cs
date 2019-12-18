using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class DynamicArray<T>
    {
        private T[] _arr;
        private int _count;
        public int Count { get { return _count; }  }
        public int Capacity { get {return _arr.Length; } }

        public T this[int index]
        {
            get {
                if (IndexInRange(index))
                    return _arr[index];
                else throw new IndexOutOfRangeException();
            }
            set {
                if (IndexInRange(index))
                    _arr[index] = value;
                else throw new IndexOutOfRangeException();
            }
        }
        public bool IndexInRange(int x) { return x < _count && x >= 0; }

        public T this[string s]
        {
            get {
                if (s == "first") return this[0];
                else if (s == "last") return this[Count - 1];
                else
                    throw new ArgumentException();
            }
            set {
                if (s == "first") this[0]=value;
                else if (s == "last") this[Count - 1]=value;
                else
                    throw new ArgumentException();
            }
        }
        public DynamicArray(int lenght) {
            _arr = new T[lenght];
            _count = 0;
        }
        public DynamicArray() : this(8) { }

        public void AddItem(T item)
        {
            _arr[_count] = item;
            _count++;
        }

    }
}
