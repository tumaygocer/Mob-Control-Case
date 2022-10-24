using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public SphereCollider sphere;
    public GameObject self;

    void Update()
    {
        transform.Translate(Vector3.forward);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("clonner"))
        {
            self.GetComponentInChildren<MeshRenderer>().enabled = true;
            sphere.enabled = true;
        }
    }
}
