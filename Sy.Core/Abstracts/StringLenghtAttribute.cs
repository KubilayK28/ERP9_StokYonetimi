using System;

namespace Sy.Core.Abstracts
{
    internal class StringLenghtAttribute : Attribute
    {
        private int v;

        public StringLenghtAttribute(int v)
        {
            this.v = v;
        }
    }
}