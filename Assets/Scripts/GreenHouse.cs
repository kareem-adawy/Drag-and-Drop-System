using UnityEngine;
using UnityEngine.EventSystems;

public class GreenHouse : MonoBehaviour,IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On Drop");
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = gameObject.GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.transform.SetParent(gameObject.transform);
        } 
    }

}
