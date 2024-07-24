namespace StoreSystemUseCase
{
    class Shop
    {
        private readonly Warehouse _warehouse;

        public Shop(Warehouse warehouse)
        {   
            _warehouse = warehouse ?? throw new ArgumentNullException();
        }

        public Cart Cart()
        {
            return new Cart(_warehouse);
        }
    }
}
