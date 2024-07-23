namespace StoreSystemUseCase
{
    internal class Shop
    {
        private readonly Warehouse _warehouse;

        public Shop(Warehouse warehouse)
        {   
            _warehouse = warehouse ?? throw new ArgumentNullException();
        }

        public Cart Cart()
        {
            return new Cart(this);
        }

        public bool IsAvailableGood(Good good, int quantity)
        {
            return _warehouse.IsAvailableGood(good, quantity);
        }

        public void DecreaseGood(Good good, int quantity)
        {
            _warehouse.Decrease(good, quantity);
        }
    }
}
