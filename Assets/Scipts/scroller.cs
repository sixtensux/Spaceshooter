using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroller : MonoBehaviour {

    private Material mat;
    public float scalar = 1f;

	void Start ()
    {
        mat = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update ()
    {
        mat.mainTextureOffset = new Vector2(Time.time * scalar, 0);
    }
}
