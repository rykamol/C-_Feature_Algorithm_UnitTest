namespace Linear_Search
{
    public class LinearSearch
    {
        public int Linear_Search(int[] arr, int numberOfElement, int toFindNumber)
        {
            for (int i = 0; i < numberOfElement - 1; i++)
            {
                if (toFindNumber == arr[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
