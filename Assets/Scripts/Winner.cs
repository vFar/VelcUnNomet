using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Vajadzigs tool, lai varetu stradat ar ainam
using UnityEngine.SceneManagement;


public class Winner : MonoBehaviour {
	//Izveido nepieceisamos mainigos
	public GameObject winner;
	public GameObject taimeris;
	public Objekti objektuSkripts;
	[HideInInspector]
	public bool show=false;


	public void MainMenuButton(){
		//No Pilseta ainas uz Main Menu ainu
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
		objektuSkripts.star1.SetActive (false);
	}


	//Laika skaitisana
	void Update(){
		if (objektuSkripts.aktivsLaiks == true) {
			objektuSkripts.laiks += Time.deltaTime;
		}
	}
		

}
