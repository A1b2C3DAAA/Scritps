using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 2f;
    // Update is called once per frame

    void Update()
    {
        Destroy(gameObject, 3);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        Destroy(other.gameObject);
    }
}
