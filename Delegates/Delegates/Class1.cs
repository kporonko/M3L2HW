using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Class1
    {
        /// <summary>
        /// The variable of DelegateClass1.
        /// </summary>
        private DelegateClass1 _delegate1;

        /// <summary>
        /// Void delegate for method show.
        /// </summary>
        /// <param name="val">Bool value.</param>
        public delegate void DelegateClass1(bool val);

        /// <summary>
        /// Delegate for the pow operation.
        /// </summary>
        /// <param name="x">First number.</param>
        /// <param name="y">Second number.</param>
        /// <returns>Integer value of result of pow.</returns>
        public delegate int DelegateForPow(int x, int y);

        /// <summary>
        /// Gets or sets delegate field (Wrote it because of stylecop. Long story.)
        /// </summary>
        /// <value>
        /// Gets and sets delegate field.
        /// </value>
        internal DelegateClass1 Delegate1 { get => _delegate1; set => _delegate1 = value; }

        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
