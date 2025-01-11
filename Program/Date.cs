namespace Program
{
    #region Q2
    //2.Develop a Class to represent the Hiring Date Data:
    //•	Consisting of fields to hold the day, month and Years.

    #endregion
    internal class Date
    {
        #region Attributes
        private byte day;
        private byte month;
        private ushort year;

        #endregion

        #region Properties
        public byte Day
        {
            get { return day; }
            set
            {
                if (IsValidDate(value, Month, Year))
                    day = value;
                else
                    Console.WriteLine($"can't assign {value} as Day in {value}/{Month}/{Year}");
            }
        }
        public byte Month
        {
            get { return month; }
            set
            {
                if (IsValidDate(Day, value, Year))
                    month = value;
                else
                    Console.WriteLine($"can't assign {value} as Month in {Day}/{value}/{Year}");
            }
        }
        public ushort Year
        {
            get { return year; }
            set
            {
                if (IsValidDate(Day, Month, value))
                    year = value;
                else
                    Console.WriteLine($"can't assign {value} as Year in {Day}/{Month}/{value}");

            }
        }
        #endregion

        #region Methods
        #region Private
        private bool IsALeapYear(ushort _Year)
        {
            return (_Year % 4 == 0 && _Year % 100 != 0);
        }

        private byte DaysInMonth(byte _Month, ushort _Year)
        {
            // if _Month or _Year <=0 must throw exeption...
            switch (_Month)
            {
                case 4: case 6: case 9: case 11: return 30;
                case 3: return IsALeapYear(_Year) ? (byte)29 : (byte)28;
                default: return 31;
            }
        }

        private bool IsValidDate(byte _Day, byte _Month, ushort _Year)
        {
            if (_Day <= 0 || _Day > DaysInMonth(_Month, _Year)) return false;
            if (_Month <= 0 || _Month > 12) return false;
            if (_Year <= 0) return false;
            return true;
        }

        private bool IsValidDate()
        {
            return IsValidDate(Day, Month, Year);
        }

        private bool SetAll(byte _Day, byte _Month, ushort _Year)
        {
            if (IsValidDate(_Day, _Month, _Year))
            {
                day = _Day;
                month = _Month;
                year = _Year;
                return true;
            }
            else
                return false;
        }
        #endregion

        #region Constractors
        public Date(byte _Day, byte _Month, ushort _Year)
        {
            if (false == SetAll(_Day, _Month, _Year))
                Console.WriteLine("Invalid Date");
        }
        #endregion

        #region Public
        public override string ToString()
        {
            if (IsValidDate())
                return $"{Day}/{Month}/{Year}";
            else
                return "Sorry there is Invalid Date";
        }
        #endregion
        #endregion


    }
}
