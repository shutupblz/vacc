using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace vacc
{
    class PriorityQueue<User> where User:IComparable
    {
        public List<User> list;
        public int Count { get { return list.Count; } }
        public readonly bool IsDescending;
        public PriorityQueue() {
            list = new List<User>();

        }
        public PriorityQueue(bool isdesc) : this() {
            IsDescending = isdesc;
        }
        public PriorityQueue(IEnumerable<User> collection, bool isdesc) : this() {
            IsDescending = isdesc;
            foreach (var item in collection)
                Enqueue(item);
        }

        public void Enqueue(User userI) {
            list.Add(userI);
            int i = Count - 1;
            while (i > 0)
            {
                int p = (i - 1) / 2;
                if ((IsDescending ? -1 : 1) * list[p].CompareTo(userI) <= 0) break;
                list[i] = list[p];
               
            }
            if (Count > 0)
                list[i] = userI;
        }

        public User Dequeue() {
           
            User target = Peek();
            User root = list[Count - 1];
            list.RemoveAt(Count - 1);

            int i = 0;
            while (i * 2 + 1 < Count) {
                int a = i * 2 + 1;
                int b = i * 2 + 2;
                int c = b < Count && (IsDescending ? -1 : 1) * list[b].CompareTo(list[a]) < 0 ? b : a;
                
                
                if ((IsDescending ? -1 : 1) * list[c].CompareTo(root) >= 0) break;
                list[i] = list[c];
                i = c;

              

            }
            if (Count > 0)
                list[i] = root;

            
            return target;
        }
        public User Peek() {
            if (Count == 0)
            {
                
                throw new InvalidOperationException("Queue is empty.");
                return list[0];
            }
            return list[0];
        }
    }
    
}
