using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler {
	private float zRot, velkObjZrot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;
	//no Winner skripta izvelkam GameObject winner
	public Winner winnerSkripts;


	public void OnDrop(PointerEventData notikums){
		if (notikums.pointerDrag != null) {
			if (notikums.pointerDrag.tag.Equals (tag)) {
				zRot = notikums.pointerDrag.GetComponent<RectTransform> ().eulerAngles.z;
				velkObjZrot = GetComponent<RectTransform> ().eulerAngles.z;
				rotacijasStarpiba = Mathf.Abs (zRot - velkObjZrot);
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform> ().localScale;
				velkObjIzm = GetComponent<RectTransform> ().localScale;
				xIzmeruStarp = Mathf.Abs (vietasIzm.x - velkObjIzm.x);
				yIzmeruStarp = Mathf.Abs (vietasIzm.y - velkObjIzm.y);

				if ((rotacijasStarpiba <= 6 || rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360) && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1)) {
					objektuSkripts.istajavieta = true;
					notikums.pointerDrag.GetComponent<RectTransform> ().anchoredPosition = GetComponent<RectTransform> ().anchoredPosition;
					notikums.pointerDrag.GetComponent<RectTransform> ().localRotation = GetComponent<RectTransform> ().localRotation;
					notikums.pointerDrag.GetComponent<RectTransform> ().localScale = GetComponent<RectTransform> ().localScale;

					switch (notikums.pointerDrag.tag) {
					case "Atkritumi":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [1]);
						objektuSkripts.points++;
						break;
					

					case "AtraPalidziba":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [2]);
						objektuSkripts.points++;
						break;
				

					case "Autobuss":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [3]);
						objektuSkripts.points++;
						break;

						//Parejiem attelu objektiem, pieskir Case ar tag vertibu, kas attelu objektam liek atskanot audio clipu un saglaba punktu

					case "Policija":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [4]);
						objektuSkripts.points++;
						break;

					case "b2":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [5]);
						objektuSkripts.points++;
						break;

					case "CementaMaisitajs":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [6]);
						objektuSkripts.points++;
						break;

					case "e46":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [7]);
						objektuSkripts.points++;
						break;

					case "Ekskavators":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [8]);
						objektuSkripts.points++;
						break;

					case "Traktors1":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [9]);
						objektuSkripts.points++;
						break;

					case "Traktors5":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [10]);
						objektuSkripts.points++;
						break;

					case "Ugunsdzeseji":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [11]);
						objektuSkripts.points++;
						break;

					default:
						Debug.Log ("Nedefinéts tags!");
						break;
					}
				}			
		

			} else {
				objektuSkripts.istajavieta = false;
				objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [0]);

				switch (notikums.pointerDrag.tag) {
				case "Atkritumi":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.atrkKoord;
					break;


				case "AtraPalidziba":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition = objektuSkripts.atroKoord;

					break;


				case "Autobuss":
					objektuSkripts.Autobuss.GetComponent<RectTransform> ().localPosition = objektuSkripts.bussKoord;
				
					break;

					//Parejos attelu objektus parliek sakuma pozicija, ja ielikta nepaireza vieta (nepareiza aizkrasota attela objekta vieta!)

				case "Policija":
					objektuSkripts.policija.GetComponent<RectTransform> ().localPosition = objektuSkripts.policKoord;

					break;

				case "b2":
					objektuSkripts.b2.GetComponent<RectTransform> ().localPosition = objektuSkripts.b2Koord;

					break;

				case "CementaMaisitajs":
					objektuSkripts.CementaMaisitajs.GetComponent<RectTransform> ().localPosition = objektuSkripts.CementaKoord;

					break;

				case "e46":
					objektuSkripts.e46.GetComponent<RectTransform> ().localPosition = objektuSkripts.e46Koord;

					break;

				case "Ekskavators":
					objektuSkripts.Ekskavators.GetComponent<RectTransform> ().localPosition = objektuSkripts.EksKoord;
					break;

				case "Traktors1":
					objektuSkripts.Traktors1.GetComponent<RectTransform> ().localPosition = objektuSkripts.Tr1Koord;
					break;

				case "Traktors5":
					objektuSkripts.Traktors5.GetComponent<RectTransform> ().localPosition = objektuSkripts.Tr5Koord;
					break;

				case "Ugunsdzeseji":
					objektuSkripts.Ugunsdzeseji.GetComponent<RectTransform> ().localPosition = objektuSkripts.UguKoord;
					break;

				default:
					Debug.Log ("Nedefinéts tags!");
					break;
				}
			}
		}

		//Ja punktu skaits parsniegs 10 jeb sasniegs tos 11, tad izmetisies uzvaras logs, kura tiks paraditas zvaigznes un taimeris
		if (objektuSkripts.points > 10) {
			objektuSkripts.scroll.SetActive (true);
			objektuSkripts.grayedstar1.SetActive (true);
			objektuSkripts.grayedstar2.SetActive (true);
			objektuSkripts.grayedstar3.SetActive (true);
			objektuSkripts.text1.SetActive (true);
			objektuSkripts.poga.SetActive (true);
			objektuSkripts.aktivsLaiks = false;

			//Teksts, kuru izvadis
			objektuSkripts.text1.GetComponent<Text>().text = Mathf.Round(objektuSkripts.laiks).ToString ()+" sekundes!";


			//Parbauda laika intervalus prieks zvaigznisu pasniegsanai
			if (objektuSkripts.laiks >= 80) {
				objektuSkripts.star1.SetActive (true);
				objektuSkripts.star2.SetActive (true);
				objektuSkripts.star3.SetActive (false);
			} else if (objektuSkripts.laiks <= 60) {
				objektuSkripts.star1.SetActive (true);
				objektuSkripts.star2.SetActive (true);
				objektuSkripts.star3.SetActive (true);
			}


			if (objektuSkripts.laiks >= 140) {
				objektuSkripts.star1.SetActive (true);
				objektuSkripts.star2.SetActive (false);
				objektuSkripts.star3.SetActive (false);
			}

			if (objektuSkripts.laiks >= 240) {
				objektuSkripts.star1.SetActive (false);
				objektuSkripts.star2.SetActive (false);
				objektuSkripts.star3.SetActive (false);
			}	
		}
			
	}
}
