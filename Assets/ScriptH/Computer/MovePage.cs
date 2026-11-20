using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.InputSystem;

public class MovePage : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private RectTransform pageTransform;
    private Vector2 mouseOffset;
    private bool isDragged;

    void Awake()
    {
        pageTransform = GetComponent<RectTransform>(); // pour get transform et position du gameObject qui est la page
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        mouseOffset = (Vector2)pageTransform.position - Mouse.current.position.ReadValue();
        isDragged = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isDragged)
        {
            pageTransform.position = Mouse.current.position.ReadValue() + mouseOffset;
            pageTransform.SetAsLastSibling();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragged = false;
    }
}
