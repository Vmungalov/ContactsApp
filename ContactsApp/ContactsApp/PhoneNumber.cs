using System;

namespace ContactsAppUI.Properties
{
    public class PhoneNumber
    {
        private long _Number;

        public long GetNumber()
        {
            return _Number;
        }

        public void SetNumber(long Number)
        {
            if ((Number < 10000000000) || (Number > 79999999999))
            {
                throw new ArgumentException("Номер телефона должен содержать 11 цифр");
            }
            else if (Number / 10000000000 !=7)
            {
                throw new ArgumentException("Номер телефона должен начинаться с 7");
            }
            else
            {
                _Number = Number;
            }
        }
    }
}