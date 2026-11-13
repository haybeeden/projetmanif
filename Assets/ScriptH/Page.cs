using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.InputSystem;

public class Page : MonoBehaviour, IDragPage
{
    private RectTransform pageTransform;

    void Awake()
    {
        pageTransform = GetComponent<RectTransform>(); // get position de la page
    }

    public void OnCurrentDrag()
    {
        pageTransform.position = Mouse.current.position.ReadValue(); // position page = position souris
    }
}
