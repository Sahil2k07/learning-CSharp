namespace AsyncProgramming
{
    public class MultiThreading
    {
        private static void PrintNumbers()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + " ");

                Thread.Sleep(500);
            }

            Console.WriteLine();
        }

        private static void PrintNumbersPool(object? state)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write(i + " ");

                Thread.Sleep(500);
            }

            Console.WriteLine();
        }

        private static async Task PrintNumbersAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
                await Task.Delay(500); // Simulate work
            }

            Console.WriteLine();
        }

        private static readonly object lockObject = new(); // thread safe Object
        private static int counter = 0;

        private static void IncrementCounter()
        {
            for (int i = 0; i < 100; i++)
            {
                lock (lockObject) // Only one thread can enter this block
                {
                    counter++;
                }
            }
        }

        private static void Syncronization()
        {
            Thread t1 = new(IncrementCounter);
            Thread t2 = new(IncrementCounter);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine(
                $"Both the Syncronization Threads finished and the counter value is {counter}"
            );
        }

        public static void ShowMultiThreading()
        {
            // Manual Management
            Thread thread = new(PrintNumbers);

            // Start the thread
            thread.Start();
            // Wait for the thread to finish
            thread.Join();

            Console.WriteLine("Thread execution finished");

            Syncronization();

            // await Task.Run(PrintNumbersAsync); // We can also use Task making the method async

            Task task = PrintNumbersAsync();
            task.Wait();

            Mutex();

            // Automatic Management | Best Practice | Avoids RaceCase | Perform only Background Work
            // ThreadPool.QueueUserWorkItem(PrintNumbersPool);
        }

        // Mutex prevents other thereads to access any functinoal block to avoid race conditions
        private static readonly Mutex mutex = new();

        static void AccessResource()
        {
            mutex.WaitOne(); // Acquire the mutex

            Console.WriteLine(
                $"Thread {Environment.CurrentManagedThreadId} is accessing the resource."
            );

            Thread.Sleep(1000); // Simulate work

            mutex.ReleaseMutex(); // Release the mutex
        }

        static void Mutex()
        {
            Thread t1 = new(AccessResource);
            Thread t2 = new(AccessResource);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }
    }
}
