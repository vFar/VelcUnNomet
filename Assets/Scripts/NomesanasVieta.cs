using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler {
	private float zRot, velkObjZrot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;

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
						break;
					

					case "AtraPalidziba":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [2]);
						break;
				

					case "Autobuss":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [3]);
						break;

						//Parejiem attelu objektiem, pieskir Case ar tag vertibu, kas attelu objektam iedod audio clip

					case "Policija":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [4]);
						break;

					case "b2":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [5]);
						break;

					case "CementaMaisitajs":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [6]);
						break;

					case "e46":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [7]);
						break;

					case "Ekskavators":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [8]);
						break;

					case "Traktors1":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [9]);
						break;

					case "Traktors5":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [10]);
						break;

					case "Ugunsdzeseji":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [11]);
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
	}
}
