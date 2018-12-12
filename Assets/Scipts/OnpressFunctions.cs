using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OnpressFunctions : MonoBehaviour {

	public float resetDelay = 2;

	public void ResetGame()
	{
		StartCoroutine(ResetScene());
	}

	//resets the game after {resetDelay} 
	private IEnumerator ResetScene()
	{
		yield return new WaitForSeconds(resetDelay);
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
