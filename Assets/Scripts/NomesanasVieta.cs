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

					case "Policija":
						objektuSkripts.avots.PlayOneShot (objektuSkripts.skanasKlipi [4]);
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

				case "Policija":
					objektuSkripts.policija.GetComponent<RectTransform> ().localPosition = objektuSkripts.policKoord;
					break;


				default:
					Debug.Log ("Nedefinéts tags!");
					break;
				}
			}
		}
	}
}
