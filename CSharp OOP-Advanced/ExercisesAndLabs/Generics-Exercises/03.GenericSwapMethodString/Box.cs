namespace _03.GenericSwapMethodString
{
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        private List<T> elements;

        public Box()
        {
            this.elements = new List<T>();
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var temp = this.elements[firstIndex];
            this.elements[firstIndex] = this.elements[secondIndex];
            this.elements[secondIndex] = temp;
        }

        public string Print()
        {
            var sb = new StringBuilder();

            foreach (var element in this.elements)
            {
                sb.AppendLine($"{element.GetType().FullName}: {element.ToString()}");
            }

            return sb.ToString().Trim();
        }
    }
}