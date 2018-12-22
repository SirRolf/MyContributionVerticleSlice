using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpToTarget : MonoBehaviour {

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float duration;

    void Update () {
        transform.position = Vector3.Lerp(transform.position, target.position, duration);
	}
}
