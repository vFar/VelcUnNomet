using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
	//Velkajam objektam piestiprinam komponenti
	private CanvasGroup grupa;
	private RectTransform velkObjRectTransform;   
	public Objekti objektuSkripts;

	void Start () {
		//Piekĺúst objekta piestiprinatajai CanvasGroup komponentei
		grupa = GetComponent<CanvasGroup>();
		velkObjRectTransform = GetComponent<RectTransform> ();
	}


	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Click on a object");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Begin drag");
		//Velkot objektu, tas paliek caurspidigs pa 0.6 vienibam, izsledzas blocksraycast
		grupa.alpha = 0.6f;
		grupa.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Object drag");
		//maina x un y koordinatas
		velkObjRectTransform.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Stopped dragging");
		grupa.alpha = 1f;

		if (objektuSkripts.istajavieta == false) {
			grupa.blocksRaycasts = true;
		} else {
			objektuSkripts.pedejaisVilktais = null;
		}

		objektuSkripts.istajavieta = false;
			
	}






}
