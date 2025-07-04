//First C# Project By Me, SLOMA ADEL
namespace TaskTracker
{
    internal class Program
    {
        static readonly string[] Tasks = new string[100];
        static int TaskIndex = 0;

        static void Main(string[] args) //MAIN
        {
            Console.WriteLine("\nWelcome to your Task Tracker. Your guide to building a successful lifestyle. ");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

        sloma:
            Console.WriteLine("Enter a number from 1 to 5");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. View all tasks");
            Console.WriteLine("3. Mark task completed");
            Console.WriteLine("4. Remove task");
            Console.WriteLine("5. Exit");

            string UserCommand = Console.ReadLine()!;

            switch (UserCommand)
            {
                case "1": //Add task
                    AddTask();
                    break;

                case "2"://View all tasks
                    ViewTasks();
                    break;

                case "3"://Mark task completed
                    MarkTaskCompleted();
                    break;

                case "4"://Remove Task
                    RemoveTask();
                    break;

                case "5"://Exit
                    Console.WriteLine("Thanks for using Task Tracker! ♥");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid number. Please enter a number between 1 to 5");
                    break;
            }
        goto sloma;
        }

        private static void AddTask()
        {
            Console.WriteLine("Enter task title:");
            string TaskTitle = Console.ReadLine()!;
            Tasks[TaskIndex] = TaskTitle;
            TaskIndex++;
            Console.WriteLine("Task added!\n");
        }

        private static void ViewTasks()
        {
            Console.WriteLine("\nTasks list:");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            for (int i = 0; i < TaskIndex; i++)
            {
                Console.WriteLine($"{i+1}. {Tasks[i]}");
            }
            Console.WriteLine("\n");
        }

        private static void MarkTaskCompleted()
        {
            Console.WriteLine("Enter task number to mark as completed");

            string TaskNumber = Console.ReadLine()!;
            int TaskId = Convert.ToInt32(TaskNumber);

            Tasks[TaskId - 1] = "☻☻ ~~~" + Tasks[TaskId - 1] + "~~~ ☻☻";
            Console.WriteLine("Congrates for completing the task!\n");
        }

        private static void RemoveTask()
        {
            Console.WriteLine("Enter task number you want to remove");

            string TaskNumber = Console.ReadLine()!;
            int TaskId = Convert.ToInt32(TaskNumber);

            Tasks[TaskId - 1] = String.Empty;
            Console.WriteLine("Task removed successfully!\n");
        }
    }
}