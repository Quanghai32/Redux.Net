using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redux.Net
{
    public class RootStore
    {
        public static IStore<int> CounterStore { get; private set; }

        public static void InitStore()
        {
            CounterStore = new Store<int>(CounterReducer.Execute, 0);
        }
    }
}
