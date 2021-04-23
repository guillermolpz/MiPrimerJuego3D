using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Taimer : MonoBehaviour
{
    //Propiedad
    public float maxTime = 60f;
    private float countDown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        countDown = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        //countDown = countDown - Time.deltaTime;
        countDown -= Time.deltaTime;
        if (countDown <= 0){
            Debug.Log("El tiempo se a terminado...  HAS PERDIDO");

            Moneda.cointsCount = 0;

            SceneManager.LoadScene("MainScene");
        }
    }
}
