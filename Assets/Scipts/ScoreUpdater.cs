using UnityEngine;
using TMPro;

public class ScoreUpdater : MonoBehaviour 
{
	public int score = 0; //the score displayed in the background of the game
	private string scoreString; //score stored as a string

	public GameObject textMeshText; // the GameObject the game object of the textmest text
	public TextMeshProUGUI textMesh;// the text component

	private void Start()
	{
	    textMeshText = GameObject.FindGameObjectWithTag("Score");
		textMesh = textMeshText.GetComponent<TextMeshProUGUI>();
		string scoreString = score.ToString();
	}

	public void AddPoints(int points) // adds points and updates the score when called
	{
		score += points;
		textMesh.text = string.Format($"Score:{score.ToString()}"); 
	}
}


