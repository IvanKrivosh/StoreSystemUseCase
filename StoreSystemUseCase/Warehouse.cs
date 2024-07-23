namespace StoreSystemUseCase
{
    internal class Warehouse : GoodsList
    {
        public void Delive(Good good, int quantity)
        {
            AddGood(good, quantity);
        }
    }
}
