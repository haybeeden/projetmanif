using UnityEngine;
using DG.Tweening;

public class Map : MonoBehaviour
{
    public GameObject mapTrigger;

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

    public void MapEnter()
    {
        transform.DOMoveY(enterTweenPosition, tweenDuration)
           .SetEase(Ease.OutCirc);
        /*easings.net*/
        Debug.Log("JustAMan");
        mapTrigger.SetActive(false);
    }

    public void OnMouseExit()
    {
        Debug.Log("Monster");
        transform.DOMoveY(exitTweenPosition, tweenDuration)
           .SetEase(Ease.OutExpo);
        Invoke ("AbleTrigger", triggerRessurectionTime);
    }

    public void AbleTrigger()
    {
        mapTrigger.SetActive(true);
    }
}
