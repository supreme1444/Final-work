public class ProgramSeminar
{
    public static void Main()
    {
          string[] arr = new string[5];
        int m = 3;
        for (int i = 0; i <= arr.Count() - 1; i++)
        {
            arr[i] = Console.ReadLine();
        }
        mass (arr, m);


    }

     public static void mass(string[] arr, int m)
    {
         for (int i = 0; i <= arr.Count() - 1; i++)
        {
            if (arr[i].Length < m)
            {
                Console.Write ($"{arr[i]}  ");
            }

        }

    }



}