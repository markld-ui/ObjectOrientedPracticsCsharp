using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Exceptions
{
    public class StringLengthException : Exception
    {
        public StringLengthException(string propertyName, int maxLength)
            : base($"{propertyName} должен быть меньше {maxLength} символов.") { }
    }
}
