using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {
	public GameObject Alvo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Alvo = GameObject.Find ("canhao").GetComponent<Canhao>().bala;
		transform.LookAt (Alvo.transform);
	}
}
