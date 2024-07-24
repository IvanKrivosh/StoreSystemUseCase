namespace StoreSystemUseCase
{
    class Cart : GoodsList
    {
        private readonly IGoodsList _storeList;

        public Cart(IGoodsList storeList)
        {
            _storeList = storeList ?? throw new ArgumentNullException();
        }

        public void Add(Good good, int quantity)
        {
            if (_storeList.IsAvailableGood(good, quantity))
                AddGood(good, quantity);
        }

        public Order Order()
        {
            foreach (Cell cell in Cells)
                _storeList.DecreaseGood(cell.Good, cell.Quantity);

            Clear();

            return new Order("paylink");
        }
    }
}
