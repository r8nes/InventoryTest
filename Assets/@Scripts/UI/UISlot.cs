using UnityEngine;
using UnityEngine.EventSystems;

public class UISlot : MonoBehaviour, IDropHandler
{
    public virtual void OnDrop(PointerEventData eventData)
    {
        Transform itemTransform = eventData.pointerDrag.transform;
        itemTransform.SetParent(transform);
        itemTransform.localPosition = Vector3.zero;
    }
}
