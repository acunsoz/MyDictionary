using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<T,A>
    {

        T[] _karray;//key
        A[] _varray;//value
        T[] _tempkarray;//gecici key
        A[] _tempvarray;//gecici value
        public MyDictionary()
        {
            _karray = new T[0];
            _varray = new A[0];
        }
        public void Add(T item1,A item2)
        {
            _tempkarray = _karray;
            _tempvarray = _varray;

            _karray = new T[_karray.Length+1];
            _varray = new A[_varray.Length + 1];

            for (int i = 0; i < _tempkarray.Length; i++)
            {
                _karray[i] = _tempkarray[i];
                _varray[i] = _tempvarray[i];
            }
            _karray[_karray.Length - 1] = item1;
            _varray[_varray.Length - 1] = item2;

            Console.WriteLine(_karray.Length+" adet ekleme yapıldı "+"{"+ _karray[_karray.Length-1]+" , "+ _varray[_varray.Length - 1]+"}");
        }
    }
}
