using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorJuego : MonoBehaviour {

    private int puntos = 0;
    private bool jugando;

    private void Start() {
        jugando = true;
    }

    public bool GetJugando() {
        return jugando;
    }

    public void FinalizarPartida() {
        jugando = false;
        Invoke("RecargarEscena", 2f);
    }

    private void RecargarEscena() {
        SceneManager.LoadScene(0);
    }


}
