namespace StoreSystemUseCase
{
    class Warehouse : GoodsList
    {
        public void Delive(Good good, int quantity)
        {
            AddGood(good, quantity);
        }
    }
}
