using UnityEngine;
using UnityEngine.EventSystems;

    public interface IDragPage
    {
        void OnCurrentDrag(); // => fonction on current drag dans page.cs qui integre l'interface i drag page
    }

public class DragPage : MonoBehaviour, IDragHandler
{
    [SerializeField] GameObject objToInteractWith;
    private IDragPage onDrag;

    void Start()
    {
        onDrag = objToInteractWith.GetComponent<IDragPage>(); 
    }

    public void OnDrag(PointerEventData eventData)
    {
        onDrag.OnCurrentDrag(); // on drag, va faire la fonction on current drag
    }
}