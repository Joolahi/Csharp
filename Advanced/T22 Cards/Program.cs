using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace T22_Cards
{
    public enum Suit
    {
        Heart,
        Square,
        Cross,
        Spade
    }
    public enum Value
    {
        A,K,Q,J,Ten,Nine,Eight,Seven,Six,Five,Four,Three,Two
    }

    class Card
    {
        public Suit Suit { get; }
        public Value Value { get; }
        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }
        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }

    }
    class Deck
    {
        public List<Card> Cards;

        public Deck()
        {
            Cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    Cards.Add(new Card(suit, value));
                }
            }
        }

        public void Suffle()
        {
            Random rnd = new Random();
            int cardDeck = Cards.Count;
            while (cardDeck > 1)
            {
                cardDeck--;
                int newDeck = rnd.Next(cardDeck + 1);
                Card value = Cards[newDeck];
                Cards[newDeck] = Cards[cardDeck];
                Cards[cardDeck] = value;
            }
        }

        public void Print()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card);
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Print();
            deck.Suffle();
            deck.Print();
            
        }
    }
}
