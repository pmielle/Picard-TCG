using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CardInPack : MonoBehaviour, IPointerClickHandler
{
    Animator anim;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (transform.GetSiblingIndex() == 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
        else 
        {
            anim.SetBool("Seen", true);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }
}
