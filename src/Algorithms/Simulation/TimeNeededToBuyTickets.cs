namespace Algorithms.Simulation
{
    /// <summary>
    /// There are n people in a line queuing to buy tickets, where the 0th person is at the front of the line and the (n - 1)th person is at the back of the line.
    /// You are given a 0-indexed integer array tickets of length n where the number of tickets that the ith person would like to buy is tickets[i].
    /// Each person takes exactly 1 second to buy a ticket.A person can only buy 1 ticket at a time and has to go back to the end of the line(which happens instantaneously) in order to buy more tickets.If a person does not have any tickets left to buy, the person will leave the line.
    /// Return the time taken for the person at position k (0-indexed) to finish buying tickets.
    /// </summary>
    public static class TimeNeededToBuyTickets
    {
        public static int TimeRequiredToBuyExample0(int[] tickets, int k)
        {
            int seconds = 0;

            while (tickets[k] > 0)
            {
                for (int i = 0; i < tickets.Length && tickets[k] > 0; i++)
                {
                    if (k == i && tickets[i] == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (tickets[i] > 0)
                        {
                            tickets[i]--;
                            seconds++;
                        }
                    }
                }
            }

            return seconds;
        }

        // Simulation Using Queue
        public static int TimeRequiredToBuyExample1(int[] tickets, int k)
        {
            Queue<int> queue = new Queue<int>();

            // Initialize the queue with ticket indices
            for (int i = 0; i < tickets.Length; i++)
            {
                queue.Enqueue(i);
            }

            int time = 0;

            // Loop until the queue is empty
            while (queue.Count != 0)
            {
                // Increment the time counter for each iteration
                time++;

                // Get the front element of the queue
                int front = queue.Dequeue();

                // Buy a ticket for the front person
                tickets[front]--;

                // If person k bought all their tickets, return time
                if (k == front && tickets[front] == 0)
                {
                    return time;
                }

                // Re-add the current index to the queue for the next iteration
                if (tickets[front] != 0)
                {
                    queue.Enqueue(front);
                }
            }

            return time;
        }

        // Simulation Without Queue
        public static int TimeRequiredToBuyExample2(int[] tickets, int k)
        {
            int n = tickets.Length;
            int time = 0;

            // If person k only needs one ticket, return the time to buy it
            if (tickets[k] == 1)
                return k + 1;

            // Continue buying tickets until person k buys all their tickets
            while (tickets[k] > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    // Buy a ticket at index 'i' if available
                    if (tickets[i] != 0)
                    {
                        tickets[i]--;
                        time++;
                    }

                    // If person k bought all their tickets, return the time
                    if (tickets[k] == 0)
                        return time;
                }
            }

            return time;
        }

        // Using One Pass
        public static int TimeRequiredToBuyExample3(int[] tickets, int k)
        {
            int time = 0;

            for (int i = 0; i < tickets.Length; i++)
            {
                // If the current person is before or at the desired person 'k'
                if (i <= k)
                {
                    // Buy the minimum of tickets available at person 'k' and the current person
                    time += Math.Min(tickets[k], tickets[i]);
                }
                else
                {
                    // If the current person is after 'k', buy the minimum of 
                    // (tickets available at person 'k' - 1) and the current person
                    time += Math.Min(tickets[k] - 1, tickets[i]);
                }
            }

            return time;
        }
    }
}