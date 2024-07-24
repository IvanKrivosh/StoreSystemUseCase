namespace StoreSystemUseCase
{
    class GoodsList : IGoodsList
    {
        private List<Cell> _cells;

        public GoodsList()
        {
            _cells = new List<Cell>();
        }

        protected IReadOnlyList<Cell> Cells => _cells;

        public void AddGood(Good good, int quantity)
        {
            VerifyGoodValue(good, quantity);

            Cell newCell = new Cell(good, quantity);
            Cell cell = GetCell(good);

            if (cell != null)
                cell.Merge(newCell);
            else
                _cells.Add(newCell);
        }

        public bool IsAvailableGood(Good good, int quantity)
        {
            VerifyGoodValue(good, quantity);

            Cell cell = GetCell(good);

            if (cell == null)
                throw new Exception("Product was not found");

            return cell.IsAvailableQuantity(quantity);
        }

        public void DecreaseGood(Good good, int quantity)
        {
            if (IsAvailableGood(good, quantity))
                GetCell(good).Decrease(quantity);
        }

        public void ShowGoodsInformation()
        {
            foreach (Cell cell in Cells)
                Console.WriteLine(cell.Information);
        }

        public Cell GetCell(Good good)
        {
            ArgumentNullException.ThrowIfNull(good);

            return _cells.Find(cell => cell.Good == good);
        }

        public void Clear()
        {
            _cells.Clear();
        }

        private void VerifyGoodValue(Good good, int quantity)
        {
            ArgumentNullException.ThrowIfNull(good);
            Utils.CompareIntGreaterZero(quantity, nameof(quantity));
        }
    }
}
