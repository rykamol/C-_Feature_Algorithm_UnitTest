namespace Binary_Search
{
    public class Binary
    {
        public int SearchNumber(int[] arr, int numberOfElement, int toSearchNumber)
        {
            int left, right, mid;

            left = 0;
            right = numberOfElement - 1;

            while (left <= right)
            {
                mid = (left + right) / 2;

                if (arr[mid] == toSearchNumber)
                    return mid;

                if (arr[mid] < toSearchNumber)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
