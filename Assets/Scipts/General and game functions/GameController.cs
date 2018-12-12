using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public float resetDelay;

	public GameObject gameOverScreen;
	public GameObject ui;

	public void GameOver()
	{
		//end game and bring up GAMEOVER screen
		gameOverScreen.SetActive(true);
		ui.SetActive(false);
	}

	public void ResetScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	private IEnumerator Restart()
	{
		yield return new WaitForSeconds(resetDelay);
		ResetScene();
	}
}
