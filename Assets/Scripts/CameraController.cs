using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject target;
    public Vector3 cameraPos;

    void Update()
    { 
        this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position + cameraPos, Time.deltaTime);
    }
}
