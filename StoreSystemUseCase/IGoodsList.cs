namespace StoreSystemUseCase
{
    interface IGoodsList
    {
        public bool IsAvailableGood(Good good, int quantity);

        public void DecreaseGood(Good good, int quantity);
    }
}
