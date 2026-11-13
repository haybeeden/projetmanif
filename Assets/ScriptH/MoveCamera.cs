using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private bool isOnMain = true;
    private Vector3 cameraOffset;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Vector3 cameraCenter;
    [SerializeField] private Vector3 cameraLeft;
    [SerializeField] private int cameraSpeed = 2;
    private int cameraCurrent = 0;
    private int cameraNew = 0;

    // si on faisait ça bien, on pourrait prévoir pour plusieurs côtés (gauche, haut,...) mais on est en "game jam donc on va juste check si on est au milieu ou à gauche
    void Update()
    {
        if (cameraCurrent != cameraNew)
        {
            Debug.Log(mainCamera.transform.position);
            Debug.Log(cameraOffset);
            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, cameraOffset, cameraSpeed);
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
        }
        else
        {
            cameraOffset = cameraCenter;
            cameraNew = 5;
            isOnMain = true;
        }
    }
}
