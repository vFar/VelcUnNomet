using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objekti : MonoBehaviour {
	public Canvas kanva;
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject Autobuss;
	//Pievienoti attélu objekti
	public GameObject policija;
	public GameObject b2;
	public GameObject CementaMaisitajs;
	public GameObject e46;
	public GameObject Ekskavators;
	public GameObject Traktors1;
	public GameObject Traktors5;
	public GameObject Ugunsdzeseji;

	[HideInInspector]
	public Vector2 atrkKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;

	//Izveidojam mainigos, kas uzglabas pasreizejo attela objekta koordinatas un ar HideInInspector paslepjam inspector loga

	[HideInInspector]
	public Vector2 policKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 CementaKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 EksKoord;
	[HideInInspector]
	public Vector2 Tr1Koord;
	[HideInInspector]
	public Vector2 Tr5Koord;
	[HideInInspector]
	public Vector2 UguKoord;


	public AudioSource avots;
	public AudioClip[] skanasKlipi;
	[HideInInspector]
	public bool istajavieta = false;
	public GameObject pedejaisVilktais = null;

	public int points=0;
	public GameObject winner;
	public GameObject star1;
	public GameObject star2;
	public GameObject star3;

	public GameObject scroll;
	public GameObject text1;
	public GameObject grayedstar1;
	public GameObject grayedstar2;
	public GameObject grayedstar3;
	public GameObject poga;

	//Laika jeb taimera nepieciesamie definejumi
	public float laiks;
	public bool aktivsLaiks=true;

	void Start (){
		atrkKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atroKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussKoord = Autobuss.GetComponent<RectTransform> ().localPosition;

		//Void Start metodé pievieno komandas, kas mainígajam pieśḱirt paśreizéjo position vértíbu un paslepj uzvaras logu

		policKoord = policija.GetComponent<RectTransform> ().localPosition;
		b2Koord = b2.GetComponent<RectTransform> ().localPosition;
		CementaKoord = CementaMaisitajs.GetComponent<RectTransform> ().localPosition;
		e46Koord = e46.GetComponent<RectTransform> ().localPosition;
		EksKoord = Ekskavators.GetComponent<RectTransform> ().localPosition;
		Tr1Koord = Traktors1.GetComponent<RectTransform> ().localPosition;
		Tr5Koord = Traktors5.GetComponent<RectTransform> ().localPosition;
		UguKoord = Ugunsdzeseji.GetComponent<RectTransform> ().localPosition;
		scroll.SetActive (false);
		grayedstar1.SetActive (false);
		grayedstar2.SetActive (false);
		grayedstar3.SetActive (false);
		text1.SetActive (false);
		poga.SetActive (false);

		star1.SetActive (false);
		star2.SetActive (false);
		star3.SetActive (false);
	}
}