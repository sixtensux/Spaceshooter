using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour {

	public GameObject gameController;
	
	public int score;
	public TextMeshProUGUI text;
	private string scoreString;

	private void Awake()
	{
		gameController = GameObject.FindWithTag("GameController");
	}


	void Start ()
	{
		text.text = $"Score:{scoreString}";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
