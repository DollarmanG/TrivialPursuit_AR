using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Lean.Touch;

public class CardStackHandler : MonoBehaviour
{
    [SerializeField] private List<RawImage> cardList = new List<RawImage>();

    [SerializeField] private GameObject cardDeck;

    public void ShowFirstCard()
    {
        cardList[0].gameObject.SetActive(true);
        var tempCard = cardList[0];
        cardList.Remove(tempCard);
        cardList.Add(tempCard);
    }
}
