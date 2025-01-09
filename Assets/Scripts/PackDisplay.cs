using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PackDisplay : MonoBehaviour, IPointerClickHandler
{
    public List<int> cardIds;
    GameObject cards;
    Slider slider;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        // animate and activate the slider
        GetComponent<Animator>().SetBool("ReadyToOpen", true);
        slider.gameObject.SetActive(true);
    }

    void Start()
    {
        // find stuff
        cards = GameObject.Find("Cards");
        slider = GameObject.Find("OpeningSlider").GetComponent<Slider>();
        // disable the slider
        slider.gameObject.SetActive(false);
        // spawn the cards
        var card = Resources.Load("CardInPack") as GameObject;
        cardIds = new List<int>() { 1, 2, 2, 1, 2 };
        foreach (var cardId in cardIds)
        {
            var cardData = Resources.Load<CardData>(cardId.ToString());
            var clone = Instantiate(card, cards.transform);
            clone.GetComponent<Card>().cardData = cardData;
        }
    }
}
