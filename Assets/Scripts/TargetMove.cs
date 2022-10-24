using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TargetMove : MonoBehaviour
{

    bool right;
    bool left;
    public GameObject shoot;
    public GameObject shootTransform;
    float shootTime;
    int lifeBar = 60;
    public GameObject gameOverPanel;
    public Image targetHealtBar;
    public AudioSource sounds;



    void Start()
    {
        Time.timeScale = 1;
        shootTime = 0;
    }

    public void GameAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    void Update()
    {
        Vector3 go_right = new Vector3(1, transform.position.y, transform.position.z);
        Vector3 go_left = new Vector3(-1, transform.position.y, transform.position.z);

        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);
            if (shootTime >= 1f)
            {
                Instantiate(shoot,shootTransform.transform.position, Quaternion.identity);
                sounds.Play();
                shootTime = 0;
            }
            else
            {              
                shootTime += 0.25f;
            }

            if (finger.deltaPosition.x > 20.0f)
            {
                right = true;
                left = false;
            }

            if (finger.deltaPosition.x < -20.0f)
            {
                right = false;
                left = true;
            }

            if (right == true)
            {
                transform.position = Vector3.Lerp(transform.position, go_right, 5 * Time.deltaTime);
            }

            if (left == true)
            {
                transform.position = Vector3.Lerp(transform.position, go_left, 5 * Time.deltaTime);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            if (lifeBar != 0)
            {
                lifeBar -= 1;
                targetHealtBar.fillAmount -= 1/60f;
            }
            else
            {
                gameOverPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
