using UnityEngine;
using UnityEngine.EventSystems;

public class RotationScript : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
   [SerializeField]
   float speed;

    [SerializeField]
    GameObject Greenhouse;
    [SerializeField]
    Canvas canvas;
    [SerializeField]
    Vector3 offset;

    private Vector3 followPosition;

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.position = followPosition;
        transform.SetParent(canvas.transform);
        Greenhouse.transform.SetParent(transform);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.Rotate(transform.forward * Input.mousePosition.x * speed * Time.deltaTime);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Greenhouse.transform.SetParent(canvas.transform);
        transform.SetParent(Greenhouse.transform);
        transform.position = followPosition + offset;
    }

    private void Update()
    {
        followPosition = Greenhouse.transform.position;
    }


}
