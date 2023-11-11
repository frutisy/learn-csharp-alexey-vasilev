using System;

namespace Classes
{
    class BaseClass
    {
        public int IntValue1 { get; set; }

        public virtual int this[int digitPosition]
        {
            get 
            { 
                if (digitPosition < 0)
                {
                    throw new IndexOutOfRangeException("Позиция цифры не может быть отрицательной!");
                }

                string numberAsString = IntValue1.ToString();
                if (digitPosition < numberAsString.Length)
                    return int.Parse(numberAsString[digitPosition].ToString());
                else
                    return 0;
            } 
        }
    }
}
