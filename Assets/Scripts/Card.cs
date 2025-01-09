using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    public CardData cardData;
    public new GameObject name;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        name.GetComponent<TextMeshProUGUI>().text = cardData.name;
    }
}
