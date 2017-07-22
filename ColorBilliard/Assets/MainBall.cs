using UnityEngine;
using System.Collections;

public class MainBall : MonoBehaviour {
	[SerializeField] float red = 0.0f;
	[SerializeField] float green= 0.0f;
	[SerializeField] float blue= 0.0f;
	Renderer myRenderer;
	[SerializeField] int levelToLoad = 0;


	// Use this for initialization
	void Start () {
		myRenderer = GetComponent<Renderer> ();
		myRenderer.material.color = new Color (red, green, blue, 1.0f);
		//this.GetComponent<Material> ().color = new Color (red, green, blue, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Ball") {
			red += other.GetComponent<SideBall>().red;
			green += other.GetComponent<SideBall>().green;
			blue += other.GetComponent<SideBall>().blue;


			if(red> 1.0f)
				red = 1.0f;
			if(green> 1.0f)
				green = 1.0f;
			if(blue > 1.0f)
				blue = 1.0f;

			myRenderer.material.color = new Color (red, green, blue, 1.0f);
			//Debug.Log(this.transform.position.x);
			//Debug.Log(other.transform.position.x);

			float tempX = (this.transform.position.x + other.transform.position.x) / 2;
			//Debug.Log(tempX);
			float tempY = (this.transform.position.y + other.transform.position.y) / 2;
			float tempZ = (this.transform.position.z + other.transform.position.z) / 2;
			this.transform.position = new Vector3(tempX,tempY,tempZ);

			Destroy(other.gameObject);
		}else if(other.gameObject.tag == "Hole"){
			if(other.GetComponent<Hole>().red == red){
				if(other.GetComponent<Hole>().green == green){
					if(other.GetComponent<Hole>().blue == blue){
						winLevel();
					}
				}
			}
		}
	}



	void winLevel(){
		Application.LoadLevel (levelToLoad);

	}
}