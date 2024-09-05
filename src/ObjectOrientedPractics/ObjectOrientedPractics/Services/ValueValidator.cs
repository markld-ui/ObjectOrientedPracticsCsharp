using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Exceptions;

namespace ObjectOrientedPractics.Services
{
    internal static class ValueValidator
    {
        public static void AssertStringOnLength(string? value, int maxLength, string propertyName)
        {
            if (string.IsNullOrEmpty(value) || value.Length > maxLength)
            {
                throw new StringLengthException(propertyName, maxLength);
            }
        }
    }
}
