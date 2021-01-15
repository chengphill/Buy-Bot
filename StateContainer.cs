using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AIOPurchaseBot
{
    public class StateContainer
    {
        public int CurrentCountState { get; set; } = 0;
        public event Action OnCountChange;
        public void SetProperty(int value) 
        {
            CurrentCountState = value;
            NotifyStateChange();
        }

        private void NotifyStateChange() => OnCountChange?.Invoke();
    }
}
