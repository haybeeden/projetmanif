using UnityEngine;
using DG.Tweening;

public class Phone : MonoBehaviour
{
    public GameObject phoneTrigger;

    public float enterTweenPosition;
    public float exitTweenPosition;
    public float tweenDuration;

    public float triggerRessurectionTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void PhoneEnter()
    {
        transform.DOMoveX(enterTweenPosition, tweenDuration)
           .SetEase(Ease.OutCirc);
        /*easings.net*/
        Debug.Log("Acacab");
        phoneTrigger.SetActive(false);
    }

    public void OnMouseExit()
    {
        Debug.Log("BBL");
        transform.DOMoveX(exitTweenPosition, tweenDuration)
           .SetEase(Ease.OutExpo);
        Invoke ("AbleTrigger", triggerRessurectionTime);
    }

    public void AbleTrigger()
    {
        phoneTrigger.SetActive(true);
    }
}
