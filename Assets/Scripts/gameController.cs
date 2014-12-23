using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

	//move these to their own scripts
	public string currentPlayer;

	//player data
	Transform paddlePosition;
	int energy;

	//ball state
	Transform currentPosition;
	ArrayList previousPositions;


	// Use this for initialization
	void Start () {
		previousPositions = new ArrayList ();
		DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			Debug.Log ("Pressed left click.");
		}
	
	}
	
}
