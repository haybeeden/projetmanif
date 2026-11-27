using UnityEngine;


public class MapTrigger : MonoBehaviour
{

    bool mouseEnter = false;
    public Map map;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseEnter == true)
        {
            map.MapEnter();
            mouseEnter = false;
        }

    }

    public void OnMouseEnter()
    {
        Debug.Log("Helllo World");
        mouseEnter = true;
    }
}
