using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByConect : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        Instantiate(explosion, transform.position, transform.rotation);

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
