namespace _03_08.Cards
{
    using System;

    public class Card : IComparable<Card>
    {
        private CardRank rank;
        private CardSuit suit;

        public Card(CardSuit suit,CardRank rank)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public int Power
        {
            get { return (int)this.rank + (int)this.suit; }
        }

        public CardSuit Suit
        {
            get
            {
                return this.suit;
            }
            set { this.suit = value; }
        }

        public CardRank Rank
        {
            get { return this.rank; }
            set { this.rank = value; }
        }

        public int CompareTo(Card other)
        {
            return this.Power.CompareTo(other.Power);
        }

        public override string ToString()
        {
            return $"{this.Rank} of {this.Suit}";
        }
    }
}