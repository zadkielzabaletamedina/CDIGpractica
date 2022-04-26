using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MenuPrincipal : MonoBehaviour {

	GameObject MenuPrincipal;
	GameObject Creditos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void CreditsButtom (){
		MenuPrincipal.SetActive(false);
		Creditos.SetActive(true);
	}

	void QuitButtom() {
		Application.Quit();
	}
}
