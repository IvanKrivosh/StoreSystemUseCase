namespace StoreSystemUseCase
{
    class Cart : GoodsList
    {
        private readonly Shop _shop;

        public Cart(Shop shop)
        {   
            _shop = shop ?? throw new ArgumentNullException();
        }

        public void Add(Good good, int quantity)
        {
            if (_shop.IsAvailableGood(good, quantity))
                AddGood(good, quantity);
        }

        public Order Order()
        {
            foreach (Cell cell in Cells)
                _shop.DecreaseGood(cell.Good, cell.Quantity);

            Clear();

            return new Order("paylink");
        }
    }
}
