class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите массив через запятую:");
        string input = Console.ReadLine();

        string[] originalArray = input.Split(',');

        string[] newArray = FilterStrings(originalArray);

        Console.WriteLine("Новый массив:");
        foreach (string str in newArray)
        {
            Console.Write(str + ", ");
        }
    }
    static string[] FilterStrings(string[] originalArray)
    {
        int count = 0;
        foreach (string str in originalArray)
        {
            if (str.Trim().Length <= 3) 
            {
                count++;
            }
        }

        string[] newArray = new string[count];

        int index = 0;
        foreach (string str in originalArray)
        {
            if (str.Trim().Length <= 3)
            {
                newArray[index] = str.Trim();
                index++;
            }
        }

        return newArray;
    }
}