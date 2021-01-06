using System;
using System.Collections.Generic;
using System.Text;

namespace Task20
{
    class AddWorkerException:Exception
    {
        public object Value { get; }
        public AddWorkerException(string message, object v) : base(message)
        {
            Value = v;
        }
    }
}
