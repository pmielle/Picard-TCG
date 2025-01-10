using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    public CardData cardData;
    public new GameObject name;
    public GameObject price;
    public GameObject quote;
    public GameObject review;
    public GameObject collection;
    public GameObject year;
    public GameObject author;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        name.GetComponent<TextMeshProUGUI>().text = cardData.name;
        price.GetComponent<TextMeshProUGUI>().text = cardData.price.ToString();
        quote.GetComponent<TextMeshProUGUI>().text = $"\"{cardData.quote}\"";
        review.GetComponent<TextMeshProUGUI>().text = cardData.review;
        collection.GetComponent<TextMeshProUGUI>().text = cardData.collection;
        year.GetComponent<TextMeshProUGUI>().text = cardData.year.ToString();
        author.GetComponent<TextMeshProUGUI>().text = cardData.author;
    }
}
