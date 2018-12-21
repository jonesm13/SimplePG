namespace SimplePG.Domain.ValueTypes
{
    using System;

    public class StockUnits
    {
        readonly int value;

        public StockUnits(int value)
        {
            if(value < 0)
            {
                throw new ArgumentException("value must be a non-negative number.");
            }

            this.value = value;
        }

        public static implicit operator int(StockUnits value)
        {
            return value.value;
        }

        public static implicit operator StockUnits(int value)
        {
            return new StockUnits(value);
        }
    }
}
