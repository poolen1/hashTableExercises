using HashTableExercises;

Console.WriteLine("Intersection of arrays: ");

int[] array1 = { 1, 2, 3, 4, 5 };
int[] array2 = { 0, 2, 4, 6, 8 };

List<int> intersectionResult = Hashtables.GetIntersection(array1, array2);

Console.WriteLine(String.Join(", ", intersectionResult));

Console.Read();