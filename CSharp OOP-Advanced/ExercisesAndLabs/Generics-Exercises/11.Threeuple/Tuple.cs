namespace _11.Threeuple
{
    public class CustomTuple<T, U, K>
    {
        public CustomTuple(T itemOne, U ItemTwo,K ItemThree)
        {
            this.ItemOne = itemOne;
            this.ItemTwo = ItemTwo;
            this.ItemThree = ItemThree;
        }

        public T ItemOne { get; protected set; }
        public U ItemTwo { get; protected set; }
        public K ItemThree { get; protected set; }

        public override string ToString()
        {
            return $"{this.ItemOne} -> {this.ItemTwo} -> {this.ItemThree}";
        }
    }
}