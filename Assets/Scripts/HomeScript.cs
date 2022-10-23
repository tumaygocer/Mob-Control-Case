using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScript : MonoBehaviour
{
    int lifeTimeHome;
   
    void Start()
    {
        lifeTimeHome = 50;
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shoot"))
        {
            lifeTimeHome -= 1;
            
        }
        if (lifeTimeHome == 0)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
        
    }
}
