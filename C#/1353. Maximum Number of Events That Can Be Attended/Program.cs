public class Program
{
    public static void Main(string[] args)
    {
        int[][] a = new int[][] { [1, 2], [2, 3], [3, 4], [1, 2]  };
        System.Console.WriteLine(Solution.MaxEvents(a));
    }
}


public class Solution
{
    public static int MaxEvents(int[][] events)
    {
        Array.Sort(events, (a, b) => {
            if (a[0] != b[0]) return a[0].CompareTo(b[0]);
            return a[1].CompareTo(b[1]);
        });

        var priorityQueue = new PriorityQueue<int[], int>();
        int count = 0;
        int eventIndex = 0; // Индекс для перебора отсортированных мероприятий
        int n = events.Length;


        for (int day = 1; day <= 100000; day++)
        {
            // 1. Добавляем все мероприятия, которые начинаются В ТЕКУЩИЙ ДЕНЬ, в кучу.
            while (eventIndex < n && events[eventIndex][0] == day)
            {
                priorityQueue.Enqueue(events[eventIndex], events[eventIndex][1]);
                eventIndex++;
            }

            // 2. Удаляем все мероприятия из кучи, которые УЖЕ ЗАКОНЧИЛИСЬ к текущему дню.
            // Их endDay меньше, чем текущий день.
            while (priorityQueue.Count > 0 && priorityQueue.Peek()[1] < day)
            {
                priorityQueue.Dequeue();
            }

            // 3. Если в куче есть доступные мероприятия, посещаем то, у которого самый ранний endDay.
            if (priorityQueue.Count > 0)
            {
                priorityQueue.Dequeue();
                count++;
            }

            // Оптимизация: Если все мероприятия уже рассмотрены и куча пуста,
            // можно прервать цикл, так как больше нечего посещать.
            if (eventIndex == n && priorityQueue.Count == 0)
            {
                break;
            }
        }
        return count;
    }
}