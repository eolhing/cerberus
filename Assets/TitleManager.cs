﻿using UnityEngine;
using System.Collections;

public class TitleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void quit() {
		Application.Quit();
	}

	public void play() {
		Application.LoadLevel("game");
	}
}
