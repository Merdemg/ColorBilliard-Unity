using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {
	[SerializeField] float x;
	[SerializeField] float y;
	[SerializeField] float z;
	[SerializeField] float force;


	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody> ().AddForce ((new Vector3 (x, y, z)) * force);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
