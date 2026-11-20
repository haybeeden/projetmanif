using UnityEngine;

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
            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, cameraOffset, 1); //pos start, pos goal, length
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
