
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

        public static string GetFirstDuplicate(string[] array1) 
        { 
            string result = string.Empty;
            Dictionary<string, bool> hashTable = new Dictionary<string, bool>();

            foreach (string s in array1)
            {
                if (hashTable.ContainsKey(s))
                {
                    return s;
                }

                hashTable[s] = true;
            }

            return result;
        }

        public static string GetMissingLetter(string sentence)
        {
            string result = string.Empty;
            Dictionary<char, bool> sentenceDictionary = new Dictionary<char, bool>();

            foreach (char c in sentence)
            {
                sentenceDictionary[c] = true;
            }

            for (int i=0; i<26; i++)
            {
                char letter = (Convert.ToChar(i + 97));

                if (sentenceDictionary.ContainsKey(letter) == false)
                    return letter.ToString();
            }

            return result;
        }

        public static string GetFirstNondupedLetter(string word)
        {
            string result = string.Empty;

            return result;
        }
    }
}
