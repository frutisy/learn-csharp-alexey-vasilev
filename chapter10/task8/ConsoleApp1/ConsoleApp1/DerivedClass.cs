using System;

namespace Classes
{
    class DerivedClass : BaseClass
    {
        public int IntValue2 { get; set; }

        public override int this[int digitPosition]
        {
            get
            {
                int sum = IntValue1 + IntValue2;

                if (digitPosition < 0)
                    throw new ArgumentOutOfRangeException("Позиция цифры не может быть отрицательной!");

                string numberAsString = sum.ToString();
                if (digitPosition < numberAsString.Length)
                    return int.Parse(numberAsString[digitPosition].ToString());
                else
                    return 0;
            }
        }

        public int this[int fieldIndex, int digitPosition]
        {
            get
            {
                int value = 0;

                if (fieldIndex == 0)
                    value = IntValue1;
                else if (fieldIndex == 1)
                    value = IntValue2;

                if (digitPosition < 0)
                    throw new ArgumentOutOfRangeException("Позиция цифры не может быть отрицательной!");

                string numberAsString = value.ToString();
                if (digitPosition < numberAsString.Length)
                    return int.Parse(numberAsString[digitPosition].ToString());
                else
                    return 0;
            }
        }
    }
}
