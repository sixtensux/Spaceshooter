using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public float resetDelay;

	public GameObject gameOverScreen;
	public GameObject ui;

	public void GameOver()
	{
		gameOverScreen.SetActive(true);
		ui.SetActive(false);
	}

	public void ResetScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
