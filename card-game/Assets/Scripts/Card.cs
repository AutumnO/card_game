using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private List<Card> open_deck = new List<Card>();
    public GameObject Card2;
    public int Rank, Suit;
    private const int NumRanks = 12;
    private const int NumSuits = 4;
    private Card new_card;

    List<GameObject> cards = new List<GameObject>();

    private enum Suits
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades,
    }

    public Card(int rank, int suit)
    {
        Rank = rank;
        Suit = suit;
    }

    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < NumSuits; i++)
        {
            for (var j = 1; j <= NumRanks; j++)
            {
                new_card.Suit = i;
                new_card.Rank = j;
                open_deck.Add(new_card);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
