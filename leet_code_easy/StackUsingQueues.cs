using System.Collections.Generic;

namespace leet_code_easy
{
    public class StackUsingQueues
    {
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();
    
        public void Push(int x) {
            q2.Enqueue(x);

            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Peek());
                q1.Dequeue();
            }
            
            Queue<int> temp = new Queue<int>();
            q1 = q2;
            q2 = temp;
        }
    
        public int Pop() {
            if (q1.Count == 0)
            {
                return 0;
            }
            return q1.Dequeue();
        
        }
    
        public int Top() {
            if (q1.Count == 0)
            {
                return -1;
            }
            return q1.Peek();
        }
    
        public bool Empty() {
            if (q1.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}