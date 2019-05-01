﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningSceneController : MonoBehaviour {

    public string OpeningSceneName;

    void Start() {
        Time.timeScale = 1f;
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return)) {
            SceneManager.LoadScene(OpeningSceneName);
        }
	}
}
