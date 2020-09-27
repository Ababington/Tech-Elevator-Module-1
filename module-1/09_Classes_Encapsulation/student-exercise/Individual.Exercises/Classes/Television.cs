using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }
        public int CurrentVolume { get; private set; }

        public Television()
        {
            IsOn = false;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }
        public void TurnOn()  
        {
            CurrentChannel = 3;
            CurrentVolume = 2;

            if (IsOn)
            {
                IsOn = false;
            }
            else
            {
                IsOn = true;
            }
         
        }
        public void TurnOff()
        {
            if (IsOn)
            {
                IsOn = false;
            }
            else 
            {
                IsOn = true;
            }
        }
        
        public void ChangeChannel(int newChannel)
        {
            if (IsOn && CurrentChannel >= 3 && CurrentChannel <= 18)
            {
                CurrentChannel = newChannel;
            }
        }
        public void ChannelUp()
        {
            if (IsOn)
            {
                CurrentChannel += 1;

                if (CurrentChannel > 18)
                {
                    CurrentChannel = 3;
                }
            }
        }

        public void ChannelDown()
        {
            if (IsOn)
            {
                CurrentChannel -= 1;
                if (CurrentChannel < 3)
                {
                    CurrentChannel = 18;
                }
            }
        }
        public void RaiseVolume()
        {
            if (IsOn && CurrentVolume <= 10)
            {
                CurrentVolume += 1;
            }
        }
        public void LowerVolume()
        {
            if(IsOn && CurrentVolume > 0)
            {
                CurrentVolume -= 1;
            }
            return;
        }
    }
}
