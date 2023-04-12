using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    //List of all children Cards
    private List<CardLoader> cards = new List<CardLoader>();

    void Start()
    {
        //Get all children Cards
        foreach (Transform child in transform)
        {
            cards.Add(child.GetComponent<CardLoader>());
        }
    }

    public void buttonClick()
    {
        //Change the cards' scriptable object
        foreach (CardLoader card in cards)
        {
            card.changeSO();
        }
    }

    

}
