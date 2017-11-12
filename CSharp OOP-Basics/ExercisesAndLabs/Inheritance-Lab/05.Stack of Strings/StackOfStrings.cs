namespace _05.Stack_of_Strings
{
    using System.Collections.Generic;
    using System.Linq;

    public class StackOfStrings
    {
        private List<string> data;

        public StackOfStrings()
        {
            this.data = new List<string>();
        }

        public void Push(string item)
        {
            this.data.Add(item);
        }

        public string Pop()
        {
            var lastElement = this.data.LastOrDefault();
            this.data.Remove(lastElement);
            return lastElement;
        }

        public string Peek()
        {
            return this.data.LastOrDefault();
        }

        public bool IsEmpty()
        {
            if (this.data.Any())
            {
                return true;
            }

            return false;
        }
    }
}