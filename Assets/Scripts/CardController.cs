using UnityEngine;
using UnityEngine.SceneManagement;

public class CardController : MonoBehaviour
{
    public void Close() {
        SceneManager.LoadScene("MyCards");
    }
}
