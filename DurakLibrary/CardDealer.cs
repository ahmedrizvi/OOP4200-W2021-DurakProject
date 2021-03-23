using System;
using System.Collections;
using System.Diagnostics;

namespace DurakLibrary
{
    public class CardDealer : CollectionBase, ICloneable
    {
        protected Deck myDeck;
        protected int myNumberOfDecks;
        protected int redCardPosition;

        public int NumberOfDecks => this.myNumberOfDecks;

        public bool Empty => this.List.Count == 0;

        public int CardsRemaining => this.List.Count;

        public bool HasReachedRedCard => this.redCardPosition >= this.List.Count;

        public CardDealer(Deck deck, int numberOfDecks = 1, bool shuffled = true)
        {
            this.myDeck = deck;
            this.myNumberOfDecks = numberOfDecks;
            this.LoadCardDealer(shuffled);
            this.redCardPosition = (int)((double)this.List.Count * 0.25);
        }

        public CardDealer(CardDealer copyFrom)
        {
            this.myNumberOfDecks = copyFrom.myNumberOfDecks;
            this.redCardPosition = copyFrom.redCardPosition;
            this.myDeck = (Deck)copyFrom.myDeck.Clone();
            foreach (PlayingCard playingCard in (CollectionBase)copyFrom)
                this.InnerList.Add(playingCard.Clone());
        }

        protected CardDealer()
        {
        }

        public void LoadCardDealer(bool shuffled = true)
        {
            this.List.Clear();
            for (int index = 0; index < this.myNumberOfDecks; ++index)
            {
                foreach (PlayingCard playingCard in (ReadOnlyCollectionBase)this.myDeck)
                    this.List.Add(playingCard.Clone());
            }
            if (!shuffled)
                return;
            this.Shuffle();
        }

        public bool DrawCard(ref PlayingCard drawCard, bool drawFaceUp = false)
        {
            bool flag = false;
            if (this.List.Count > 0)
            {
                drawCard = this[0];
                flag = true;
                drawCard.FaceUp = drawFaceUp;
                this.List.RemoveAt(0);
                Debug.WriteLine("\n" + drawCard.DebugString() + " was drawn from the CardDealer");
            }
            if (this.List.Count == 0)
            {
                if (this.OutOfCards != null)
                    this.OutOfCards((object)this, new EventArgs());
            }
            else if (this.List.Count == this.redCardPosition && this.RedCardReached != null)
                this.RedCardReached((object)this, new EventArgs());
            return flag;
        }

        public object Clone() => (object)new CardDealer(this);

        public void Shuffle()
        {
            Random random = new Random();
            ArrayList arrayList = new ArrayList();
            while (!this.Empty)
            {
                int num = random.Next(0, this.Count);
                arrayList.Add((object)this[num]);
                this.InnerList.RemoveAt(num);
            }
            this.InnerList.AddRange((ICollection)arrayList);
        }

        protected PlayingCard this[int indexOfCard] => (PlayingCard)this.List[indexOfCard];

        public event EventHandler OutOfCards;

        public event EventHandler RedCardReached;
    }
}