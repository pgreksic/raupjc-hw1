using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int lastElementIndex;
        readonly private int DEFAULT_ARRAY_SIZE = 4;


        // ... IIntegerList implementation ...

        public void Add(int item)
        {
            if (_internalStorage.Length <= lastElementIndex + 1)
            {
                int[] temp = new int[_internalStorage.Length * 2];
                for (int i = 0; i < _internalStorage.Length; ++i)
                {
                    temp[i] = _internalStorage[i];
                }

                _internalStorage = temp;

            }
            _internalStorage[++lastElementIndex] = item;

        }

        //defaultni konstruktor
        public IntegerList()
        {
            _internalStorage = new int[DEFAULT_ARRAY_SIZE];
            lastElementIndex = -1;

        }


        public IntegerList(int initialSize)
        {
            _internalStorage = new int[initialSize];
            lastElementIndex = -1;
        }

        public bool Remove(int item)
        {
            int index = IndexOf(item);
            if (index.Equals(-1))
            {
                return false;
            }
            return RemoveAt(index);
        }

        public bool RemoveAt(int index)
        {
            if (index > lastElementIndex)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < lastElementIndex; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            lastElementIndex--;
            return true;
        }

        public int GetElement(int index)
        {
            if (index <= lastElementIndex)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i <= lastElementIndex; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            }
            return -1;  //default return value if element isn't found
        }

        public int Count
        {
            get { return lastElementIndex+1; }
        }

        public void Clear()
        {
            _internalStorage = new int[_internalStorage.Length];
            lastElementIndex = -1;
        }

        public bool Contains(int item)
        {
            if (IndexOf(item) != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
