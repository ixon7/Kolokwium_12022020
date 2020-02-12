using System;

namespace Kolokwium_12022020
{
    public class DataTime
    {
        public DataTime(int rok, int mies, int day)
        {
            Rok = rok;
            Mies = mies;
            Day = day;
        }

        public int Rok { get; set; }
        public int Mies { get; set; }
        public int Day { get; set; }

        public static implicit operator DataTime(DateTime v)
        {
            throw new NotImplementedException();
        }
    }
}