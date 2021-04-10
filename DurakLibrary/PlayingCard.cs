//using DemoCardsLibrary.Properties;
using System;
using System.Drawing;

namespace DurakLibrary
{
    public class PlayingCard : ICloneable, IComparable
    {
        protected CardSuit mySuit;
        protected CardRank myRank;
        protected int myValue;
        protected int? altValue;
        protected bool faceUp;

        public CardSuit Suit
        {
            get => this.mySuit;
            set => this.mySuit = value;
        }

        public CardRank Rank
        {
            get => this.myRank;
            set => this.myRank = value;
        }

        public int CardValue
        {
            get => this.myValue;
            set => this.myValue = value;
        }

        public int? AlternateValue
        {
            get => this.altValue;
            set => this.altValue = value;
        }

        public bool FaceUp
        {
            get => this.faceUp;
            set => this.faceUp = value;
        }

        public PlayingCard(CardRank rank = CardRank.Ace, CardSuit suit = CardSuit.Hearts)
        {
            this.myRank = rank;
            this.mySuit = suit;
            this.myValue = (int)rank;
        }

        public virtual int CompareTo(object obj)
        {
            PlayingCard playingCard = obj != null ? obj as PlayingCard : throw new ArgumentNullException("Unable to compare a Card to a null object.");
            if (playingCard != (PlayingCard)null)
                return ((int)((byte)(this.myValue * 10) + this.mySuit)).CompareTo((int)((byte)(playingCard.myValue * 10) + playingCard.mySuit));
            throw new ArgumentException("Object being compared cannot be converted to a Card.");
        }

        public object Clone() => this.MemberwiseClone();

        

        public override bool Equals(object obj) => this.CardValue == ((PlayingCard)obj).CardValue;

        public override int GetHashCode() => this.myValue * 100 + (int)this.mySuit * 10 + (this.faceUp ? 1 : 0);

        

        public string DebugString() => (this.myRank.ToString() + " of " + this.mySuit.ToString()).PadLeft(20) + (this.FaceUp ? "(Face Up)" : "(Face Down)").PadLeft(12) + " Value: " + this.myValue.ToString().PadLeft(2) + (this.altValue.HasValue ? "/" + this.altValue.ToString() : "");

        public static bool operator ==(PlayingCard left, PlayingCard right) => left.CardValue == right.CardValue;

        public static bool operator !=(PlayingCard left, PlayingCard right) => left.CardValue != right.CardValue;

        public static bool operator <(PlayingCard left, PlayingCard right) => left.CardValue < right.CardValue;

        public static bool operator <=(PlayingCard left, PlayingCard right) => left.CardValue <= right.CardValue;

        public static bool operator >(PlayingCard left, PlayingCard right) => left.CardValue > right.CardValue;

        public static bool operator >=(PlayingCard left, PlayingCard right) => left.CardValue >= right.CardValue;

        private PlayingCard(string fromString) => throw new NotImplementedException();

        public Image GetCardImage()
        {
            string imageName;
            Image cardImage;
      
            imageName = mySuit.ToString() + "_" + myRank.ToString();
            cardImage =  DurakLibrary.Properties.Resources.ResourceManager.GetObject(imageName) as Image;

            return cardImage;
        }
    }
}
