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
        var card = Resources.Load("Card");
        foreach (var cardId in player.cards)
        {
            var cardData = Resources.Load<CardData>(cardId.ToString());
            var clone = Instantiate(card, content.transform);
            clone.GetComponent<Card>().cardData = cardData;
            clone.GetComponent<Button>().onClick.AddListener(() => GoToCard(cardId));
        }
    }

    public void GoToCard(int cardId) {
        Debug.Log($"displaying card #{cardId}");
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
