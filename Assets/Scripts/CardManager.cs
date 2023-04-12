using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    //List of all children Cards
    private List<CardLoader> cards = new List<CardLoader>();
    public List<CardScriptable> cardScriptables;

    void Awake()
    {
        //Get all children Cards
        foreach (Transform child in transform)
        {
            cards.Add(child.GetComponent<CardLoader>());
        }
    }

    void Start()
    {
        //Set random cards
        setRandomCards();
    }

    public void setRandomCards()
    {
        //Create a temporary list of all cards
        List<CardScriptable> temp = new List<CardScriptable>(cardScriptables);

        //Remove all cards that are already in the game
        foreach (CardLoader card in cards)
        {
            if (card._currentCard != null)
            {
                temp.Remove(card._currentCard);
            }
        }

        //Change the cards' scriptable object
        foreach (CardLoader card in cards)
        {
            int index = Random.Range(0, temp.Count);
            card.setSO(temp[index]);
            temp.RemoveAt(index);
        }
    }

}
