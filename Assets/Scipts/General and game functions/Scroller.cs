using UnityEngine;

public class Scroller : MonoBehaviour
{
    private Material mat;
    public float scalar = 1f;

	void Start ()
    {
        mat = GetComponent<Renderer>().material;
	}
	
	void Update ()
    {
        mat.mainTextureOffset = new Vector2(Time.time * scalar, 0);
    }
}
