using System;

namespace Binary_search
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();

			Console.Write("Напишите размер массива:");
			int massiveLength = Convert.ToInt32(Console.ReadLine());

			int[] randomMassive = new int[massiveLength];
			int randomNumber;
			int guessedValue = 0;

			double stepsCount = Math.Ceiling(Math.Log(randomMassive.Length,2));
			Console.WriteLine($"В худшем случае понадобится {stepsCount} попыток с использованием бинарного поиска, что бы найти значение.");

			for (int i = 1; i < randomMassive.Length; i++)
			{
				randomMassive[i] = i;
				//Console.WriteLine(randomMassive[i]);
			}

			randomNumber = randomMassive[random.Next(1, randomMassive.Length)];
			
			BinarySearch(randomMassive, randomNumber, guessedValue);		

			Console.ReadKey();
		}

		static void BinarySearch(int[] randomMassive, int randomNumber, int guessedValue)
		{
			int low = 0;
			int high = (randomMassive.Length - 1);
			int mid;

			while (low < high)
			{
				mid = (low + high) / 2;
				guessedValue = randomMassive[mid];
				Console.WriteLine(guessedValue);

				if (guessedValue == randomNumber)
				{
					Console.WriteLine("Число найдено.");
					high = low;
				}
				else if (guessedValue > randomNumber)
				{
					Console.WriteLine("Загаданное число меньше, чем это.");
					high = mid;
				}
				else if (guessedValue < randomNumber)
				{
					Console.WriteLine("Заданное число больше, чем это.");
					low = mid;
				}
				else
				{
					Console.WriteLine("Что-то пошло не так!");				
				}
			}
		}
		static void TraditionalSearch(int[] randomMassive, int randomNumber)
		{
			for(int i = 0; i < randomMassive.Length - 1; i++)
			{
				if (randomMassive[i] == randomNumber)
				{
					Console.WriteLine("Число угадано.");
					break;
				}
				else
				{
					continue;
				}
			}
		}
	}
}
