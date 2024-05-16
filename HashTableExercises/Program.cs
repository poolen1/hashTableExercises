using HashTableExercises;

Console.WriteLine("===================================");
Console.WriteLine("Intersection of arrays: ");

int[] array1 = [1, 2, 3, 4, 5];
int[] array2 = [0, 2, 4, 6, 8];

List<int> intersectionResult = Hashtables.GetIntersection(array1, array2);

Console.WriteLine(String.Join(", ", intersectionResult));
Console.WriteLine("===================================");
Console.WriteLine("First duplicate from string array: ");

string[] stringArray = ["a", "b", "c", "d", "c", "e", "f"];
string result = Hashtables.GetFirstDuplicate(stringArray);

if (result == string.Empty)
{
    Console.WriteLine("No duplicate strings found.");
}
else
{
    Console.WriteLine("First duplicate: " + result);
}

Console.WriteLine("===================================");
Console.WriteLine("Get missing letter: ");

string sentence = "the quick brown box jumps over a lazy dog";
result = Hashtables.GetMissingLetter(sentence);

if (result == string.Empty)
{
    Console.WriteLine("All letters are included.");
}
else
{
    Console.WriteLine("Missing letter: " + result);
}

Console.WriteLine("===================================");
Console.WriteLine("First non-duplicated letter: ");

string word = "minimum";
result = Hashtables.GetFirstNondupedLetter(word);

if (result == string.Empty)
{
    Console.WriteLine("All letters in word are duplicated.");
}
else
{
    Console.WriteLine("Letter: " + result);
}

Console.WriteLine("===================================");
Console.Read();