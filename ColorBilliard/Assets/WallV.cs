using UnityEngine;
using System.Collections;

public class WallV : MonoBehaviour {
	[SerializeField] GameObject manager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Ball") {
			Debug.Log("triggered");
			manager.GetComponent<Manager>().ricochetVer(other.gameObject.GetComponent<Rigidbody>());


		}
	}
}
