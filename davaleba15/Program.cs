

//1 
static int GetElementIndex(int[] array, int index)
{
    try
    {
        return array[index];
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Unavailable index");
        return -1;
    }
}

//2
static int GetStringLength(string text)
    {
        try
        {
            return text.Length;
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Enter text");
            return -1;
        }
    }



/////////////////////////////////////////////////
int[] numbers = { 10, 20, 30 };
int result1 = GetElementIndex(numbers, 1);
Console.WriteLine($"Element at index 1: {result1}");

int result2 = GetElementIndex(numbers, 5);
Console.WriteLine($"element at index 5: {result2}");

Console.WriteLine();
/////////////////////////////////////////////////////

string input1 = "Hello";
int length1 = GetStringLength(input1); 
Console.WriteLine($"text length: {length1}");

string input2 = null;
int length2 = GetStringLength(input2);
Console.WriteLine($"text length: {length2}");
/////////////////////////////////////////////////////
   

 
