using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuberiasScript : MonoBehaviour {
    [SerializeField] float speed = 5f;
    [SerializeField] int timeToDestroy = 5;
    GameObject gestorJuego;

    void Start () {

        transform.Translate(0, Random.Range(-2, 2), 0);

        gestorJuego = GameObject.Find("GestorJuego");
        Destroy(this.gameObject, timeToDestroy);
    }
	
	void Update () {
        if (gestorJuego.GetComponent<GestorJuego>().GetJugando() == true) {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
	}
}
