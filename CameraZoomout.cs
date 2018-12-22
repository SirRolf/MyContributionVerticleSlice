using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomout : MonoBehaviour {

    [SerializeField]
    private Transform player;
    private Camera cam;

    private bool isZoomed = false;

    [SerializeField]
    private Vector3 zoomOutSpeed;

    void Start () {
        cam = GetComponent<Camera>();
    }
	

	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isZoomed = !isZoomed;
        }

        if (isZoomed == true)
        {
            Vector3 playerPos = cam.WorldToScreenPoint(player.position);
            if (playerPos.x < 0 || playerPos.x > cam.pixelWidth || playerPos.y < 120 || playerPos.y > cam.pixelHeight || playerPos.z < 0)
            {
                //var currentPosition = this.transform.localPosition;
                //print(currentPosition);
                //transform.Translate(zoomOutSpeed * Time.deltaTime);

                transform.localPosition = transform.localPosition + zoomOutSpeed;
            }
        }
    }
}
