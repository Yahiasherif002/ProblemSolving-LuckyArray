internal class Program
{
    static void freqArray(int[] array)
    {
       
        int count = 0;
        int max=int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < max) 
            max = array[i];

        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
                count++;
        }   
        if(count%2 != 0)
            Console.WriteLine("Lucky");
        else
            Console.WriteLine("Unlucky");
    }
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (int.TryParse(inputArray[i], out int value))
            {
                array[i] = value;
            }
            else
            {
                Console.WriteLine($"Invalid input: '{inputArray[i]}' is not a valid integer.");
                return;
            }
        }
        freqArray(array);

    }
}