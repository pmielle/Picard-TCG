using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MyCards : MonoBehaviour
{

    public GameObject overlay;

    void Start() 
    {
        // assign stuff
        var player = GameObject.Find("Player").GetComponent<Player>();  
        var content = GameObject.Find("Content");
        // spawn cards
        var card = Resources.Load("CardInList");
        var cards = player.cards;
        cards.Sort();  // need to be sorted for stacking
        int? currentCardId = null;
        int currentStackCount = 0;
        foreach (var cardId in cards)
        {
            // only happens for the first card
            if (currentCardId == null)
            {
                currentCardId = cardId;
                currentStackCount = 1;
                continue;
            }
            // for every other card:
            else 
            { 
                // the card is the same as the previous one: increment the stack counter
                if (currentCardId == cardId) 
                {
                    currentStackCount += 1;
                    continue;
                }
                // this is a new card: spawn the previous card (with its stack count) and start a new stack count for the new card
                else
                {
                    spawn((int)currentCardId, currentStackCount, card, content);
                    // setup new card
                    currentCardId = cardId;
                    currentStackCount = 1;
                }
            }
        }
        // spawn the last card (happens everytime player.cards is not empty)
        if (currentCardId != null)
        {
            spawn((int)currentCardId, currentStackCount, card, content);
            // no need to reset currentCardId and currentStackCount, we are done here
            return;
        }
    }

    void spawn(int cardId, int stackCount, Object card, GameObject content)
    {
        Debug.Log($"stack count is {stackCount}");
        var cardData = Resources.Load<CardData>(cardId.ToString());
        var clone = Instantiate(card, content.transform);
        clone.GetComponent<Card>().cardData = cardData;
        clone.GetComponent<Button>().onClick.AddListener(() => GoToCard(cardId));
    }

    public void GoToCard(int cardId) {
        overlay.SetActive(true);
        var card = Resources.Load("CardDisplay");
        var cardData = Resources.Load<CardData>(cardId.ToString());
        var clone = Instantiate(card, overlay.transform);
        clone.GetComponent<Card>().cardData = cardData;
        clone.name = "CardDisplay";
    }

    public void CloseOverlay() {
        var card = overlay.transform.Find("CardDisplay").gameObject;
        Destroy(card);
        overlay.SetActive(false);
    }

    public void Close() {
        SceneManager.LoadScene("MainMenu");
    }
}
