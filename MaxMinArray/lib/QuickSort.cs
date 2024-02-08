namespace ArrayOperations
{
    class QuickSort : sortAlgorithm
    {
        public void sort(List <int> l)
        {
            QuickSortRecursive(l, 0, l.Count - 1);
        }

        private void QuickSortRecursive(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int partitionIndex = Partition(list, left, right);

                QuickSortRecursive(list, left, partitionIndex - 1);
                QuickSortRecursive(list, partitionIndex + 1, right);
            }
        }      

        private int Partition(List<int> list, int left, int right)
        {
            int pivot = list[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (list[j] <= pivot)
                {
                    i++;

                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }

            int temp1 = list[i + 1];
            list[i + 1] = list[right];
            list[right] = temp1;

            return i + 1;
        }
    }



}
