using UnityEngine;
using System.Collections;

public class loadSceneBtn : MonoBehaviour {

	public string sceneToLoad;
	public string playerName;
	public gameController gameController;

	// Use this for initialization
	void Start () {
	
	}

	void OnMouseDown(){
		Debug.Log("loading " + sceneToLoad);

		if (playerName != string.Empty) {
			gameController.currentPlayer = playerName;
		}

		Application.LoadLevel (sceneToLoad);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
