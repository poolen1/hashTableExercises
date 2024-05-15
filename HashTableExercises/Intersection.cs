
namespace HashTableExercises
{
    public class Hashtables
    {
        public static List<int> GetIntersection(int[] array1, int[] array2)
        {
            List<int> intersection = new List<int>();
            Dictionary<int, bool> hashTable = new Dictionary<int, bool>();

            foreach (int i in array1)
            {
                hashTable[i] = true;
            }

            foreach (int i in array2)
            {
                if (hashTable.ContainsKey(i))
                {
                    intersection.Add(i);
                }
            }

            return intersection;
        }
    }
}
