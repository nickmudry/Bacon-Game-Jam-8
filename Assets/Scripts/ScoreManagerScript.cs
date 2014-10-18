using UnityEngine;
using System.Collections;

public class ScoreManagerScript : MonoBehaviour {
    public float player1score;
    public float player2score;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        guiText.text = player1score + " | " + player2score;

	}

    void P1Increase()
    {
        Debug.Log("P1scores");
        player1score += 1;
    }

    void P2Increase()
    {
        player2score += 1;
    }
}
