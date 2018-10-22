using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Lab3._2._1
{
    
    public class MyArray<T> : IList<T>, ICollection<T>, IEnumerable<T>, IComparable<T>
    {
        T[] items;

        public MyArray(): this(0)
        {
        }

        public MyArray(int length)
        {
            if (length < 0)
            {
                throw new ArgumentException("length");
            }

            items = new T[length];
        }

        private void BiggerArray()
        {
            int newLength = items.Length == 0 ? 8 :items.Length << 1;

            T[] newArray = new T[newLength];

            items.CopyTo(newArray, 0);

            items = newArray;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (items.Length == this.Count)
            {
                this.BiggerArray();
            }
            Array.Copy(items, index, items, index + 1, Count - index);

            items[index] = item;

            Count++;
        }

        public void RemoveAt(int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            int shiftStart = index + 1;
            if (shiftStart < Count)
            {
                Array.Copy(items, shiftStart, items, index, Count - shiftStart);
            }

            Count--;
        }

        public T this[int index]
        {
            get
            {
                if (index < Count)
                {
                    return items[index];
                }

                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < Count)
                {
                    items[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void Add(T item)
        {
           
                if (items.Length == Count)
                {
                    BiggerArray();
                }
                items[Count++] = item;
            
        }

        public void Clear()
        {
            items = new T[0];
            Count = 0;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(items, 0, array, arrayIndex, Count);
        }

        public int Count
        {
            get;
            private set;
        }

        public bool IsReadOnly
        {
            get {return false; }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public virtual int CompareTo(T other)
        {
            return -5;
        }
    }
}

