﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public List<GameObject> open_deck;
    public List<GameObject> discard_pile;
    public GameObject PlayerArea;
    public GameObject EnemyArea;

    List<GameObject> cards = new List<GameObject>();
    
    void Start()
    {
        cards.Add(Card1);
        cards.Add(Card2);
    }

    public void OnClick()
    {
        for (var i = 0; i < 5; i++)
        {
            GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity); // quaternion.identity says this object does not have rotation
            playerCard.transform.SetParent(PlayerArea.transform, false); // moves created card instance to PlayerArea so it shows up on screen above canvas

            GameObject enemyCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            enemyCard.transform.SetParent(EnemyArea.transform, false);
        }
    }

    public void OnDiscard()
    {

    }
}
