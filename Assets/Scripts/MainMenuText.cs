using UnityEngine;
using System.Collections;

public class MainMenuText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		guiText.text = "Bacon Duel \n" +
						"Press 'Space' To Start! \n" +
						"\n" +
						"Credits: \n" +
						"Jacob Peltola - Code, Art, Sound \n" +
						"Nick Mudry - Code, Game Design";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Application.LoadLevel("test");
		}
	}
}
