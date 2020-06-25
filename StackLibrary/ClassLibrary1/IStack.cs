using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IStack <T>: IEnumerable <T>
    {
        void Push(T value);
        void Clear();
        T Pop();
        T Peek();
        int Count { get; } 
        bool IsEmpty { get; }
    }
}
