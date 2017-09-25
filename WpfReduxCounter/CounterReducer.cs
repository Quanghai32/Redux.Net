using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Redux;

namespace WpfReduxCounter
{
    public static class CounterReducer
    {
        public static int Execute(int previousState, IAction action)
        {
            if (action is IncrementAction)
            {
                return previousState + 1;
            }

            if (action is DecrementAction)
            {
                return previousState - 1;
            }

            return previousState;
        }
    }
}
