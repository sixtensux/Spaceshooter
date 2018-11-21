using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
	public int Health = 10;
	public GameObject textMeshText;
	public TextMeshProUGUI textMesh;

	private void Start()
	{
		textMeshText = GameObject.FindWithTag("PlayerHealth");
		textMesh = textMeshText.GetComponent<TextMeshProUGUI>();
		string scoreString = Health.ToString();

		//call this once to at start to avoid any problems with The healt value being incorrectly displayed
		textMesh.text = string.Format($"Livesleft:{Health.ToString()}");
	}

	public void Takedamage(int Damage)
	{
		textMesh.text = string.Format($"Livesleft:{Health.ToString()}");		
	}
}

