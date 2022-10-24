using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HomeScript : MonoBehaviour
{
    int lifeTimeHome;
    public GameObject WinPanel;
    public TextMeshProUGUI shootCount;
   
    void Start()
    {
        Time.timeScale = 1;
        lifeTimeHome = 100;
    }
    void Win()
    {
        WinPanel.SetActive(true);
        Time.timeScale = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shoot"))
        {
            lifeTimeHome -= 1;
            shootCount.text = lifeTimeHome.ToString();
            
        }
        if (lifeTimeHome == 2)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            Invoke("Win", 0.5f);
        }
        
    }

}
