using UnityEngine;
using UnityEngine.SceneManagement;

public class MyCards : MonoBehaviour
{
    Player player;
    void Start() 
    {
        player = GameObject.Find("Player").GetComponent<Player>();   
        foreach (var cardId in player.cards)
        {
            Debug.Log($"cardId is: {cardId}");
        }
    }

    public void GoToCard() {
        SceneManager.LoadScene("Card");
    }

    public void Close() {
        SceneManager.LoadScene("MainMenu");
    }
}
