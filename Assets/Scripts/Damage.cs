using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float speed = 10;

    public Transform target;

    void FixedUpdate()
    {
        if (target)
        {
            Vector3 dir = target.position - transform.position;
            GetComponent<Rigidbody>().velocity = dir.normalized * speed;
        }
        else
        {            
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider co)
    {
        HealthEn healthen = co.GetComponentInChildren<HealthEn>();
        if (healthen)
        {
            healthen.decrease();
            Destroy(gameObject);
        }
    }
}

