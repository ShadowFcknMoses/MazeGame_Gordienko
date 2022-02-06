using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{    
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        if (player)
            GetComponent<NavMeshAgent>().destination = player.transform.position;
    }

    void OnTriggerEnter(Collider co)
    {
        
        if (co.name == "Player")
        {
            co.GetComponentInChildren<Health>().decrease();
            Destroy(gameObject);
        }
    }
}
