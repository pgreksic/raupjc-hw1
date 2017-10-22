using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    public class GenericListEnumerator<X> : IEnumerator<X>
    {
        public GenericListEnumerator(GenericList<X> list)
        {
            list.GetEnumerator();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public X Current { get; }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
