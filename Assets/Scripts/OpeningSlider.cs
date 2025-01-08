using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OpeningSlider : MonoBehaviour, IPointerUpHandler
{
    Slider slider;
    Animator packAnim;

    public void OnPointerUp(PointerEventData eventData)
    {
        slider.value = 0;
    }

    public void OnSliderChange() {
        if (slider.value > 99) 
        {
            packAnim.SetBool("IsOpen", true);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponent<Slider>();
        packAnim = GameObject.Find("Pack").GetComponent<Animator>();
    }
}
