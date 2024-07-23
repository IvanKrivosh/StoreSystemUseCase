namespace StoreSystemUseCase
{
    class Utils
    {
        public static void CompareIntGreaterValue(int value, string name, int targetValue, bool canBeEqual = false)
        {
            if (value < targetValue || (!canBeEqual && value == targetValue))
                throw new ArgumentOutOfRangeException(name);
        }

        public static void CompareIntGreaterZero(int value, string name)
        {
            CompareIntGreaterValue(value, name, 0);
        }
    }
}
