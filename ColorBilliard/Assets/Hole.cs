using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour {
	[SerializeField] public float red = 0.0f;
	[SerializeField] public float green= 0.0f;
	[SerializeField] public float blue= 0.0f;
	Renderer myRenderer;


	// Use this for initialization
	void Start () {
		myRenderer = GetComponent<Renderer> ();
		myRenderer.material.color = new Color (red, green, blue, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}




}
