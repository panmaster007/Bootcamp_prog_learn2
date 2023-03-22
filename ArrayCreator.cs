// Это класс, отвечающий за создание массива
public static class ArrayCreator
{
	// Метод создания массива
	public static int[] Create(this int n)
	{
		return new int[n];
	}

	// Лепит массив в строку
	public static string ConvertToStringAndPrintToTerminal(this int[] array)
	{
		string str = $"[{String.Join(',', array)}]";
		System.Console.WriteLine(str);
		return str;
	}

	// Заполняет массив
	public static int[] Fill(this int[] array, int min = 0, int max = 10, int seed = 0)
	{
		Random random = seed == 0 ? new Random() : new Random(seed);
		return array.Select(item => random.Next(min, max)).ToArray();
	}
}