using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{    
    public GameObject damagePrefab;
    
    void OnTriggerEnter(Collider co)
    {
        if (co.GetComponent<Enemy>())
        {
            GameObject g = (GameObject)Instantiate(damagePrefab, transform.position, Quaternion.identity);
            g.GetComponent<Damage>().target = co.transform;
        }
    }
    void OnTriggerStay(Collider co)
    {
        if (co.GetComponent<Enemy>())
        {
            GameObject g = (GameObject)Instantiate(damagePrefab, transform.position, Quaternion.identity);
            g.GetComponent<Damage>().target = co.transform;
        }
    }

    void Update()
    {
        
    }
}
