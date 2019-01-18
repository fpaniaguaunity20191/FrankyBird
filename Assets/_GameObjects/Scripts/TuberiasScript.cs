using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuberiasScript : MonoBehaviour {
    [SerializeField] float speed = 5f;
    [SerializeField] int timeToDestroy = 5;
	void Start () {
        Destroy(this.gameObject, timeToDestroy);
    }
	
	void Update () {
        if (GestorJuego.GetJugando() == true) {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
	}
}
