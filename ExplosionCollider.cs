using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCollider : MonoBehaviour {

    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            player.gameObject.GetComponent<PlayerHealth>().RemoveHealth(1);
        }
    }
}
