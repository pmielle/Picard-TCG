using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OpeningSlider : MonoBehaviour, IPointerUpHandler
{
    Slider slider;
    GameObject pack;

    public void OnPointerUp(PointerEventData eventData)
    {
        slider.value = 0;
    }

    public void OnSliderChange() {
        if (slider.value > 99) 
        {
            pack.GetComponent<Animator>().SetBool("IsOpen", true);
            // give the new cards to the player
            var player = GameObject.Find("Player").GetComponent<Player>();  
            player.cards.AddRange(pack.GetComponent<PackDisplay>().cardIds);
            player.Save();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponent<Slider>();
        pack = GameObject.Find("Pack");

    }
}
