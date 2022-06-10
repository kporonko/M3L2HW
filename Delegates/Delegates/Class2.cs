using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegates.Class1;

namespace Delegates
{
    internal class Class2
    {
        /// <summary>
        /// Delegate for Pow operation field.
        /// </summary>
        private DelegateForPow _powDelegate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Class2"/> class.
        /// </summary>
        public Class2()
        {
            // If we dont have any links in pow delegate - we must add new link on method Pow by method register.
            if (PowDelegate == null)
            {
                Class1 class1 = new Class1();
                Register(class1.Pow);
            }
        }

        /// <summary>
        /// Delegate for Result method.
        /// </summary>
        /// <param name="x">Value we want to check.</param>
        /// <returns>True or false.</returns>
        public delegate bool Predicate(int x);

        /// <summary>
        /// Gets result of the Pow operation and stores it.
        /// </summary>
        /// <value>
        /// Result of the Pow operation.
        /// </value>
        public int Res { get; private set; }

        /// <summary>
        /// Gets or sets field (same story as with Class1 property and value.)
        /// </summary>
        /// <value>
        /// Field.
        /// </value>
        internal DelegateForPow PowDelegate { get => _powDelegate; set => _powDelegate = value; }

        /// <summary>
        /// Method for operating with 2 variables by mathods, stored in delegate.
        /// </summary>
        /// <param name="delegateForPow">Delegate which methods we want to use on our x and y vars.</param>
        /// <param name="x">First value.</param>
        /// <param name="y">Second value.</param>
        /// <returns>Delegate with Result method in it.</returns>
        public Predicate Calc(DelegateForPow delegateForPow, int x, int y)
        {
            Res = delegateForPow.Invoke(x, y);
            return new Predicate(Result);
        }

        /// <summary>
        /// Method to check whether our Res value is divided entitely by x or no.
        /// </summary>
        /// <param name="x">Value.</param>
        /// <returns>True or false.</returns>
        public bool Result(int x)
        {
            if (Res % x == 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Method to add a new method links to delegate for pow.
        /// </summary>
        /// <param name="handler">Delegate.</param>
        public void Register(DelegateForPow handler)
        {
            PowDelegate += handler;
        }
    }
}
