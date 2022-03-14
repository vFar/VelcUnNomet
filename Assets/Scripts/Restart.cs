using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importe, lai var stradat ar Image Click, vel importe scenemanagement
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Restart : MonoBehaviour {
	public GameObject RestartPoga;

	public void OnPointerClick(PointerEventData notikums){
		SceneManager.LoadScene ("Pilseta", LoadSceneMode.Single);
	}

}
