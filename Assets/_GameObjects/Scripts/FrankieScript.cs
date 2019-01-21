using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrankieScript : MonoBehaviour {

    [SerializeField] GameObject sangrePrefab;
    [SerializeField] private float force = 10f;
    [SerializeField] AudioClip aleteo;
    [SerializeField] AudioClip puntuacion;
    [SerializeField] float velocidadRotacion = -5f;
    //public float force = 10f;//Alternativa no encapsulada
    private Rigidbody rb;
    private AudioSource audioSource;
    private GameObject gestorJuego;

    void Start() {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        gestorJuego = GameObject.Find("GestorJuego");
    }
    void Update() {
        transform.rotation = Quaternion.Euler(new Vector3(rb.velocity.y * velocidadRotacion, 0, 0));
        if (Input.GetKeyDown(KeyCode.Space)) {
            Impulsar();
        }
    }
    void Impulsar() {
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        audioSource.PlayOneShot(aleteo);
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Limite") == false) {
            gestorJuego.GetComponent<GestorJuego>().FinalizarPartida();
            GameObject sangre = Instantiate(sangrePrefab);
            sangre.transform.position = this.transform.position;
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerExit(Collider other) {
        //int puntos = gestorJuego.GetComponent<GestorJuego>().GetPuntos();
        int puntos = gestorJuego.GetComponent<GestorJuego>().Puntos;
        puntos++;//puntos = puntos + 1;
        gestorJuego.GetComponent<GestorJuego>().Puntos = puntos;
    }

}
