using TMPro;
using UnityEngine;

public class CardInList : MonoBehaviour
{
    public int stackCount;
    public GameObject stackCountObj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        if (stackCount > 1)
        {
            stackCountObj.GetComponent<TextMeshProUGUI>().text = stackCount.ToString();
        }
        else
        {
            stackCountObj.SetActive(false);
        }
    }
}
