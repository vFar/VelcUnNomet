using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Vajadzigs tool, lai varetu stradat ar ainam
using UnityEngine.SceneManagement;


public class Winner : MonoBehaviour {
	public GameObject winner;


	public void MainMenuButton(){
		//No Pilseta ainas uz Main Menu ainu
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
	}

	void Update(){

		//Uzzina vai aina "Pilseta" ir ieladeta, ja ir, tad paslepj uzvaras logu
		if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Pilseta")) {
			winner.SetActive (false);
		}

	}

}
