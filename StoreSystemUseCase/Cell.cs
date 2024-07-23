namespace StoreSystemUseCase
{
    class Cell
    {
        public Cell(Good good, int quantity)
        {
            ArgumentNullException.ThrowIfNull(good);
            Utils.CompareIntGreaterZero(quantity, nameof(quantity));

            Good = good;
            Quantity = quantity;
        }

        public Good Good { get; }
        public int Quantity { get; private set; }
        public string Information => $"{Good.Name}: {Quantity} шт.";

        public void Merge(Cell cell)
        {
            ArgumentNullException.ThrowIfNull(cell);

            if (Good != cell.Good)
                throw new Exception("Type of good does not match");

            Quantity += cell.Quantity;
        }

        public bool IsAvailableQuantity(int quantity)
        {
            Utils.CompareIntGreaterValue(Quantity, nameof(quantity), quantity, true);

            return true;
        }

        public void Decrease(int quantity)
        {
            if (IsAvailableQuantity(quantity))
                Quantity -= quantity;
        }
    }
}
