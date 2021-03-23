/*
 Authors: Muzhda Ehsan
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DurakLibrary
{
        //public card class 
    public class Card
    {

        public enum FaceEnum
        {
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }

        public enum SuitEnum
        {
            Spade,
            Diamond,
            Club,
            Heart
        }

        //instance attributes
        public readonly FaceEnum face;
        public readonly SuitEnum suit;


        //class attributes
        public static bool isAceHigh = true;
        public static bool useTrumps = false;
        public static SuitEnum trump = SuitEnum.Club;

       
        // getters
        public SuitEnum getCardSuit()
        {

            return suit;
        }

        public FaceEnum getCardFace()
        {

            return face;
        }

        // constructors - default 
        public Card()
        {

        }

        // constructors - paramitrazied
        public Card(FaceEnum face, SuitEnum suit)
        {
            this.face = face;
            this.suit = suit;
        }


        public String ToString(int playerNumber)
        {
            return "\nCard Drawn by Player " + playerNumber + "\nThe " + face + " of " + suit + "s";
        }

        
        //operator overloading methods
        //returns a boolean 
        public static bool operator ==(Card playerCard, Card AICard)
        {

            return (playerCard.suit == AICard.suit) && (playerCard.face == AICard.face);

        }

        public static bool operator !=(Card playerCard, Card AICard)
        {

            return !(playerCard == AICard);

        }

        public override bool Equals(object card)
        {
            return this == (Card)card;
        }

        public static bool operator >(Card playerCard, Card AICard)
        {
            if (playerCard.suit == AICard.suit)
            {
                if (isAceHigh)
                {
                    if (playerCard.face == FaceEnum.Ace)
                    {
                        if (AICard.face == FaceEnum.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (AICard.face == FaceEnum.Ace)
                            return false;
                        else
                            return (playerCard.face > AICard.face);
                    }
                }
                else
                {
                    return (playerCard.face > AICard.face);
                }
            }
            else
            {
                if (useTrumps && (AICard.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <(Card playerCard, Card AICard)
        {
            return !(playerCard >= AICard);
        }

        public static bool operator >=(Card playerCard, Card AICard)
        {
            if (playerCard.suit == AICard.suit)
            {
                if (isAceHigh)
                {
                    if (playerCard.face == FaceEnum.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (AICard.face == FaceEnum.Ace)
                            return false;
                        else
                            return (playerCard.face >= AICard.face);
                    }
                }
                else
                {
                    return (playerCard.face >= AICard.face);
                }
            }
            else
            {
                if (useTrumps && (AICard.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <=(Card playerCard, Card AICard)
        {
            return !(playerCard > AICard);
        }
    }
}