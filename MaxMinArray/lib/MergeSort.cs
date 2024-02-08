namespace ArrayOperations
{
    class MergeSort : sortAlgorithm
    {
        public void sort(List<int> list)
        {
            if (list.Count <= 1)
                return;

            int middle = list.Count / 2;
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < middle; i++)
            {
                left.Add(list[i]);
            }
            for (int i = middle; i < list.Count; i++)
            {
                right.Add(list[i]);
            }

            sort(left);
            sort(right);
            merge(left, right, list);
        }

        private void merge(List<int> left, List<int> right, List<int> merged)
        {
            int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    merged[mergedIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    merged[mergedIndex] = right[rightIndex];
                    rightIndex++;
                }
                mergedIndex++;
            }

            while (leftIndex < left.Count)
            {
                merged[mergedIndex] = left[leftIndex];
                leftIndex++;
                mergedIndex++;
            }

            while (rightIndex < right.Count)
            {
                merged[mergedIndex] = right[rightIndex];
                rightIndex++;
                mergedIndex++;
            }
        }
    }



}
