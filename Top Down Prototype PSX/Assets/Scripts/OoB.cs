using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;

public class OoB : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 50;
    private float bottomBound = 20;
   // public GameObject gameOver;

    void Start()
    {
        //gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         if (transform.position.z > topBound)
        {

            Destroy(gameObject);
        }
        else if (transform.position.z > bottomBound)
        {
            Debug.Log("Game Over :P");
            Destroy(gameObject);
        }
    }
}
