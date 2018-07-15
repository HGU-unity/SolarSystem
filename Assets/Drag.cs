using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    RectTransform rect;
    Vector3 beginDragWorldPoint;
    Vector3 rectPositionAtBeginDrag;
    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("OnBeginDrag");
        RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, eventData.position, null, out beginDragWorldPoint);
        rectPositionAtBeginDrag = rect.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        Vector3 dragWorldPoint;
        RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, eventData.position, null, out dragWorldPoint);
        rect.position = rectPositionAtBeginDrag + (dragWorldPoint - beginDragWorldPoint);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("OnEndDrag");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        eventData.useDragThreshold = false;
    }
}
