using System;

namespace fooling_around
{
	class Program
	{
		static void Main(string[] args)
		{

			//helloWorldCount();
			//fowardBackCounter();
			//basicForLoopCounter();
		}

		//mit første "do-while" loop. I don't like it. 
		static void helloWorldCount()
		{

			int helloCount = 0;

			do
			{

				Console.WriteLine("Hello World!" + " - " + helloCount);
				helloCount += 1;
			} while (helloCount <= 5);
		}

		//janky lorte counter 
		static void fowardBackCounter()
		{

			int myCounter = 0;

			do
			{

				Console.WriteLine("My Count = " + myCounter);
				myCounter += 3;
				Console.WriteLine("New Count" + myCounter);
				myCounter += -2;
			} while (myCounter <= 99);
		}

		//eksempel på for loop med variable increment. Denne type loop kommer man til at skrive 1 mil gange, så det er godt at få den i fingrene
		static void basicForLoopCounter()
		{

			for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine("My --i-- count= " + i);
			}
		}
	}
}
