using UnityEngine;
using TMPro;

public class PlayerShip : Ship
{
	
	public GameObject textMeshText;
	public TextMeshProUGUI textMesh;

	public void Start()
	{	
			string scoreString = health.ToString();
			textMeshText = GameObject.FindWithTag("PlayerHealth");
			textMesh = textMeshText.GetComponent<TextMeshProUGUI>();
			textMesh.text = $"Livesleft:{health.ToString()}";
	}

	public override void TakeDamage(int Damage)
	{
		base.TakeDamage(Damage);
		textMesh.text = $"Livesleft:{health.ToString()}";
	}

	public override void Die()
	{
		FindObjectOfType<GameManager>().GameOver();
		base.Die();
	}
}
