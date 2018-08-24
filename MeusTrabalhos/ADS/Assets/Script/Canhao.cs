using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canhao : MonoBehaviour {

	public Transform alvo;
	public GameObject bala, ponto;
	public float angulo, forca, vento;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate ((Input.GetAxis("Mouse X") * 90 * Time.deltaTime), 0, 0);


		if (Input.GetMouseButton (0)) {
			forca += 5 * Time.deltaTime;
			print (forca);
		}

		if (Input.GetMouseButtonUp (0)){
			bala.GetComponent<BalaConfig> ().Alvo = alvo;
			bala.GetComponent<BalaConfig> ().ForcaTiro = forca;
			bala.GetComponent<BalaConfig> ().ForcaVento = new Vector3(vento,0,0);
			Instantiate (bala, ponto.transform.position, transform.rotation);
			forca = 0;
			//print("Angulo: "+angulo+"  Força: "+forca);
	}
	}
}
