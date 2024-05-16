
namespace HashTableExercises
{
    public class Hashtables
    {
        public static List<int> GetIntersection(int[] array1, int[] array2)
        {
            List<int> intersection = new List<int>();
            Dictionary<int, bool> hashTable = [];

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
            Dictionary<string, bool> hashTable = [];

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
            Dictionary<char, bool> sentenceDictionary = [];

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
            Dictionary<char, int> charRepetitions = [];

            foreach (char c in word)
            {
                if (charRepetitions.ContainsKey(c) == false)
                {
                    charRepetitions.Add(c, 1);
                }
                else
                {
                    charRepetitions[c] += 1;
                }
            }

            foreach (var item in charRepetitions)
            {
                if (item.Value == 1)
                    return item.Key.ToString();
            }

            return result;
        }
    }
}
