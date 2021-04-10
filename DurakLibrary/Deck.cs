using System;
using System.Collections;

namespace DurakLibrary
{
    public class Deck : ReadOnlyCollectionBase, ICloneable
    {
       

        public Deck()
        {
           
            this.InitializeDeck();
        }

        public Deck(Deck copyFrom)
        {
            
            foreach (PlayingCard playingCard in (ReadOnlyCollectionBase)copyFrom)
                this.InnerList.Add(playingCard.Clone());
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
            
            return;
            
        }

        
    }
}
