using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    public CardData cardData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Find("Name").GetComponent<TextMeshProUGUI>().text = cardData.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
