using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public float xDelta = 0.1f;
	public float yDelta = 0.2f;
	public Vector3 hitPosition;
	public LineRenderer line;

	// Use this for initialization
	void Start () {
		gameObject.rigidbody.velocity = new Vector3(0.25f,0.25f,0f);
		line.renderer.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
					
		RaycastHit hit;
		
		if (Physics.Raycast(gameObject.transform.position, gameObject.rigidbody.velocity, out hit, 10)){
			line.renderer.enabled = true;
			line.SetPosition(1, gameObject.transform.InverseTransformPoint(hit.point));
		} else {
			line.renderer.enabled = false;
		}
		

	}

	
	void OnTriggerEnter(Collider col){
		Debug.Log ("OnTriggerEnter other object =" + col.name);
		
		if (col.name.Contains ("player")) {	
			gameObject.rigidbody.velocity = new Vector3(gameObject.rigidbody.velocity.x, -gameObject.rigidbody.velocity.y,gameObject.rigidbody.velocity.z);
		} else if (col.name.Contains ("Wall")) {
			gameObject.rigidbody.velocity = new Vector3(-gameObject.rigidbody.velocity.x, gameObject.rigidbody.velocity.y,gameObject.rigidbody.velocity.z);
		}
		
		RaycastHit hit;
		
		
		//check to see where we're going
		if (Physics.Raycast(gameObject.transform.position, gameObject.rigidbody.velocity, out hit, 10)){
		
			//spawn a countdown timer there
			Debug.Log(hit.point);
			Instantiate()
		}
			
		
		
		/*
		Vector3 test = new Vector3(gameObject.rigidbody.velocity.x * 10, 
		                           gameObject.rigidbody.velocity.y * 10,
		                           gameObject.rigidbody.velocity.z * 10);
		                           
		Debug.Log(test); */
		
		//line.SetPosition(1, test);
		
	}
}
