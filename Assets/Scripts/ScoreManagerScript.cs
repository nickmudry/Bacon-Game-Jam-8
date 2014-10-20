using UnityEngine;
using System.Collections;

public class ScoreManagerScript : MonoBehaviour {
    public float player1score;
	public float player2score;
	public float endGameScore;

	GameObject eggSpawner;
	
	// Use this for initialization
	void Start () {
		eggSpawner = GameObject.Find("EggSpawner");
	}
	
	// Update is called once per frame
	void Update () {
        guiText.text = player1score + " | " + player2score;

		if (player1score >= endGameScore)
		{
			OnPlayerWin("Player 1");
		}
		if (player2score >= endGameScore)
		{
			OnPlayerWin("Player 2");
		}

		if (Input.GetKeyDown(KeyCode.R))
		{
			Application.LoadLevel("test"); //Reload The Level To Scene Test 
		}
		if (Input.GetKeyDown(KeyCode.Z))
		{
			Application.CaptureScreenshot("Screenshots/BaconDuel-" + System.DateTime.Today.ToLongTimeString() + ".png");
		}

	}

	void OnPlayerWin(string winner) {
		guiText.text = "Congrats " + winner + "! \n Press 'R' to Restart!";
		eggSpawner.SendMessage("GameOver", true);
	}

    void P1Increase()
    {
        audio.Play();
        player1score += 1;
    }

    void P2Increase()
    {
        audio.Play();
        player2score += 1;
    }
}
