using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public Canvas kanva;
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject Autobuss;

	[HideInInspector]
	public Vector2 atrkKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;

	public AudioSource avots;
	public AudioClip[] skanasKlipi;
	[HideInInspector]
	public bool istajavieta = false;
	public GameObject pedejaisVilktais = null;

	void Start (){
		


	}
}