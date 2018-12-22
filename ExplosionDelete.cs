using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDelete : MonoBehaviour {

    private float Timer = 0;

    [SerializeField]
    private float destroyTime;

    void Update () {
        Timer += Time.deltaTime;
        if (Timer >= destroyTime)
        {
            Destroy(gameObject);
        }
	}
}
