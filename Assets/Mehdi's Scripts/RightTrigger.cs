using UnityEngine;


public class Righ : MonoBehaviour
{

    bool mouseOver = false;
    public Phone phone;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseOver == true)
        {
            phone.PhoneEnter();
            mouseOver = false;
        }

    }

    public void OnMouseOver()
    {
        print("hello world");
        mouseOver = true;
    }
}
