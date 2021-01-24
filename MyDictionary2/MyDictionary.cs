using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary2
{
    public class MyDictionary<T1, T2>
    {
        public List<T1> _key;
        public List<T2> _value;



        public MyDictionary()
        {
            _key = new List<T1>();
            _value = new List<T2>();

        }

        public void Add(T1 key, T2 value)
        {
            _key.Add(key);
            _value.Add(value);

        }
    }
}
