﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6_last_last
{
    
        public class MyStorage<T> : IEnumerator, IEnumerable
        {
            List<T> arr;
            int pos = -1;
            public MyStorage()
            {
                arr = new List<T>();

            }
            public MyStorage(int lenght)
            {
                arr = new List<T>(lenght);

            }

            public IEnumerator GetEnumerator()
            {
                return (IEnumerator)this;
            }
            //IEnumerator
            public bool MoveNext()
            {
                pos++;
                return (pos < arr.Count);
            }
            //IEnumerable
            public void Reset()
            {
                pos = -1;
            }
            //IEnumerable
            public object Current
            {
                get { return arr[pos]; }
            }
            public int count()
            {
                return arr.Count;
            }
            public void add(T element)
            {
                arr.Add(element);

            }
            public void removeAtIndex(int pos)
            {
                arr.RemoveAt(pos);
            }
            public void remove(T element)
            {
                arr.Remove(element);
            }
            public void insert(int pos, T element)
            {
                arr.Insert(pos, element);
            }
            public T GetObject(int index)
            {
                if (index > 0 && index < arr.Count)
                {
                    return arr[index];
                }
                else return default(T);
            }
            public T GetAndDelete(int index)
            {
                if (index >= 0 && index < arr.Count+1)
                {
                    T tmp = arr[index];
                    arr.RemoveAt(index);
                    return tmp;
                }
                else return default;


            }





            public T this[int index]
            {
                get
                {
                return arr[index];
                }

            }




        }
    
}
