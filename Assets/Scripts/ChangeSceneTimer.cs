﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importe, lai var darboties ar Scenes
using UnityEngine.SceneManagement;

public class ChangeSceneTimer : MonoBehaviour {
	private bool Aina;

	//Darot Click uz pogas Start, aina mainas uz "Pilseta"
	public void Sakt(){
		//Ieraksta SceneManager komandu, kas no MainMenu ainas pariet uz Pilseta
		SceneManager.LoadScene ("Pilseta", LoadSceneMode.Single);

	}

	public void Exit(){
		//Uzspiezot uz Button "Exit" .exe aplikacija aizveras
		Application.Quit ();
	}
}
