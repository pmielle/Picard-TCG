using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenPack : MonoBehaviour
{
    public GameObject cards;

    void Start() 
    {
        // spawn the cards
        var card = Resources.Load("CardInPack");
        var cardData = Resources.Load<CardData>("1");
        var clone = Instantiate(card, cards.transform);
        clone.GetComponent<Card>().cardData = cardData;
    }

    public void Cancel() {
        SceneManager.LoadScene("MainMenu");
    }
}
