using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorJuego : MonoBehaviour {
    private static int puntos = 0;
    private static bool jugando = true;

    public static bool GetJugando() {
        return jugando;
    }

    public static void SetJugando(bool value) {
        jugando = value;
    }


}
