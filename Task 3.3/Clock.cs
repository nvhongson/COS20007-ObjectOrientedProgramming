using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class Clock
    {
        Counter _second = new Counter("second");
        Counter _minute = new Counter("minute");
        Counter _hour = new Counter("hour");


        public void Tick()
        {
            _second.Increment();
            if (_second.Tick > 59)
            {
                _minute.Increment();
                _second.Reset();
                if (_minute.Tick > 59)
                {
                    _hour.Increment();
                    _minute.Reset();
                    if (_hour.Tick > 23)
                    {
                        Reset();
                    }
                }
            }
        }

        public void SetTime(string s)
        {
            string[] array = s.Split(":");

            _hour = new Counter("hour", int.Parse(array[0]));
            _minute = new Counter("minute", int.Parse(array[1]));
            _second = new Counter("second", int.Parse(array[2]));
        }

        public void Reset()
        {
            _second.Reset();
            _minute.Reset();
            _hour.Reset();
        }

        public string CurrentTime()
        {
            return $"{_hour.Tick:D2}:{_minute.Tick:D2}:{_second.Tick:D2}";
        }
    }
}

