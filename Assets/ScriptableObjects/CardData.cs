using UnityEngine;

public enum CardType {
    Meat,
    Fish,
    Veggie,
    Entry,
    Dessert,
}

[CreateAssetMenu]
public class CardData : ScriptableObject
{
    public int id;
    public new string name;
    public float price;
    public string quote;
    public string review;
    public string collection;
    public int year;
    public string author;
    public CardType type;
}
