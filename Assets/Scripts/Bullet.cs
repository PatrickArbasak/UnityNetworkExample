using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        Health health = null;
        if (health = collision.gameObject.GetComponent<Health>())
        {
            health.TakeDamage(10);
        }
        Destroy(gameObject);
    }
}
