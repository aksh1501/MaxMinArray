namespace ArrayOperations
{
    class Sorter
    {
        private sortAlgorithm sortAlgo;

        public Sorter(sortAlgorithm algorithm)
        {
            sortAlgo=algorithm;
        }

        public void Sort(List <int> l)
        {
            sortAlgo.sort(l);
        }
        
        public int computeMax(List <int> l)
        {
            if(l.Count!=0)
            {
                return l[l.Count-1];
            }

            return -1;
        }

        public int computeMin(List <int> l)
        {
            if(l.Count!=0)
            {
                return l[0];
            }

            return -1;
        }

        public int LowerBoundIndex(List<int> l, int value)
        {
            int left = 0;
            int right = l.Count;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (l[mid] >= value)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }



        public int UpperBoundIndex(List<int> list, int target)
        {
            int left = 0;
            int right = list.Count;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (list[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left - 1;
        }
    }

}
