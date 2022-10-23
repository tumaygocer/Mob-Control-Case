using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScript : MonoBehaviour
{
    int lifeTimeHome;
    public Image homeHealtBar;
   
    void Start()
    {
        lifeTimeHome = 50;
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shoot"))
        {
            lifeTimeHome -= 1;
            homeHealtBar.fillAmount -= 0.02f;
            
        }
        if (lifeTimeHome == 0)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
        
    }
}
