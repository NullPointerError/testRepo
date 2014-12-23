using UnityEngine;
using System.Collections;

public class playerPaddle : MonoBehaviour {

	public Vector3 targetPosition;
	public float playerMoveSpeed = 0.01f;
	// Use this for initialization
	void Start () {
		targetPosition = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 10)) {
				//draw invisible ray cast/vector
				Debug.DrawLine (ray.origin, hit.point);
				//log hit area to the console
				//Debug.Log(hit.point);
				targetPosition = hit.point;
			}
		}
		
		if (Mathf.Abs(targetPosition.x - gameObject.transform.position.x) > .05){
			//move towards the target x position
			if (targetPosition.x < gameObject.transform.position.x){
				gameObject.transform.position = new Vector3(gameObject.transform.position.x - playerMoveSpeed, 
															gameObject.transform.position.y,
															gameObject.transform.position.z);
			} else if (targetPosition.x > gameObject.transform.position.x){
				gameObject.transform.position = new Vector3(gameObject.transform.position.x + playerMoveSpeed, 
				                                            gameObject.transform.position.y,
				                                            gameObject.transform.position.z);
				
			}
		}
			
	}
}
