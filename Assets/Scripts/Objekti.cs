using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public Canvas kanva;
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject Autobuss;
	public GameObject policija;

	[HideInInspector]
	public Vector2 atrkKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 policKoord;

	public AudioSource avots;
	public AudioClip[] skanasKlipi;
	[HideInInspector]
	public bool istajavieta = false;
	public GameObject pedejaisVilktais = null;

	void Start (){
		atrkKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atroKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussKoord = Autobuss.GetComponent<RectTransform> ().localPosition;
		policKoord = policija.GetComponent<RectTransform> ().localPosition;


	}
}