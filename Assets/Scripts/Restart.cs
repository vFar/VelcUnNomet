using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importe, lai var stradat ar Image Click, vel importe scenemanagement
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Restart : MonoBehaviour {

	public void GalvenaIzvelne(){
		//Ja tiek uzspiesta Restart poga ar restart iconu png attelu, tad Scene jeb aina parmainas uz MainMenu
		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
	}

}
