using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    //Propiedades
    public static int cointsCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        Moneda.cointsCount ++;
        Debug.Log("Cantida de existentes " + Moneda.cointsCount + " de monedas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Programndo la colision de la moneda con otro objeto
    private void OnTriggerEnter(Collider otherCollider) {
        if (otherCollider.CompareTag("Jugador") == true){
            Moneda.cointsCount --;
            if ( Moneda.cointsCount == 0){
                Debug.Log("El juego a terminado");

                GameObject gameManager = GameObject.Find("GameManager");
                Destroy(gameManager);

                GameObject [] fireworksSystem = GameObject.FindGameObjectsWithTag("Fireworks");
                foreach (GameObject fireworks in fireworksSystem){
                    fireworks.GetComponent<ParticleSystem>().Play();
                }
            }else{
                Destroy(gameObject);
            }
        }
    }
}
