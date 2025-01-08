using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Pack : MonoBehaviour, IPointerClickHandler
{
    Animator anim;
    Slider slider;

    public void OnPointerClick(PointerEventData eventData)
    {
        anim.SetBool("ReadyToOpen", true);
        slider.gameObject.SetActive(true);
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        slider = GameObject.Find("OpeningSlider").GetComponent<Slider>();
        slider.gameObject.SetActive(false);
    }
}
