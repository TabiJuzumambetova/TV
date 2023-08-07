using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV
{
    class TV
    {
        private int currentChannel;
        private int channelLimit;

        public TV(int currentChannel, int channelLimit)
        {
            this.currentChannel = currentChannel;
            this.channelLimit = channelLimit;
        }

        public void NextChannel()
        {
            currentChannel = (currentChannel % channelLimit) + 1;
        }

        public void PreviousChannel()
        {
            currentChannel = (currentChannel - 2 + channelLimit) % channelLimit + 1;
        }

        public void MoveToChannel(int channel)
        {
            if (channel > 0 && channel <= channelLimit)
            {
                currentChannel = channel;
            }
            else
            {
                Console.WriteLine("Канал с указанным номером не существует.");
            }
        }

        public void ShowCurrentChannel()
        {
            Console.WriteLine("Текущий канал: " + currentChannel);
        }
    }
}
