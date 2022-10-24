using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GeneralScript : MonoBehaviour
{

    NavMeshAgent agent;
    public Transform target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        agent.destination = target.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("shoot"))
        {
            Destroy(gameObject);
        }
    }

   
}
