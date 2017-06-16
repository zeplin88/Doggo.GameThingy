using System.Runtime.InteropServices;

namespace Doggo.GameThingy
{
    class Timer
    {
        private long StartTick = 0;

        [DllImport("kernel32.dll")]
        private static extern long GetTickCount();

        public Timer()
        {
            Reset();
        }

        public void Reset()
        {
            StartTick = GetTickCount();
        }

        public long GetTicks()
        {
            long currentTick = 0;
            currentTick = GetTickCount();

            return currentTick - StartTick;
        }
    }
}
