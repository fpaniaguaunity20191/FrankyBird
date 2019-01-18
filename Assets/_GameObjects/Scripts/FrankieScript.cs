using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrankieScript : MonoBehaviour {

    [SerializeField] GameObject sangrePrefab;
    [SerializeField] private float force = 10f;
    [SerializeField] AudioClip aleteo;
    [SerializeField] AudioClip puntuacion;
    //public float force = 10f;//Alternativa no encapsulada
    private Rigidbody rb;
    private AudioSource audioSource;

    void Start () {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Impulsar();
        }
	}

    void Impulsar() {
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        audioSource.PlayOneShot(aleteo);
    }

    private void OnCollisionEnter(Collision collision) {
        GestorJuego.SetJugando(false);
        GameObject sangre = Instantiate(sangrePrefab);
        sangre.transform.position = this.transform.position;
        Destroy(this.gameObject);
    }
}
