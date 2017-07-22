using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	[SerializeField] GameObject rotator;
	[SerializeField] GameObject scope;
	[SerializeField] GameObject mainBall;
	float rotationSpeed = 30.0f;
	float pushForce = 500.0f;
	bool canShoot = true;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && canShoot) {
			Vector3 temp = new Vector3 ();
			temp = rotator.transform.position - scope.transform.position;
			temp = temp * pushForce;
			mainBall.GetComponent<Rigidbody>().AddForce(temp);
			canShoot = false;
			scope.GetComponent<MeshRenderer>().enabled = false;
			
			
		} else if (Input.GetKey (KeyCode.A) && canShoot == true) {
			//Debug.Log ("a is pressed");
			rotator.transform.Rotate (Vector3.forward, rotationSpeed * Time.deltaTime); 
			
		} else if (Input.GetKey (KeyCode.D) && canShoot == true) {
			rotator.transform.Rotate (Vector3.forward, -rotationSpeed * Time.deltaTime); 
			
		}
		
	}
	
	
	public void ricochetHor(Rigidbody body){
		Vector3 temp = new Vector3 ();
		temp = body.velocity;
		//float tempF = temp.x;
		//temp.x = -tempF;

		float tempF2 = temp.y;
		temp.y = - tempF2;
		body.velocity = temp;
	}

	public void ricochetVer(Rigidbody body){
		Vector3 temp = new Vector3 ();
		temp = body.velocity;
		float tempF = temp.x;
		temp.x = -tempF;
		
		//float tempF2 = temp.y;
		//temp.y = - tempF2;
		body.velocity = temp;

	}
	

}
