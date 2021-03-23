using System;
using System.Collections;

namespace DurakLibrary
{
    public class Deck : ReadOnlyCollectionBase, ICloneable
    {
        protected bool jokersIncluded;

        public bool Jokers => this.jokersIncluded;

        public Deck(bool jokers)
        {
            this.jokersIncluded = jokers;
            this.InitializeDeck();
        }

        public Deck(Deck copyFrom)
        {
            this.jokersIncluded = copyFrom.jokersIncluded;
            foreach (PlayingCard playingCard in (ReadOnlyCollectionBase)copyFrom)
                this.InnerList.Add(playingCard.Clone());
        }

        protected Deck()
        {
        }

        public PlayingCard this[int cardIndex] => (PlayingCard)this.InnerList[cardIndex];

        public object Clone() => (object)new Deck(this);

        protected void InitializeDeck()
        {
            this.InnerList.Clear();
            for (CardSuit suit = CardSuit.Spades; suit <= CardSuit.Clubs; ++suit)
            {
                for (CardRank rank = CardRank.Ace; rank <= CardRank.King; ++rank)
                    this.InnerList.Add((object)new PlayingCard(rank, suit));
            }
            if (!this.jokersIncluded)
                return;
            this.InnerList.Add((object)new PlayingCard(CardRank.Joker));
            this.InnerList.Add((object)new PlayingCard(CardRank.Joker, CardSuit.Clubs));
        }
    }
}
