using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuberiasGeneratorScript : MonoBehaviour {
    [SerializeField] GameObject tuberiasPrefab;
    [SerializeField] float tiempoEntreTuberias = 2.2f;
    GameObject gestorJuego;

	void Start () {
        gestorJuego = GameObject.Find("GestorJuego");
        InvokeRepeating("CrearTuberia", 0, tiempoEntreTuberias);
    }
    void Update () {
		
	}
    private void CrearTuberia() {
        if (gestorJuego.GetComponent<GestorJuego>().GetJugando() == true) {
            Instantiate(tuberiasPrefab, transform);
        }
    }
}
