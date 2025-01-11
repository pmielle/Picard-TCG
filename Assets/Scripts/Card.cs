using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
    public GameObject background;
    public GameObject illustration;
    public Sprite meatBg;
    public Sprite fishBg;
    public Sprite veggieBg;
    public Sprite dessertBg;
    public Sprite entryBg;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        background.GetComponent<Image>().sprite = ChooseBackground(cardData.type);
        illustration.GetComponent<Image>().sprite = ChooseIllustration(cardData.id);
        name.GetComponent<TextMeshProUGUI>().text = cardData.name;
        price.GetComponent<TextMeshProUGUI>().text = $"{cardData.price}€";
        quote.GetComponent<TextMeshProUGUI>().text = $"\"{cardData.quote}\"";
        review.GetComponent<TextMeshProUGUI>().text = cardData.review;
        collection.GetComponent<TextMeshProUGUI>().text = cardData.collection;
        year.GetComponent<TextMeshProUGUI>().text = cardData.year.ToString();
        author.GetComponent<TextMeshProUGUI>().text = cardData.author;
    }

    Sprite ChooseIllustration(int cardId) {
        return Resources.Load<Sprite>($"Illustrations/{cardId}");
    }

    Sprite ChooseBackground(CardType type) {
        Sprite sprite;
        switch (cardData.type) {
            case CardType.Meat:
                sprite = meatBg;
                break;
            case CardType.Fish:
                sprite = fishBg;
                break;
            case CardType.Dessert:
                sprite = dessertBg;
                break;
            case CardType.Entry:
                sprite = entryBg;
                break;
            case CardType.Veggie:
                sprite = veggieBg;
                break;
            default:
                Debug.LogError("Failed to choose background sprite");
                sprite = meatBg;
                break;
        }
        return sprite;
    }
}
