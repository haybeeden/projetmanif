using UnityEngine;

public class Phone : MonoBehaviour
{

    public GameObject RightTrigger;
    public float phoneMoving;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*RightTrigger.GetComponent<HoverTrigger>();*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseExit()
    {
        print("BBL");
        transform.position += new Vector3(phoneMoving, 0f, 0f);
    }
}
