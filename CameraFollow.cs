using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject target;
    
    [SerializeField]
    private GameObject camFocus;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject camera;

    [SerializeField]
    private float smoothFollow;

    [SerializeField]
    private float smoothRotate;

    void Update () {
        Cursor.lockState = CursorLockMode.Locked;
        if (camera.GetComponent<CameraOrbit>().lockOn == true)
        {
            target = camFocus;
        }
        else
        {
            target = player;
        }

        Vector3 finalTargetPosition = new Vector3(target.transform.position.x, target.transform.position.y+1, target.transform.position.z);

        transform.position = Vector3.Lerp(transform.position, finalTargetPosition, smoothFollow);
        if (camera.GetComponent<CameraOrbit>().lockOn == true)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, target.transform.rotation, smoothRotate);
        }
    }
}
