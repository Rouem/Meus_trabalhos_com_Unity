using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaConfig : MonoBehaviour {

	public float ForcaTiro;
	public Vector3 ForcaVento;
	public float DistanciaAlvo;
	public Transform Alvo;
	GameObject cam;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		cam = GameObject.Find ("Main Camera");
		transform.GetComponent<Renderer> ().material.color = Color.red;
		Alvo.transform.GetComponent<Renderer> ().material.color = Color.blue;
		rb = transform.GetComponent<Rigidbody> ();
		rb.AddForce (transform.forward * ForcaTiro, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce(ForcaVento, ForceMode.Force);
		cam.transform.LookAt (transform);
	}

	void OnCollisionEnter (Collision col) {
		DistanciaAlvo = Vector3.Distance (transform.position, Alvo.position);
		if (DistanciaAlvo < 2)
			DistanciaAlvo = 0;
		print ("Distancia do alvo: "+DistanciaAlvo);
		rb.isKinematic = true;
		Destroy (gameObject,3);
	}
}
