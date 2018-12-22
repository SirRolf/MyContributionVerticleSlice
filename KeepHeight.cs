using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepHeight : MonoBehaviour {

    private float Height;
    private Vector3 positionOfObject;

    void Start()
    {
        Height = transform.position.y;
    }

	void LateUpdate ()
    {
        positionOfObject = transform.position;
        positionOfObject.y = Height;
        transform.position = positionOfObject;
    }
}
