using UnityEngine;


public class Righ : MonoBehaviour
{

    bool mouseEnter = false;
    public Phone phone;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (mouseEnter == true)
        {
            phone.PhoneEnter();
            mouseEnter = false;
        }

    }

    public void OnMouseEnter()
    {
        Debug.Log("Goodbye World");
        mouseEnter = true;
    }
}

