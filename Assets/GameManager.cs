using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject gameOverScreen;

	public void GameOver()
	{
		gameOverScreen.SetActive(true);
	}	
}