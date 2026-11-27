using UnityEngine;
using DG.Tweening;


public class CameraManager : MonoBehaviour
{
    private bool isOnMain = true;
    private Vector3 cameraOffset;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Vector3 cameraCenter;
    [SerializeField] private Vector3 cameraLeft;
    [SerializeField] public Canvas ordiUI;
    [SerializeField] public Canvas radioUI;
    // [SerializeField] private float cameraSpeed = 0;
    private int cameraCurrent = 0;
    private int cameraNew = 0;
    public float duration;

    void Start()
    {
        ordiUI.enabled = true;
        radioUI.enabled = false;
    }

    // si on faisait ça bien, on pourrait prévoir pour plusieurs côtés (gauche, haut,...) mais on est en "game jam" donc on va juste check si on est au milieu ou à gauche

    void FixedUpdate()
    {
        if (cameraCurrent != cameraNew)
        {            
            Debug.Log(mainCamera.transform.position);
            Debug.Log(cameraOffset);
            mainCamera.transform.DOMove(cameraOffset, duration); // mouvement de la caméra
            cameraCurrent = cameraNew;
        }

    }
    void OnMouseEnter()
    {
        if(isOnMain)
        {
            cameraOffset = cameraLeft;
            cameraNew = 1;
            isOnMain = false;
            ordiUI.enabled = false;
            radioUI.enabled = true;

        }
        else
        {
            cameraOffset = cameraCenter;
            cameraNew = 5;
            isOnMain = true;
            ordiUI.enabled = true;
            radioUI.enabled = false;

        }
    }
}
