using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IDragHandler, IEndDragHandler
{

    readonly float dragSpeed = 0.1f;

    public void OnDrag(PointerEventData eventData)
    {
        transform.Rotate(Vector3.down, eventData.delta.x * dragSpeed, Space.Self);
        transform.Rotate(Vector3.right, eventData.delta.y * dragSpeed, Space.Self);
    }

    public void OnEndDrag(PointerEventData eventData) {
        transform.rotation = Quaternion.identity;
    }
}
