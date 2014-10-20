using UnityEngine;
using System.Collections;

public class BaconBrickScript : MonoBehaviour {
	public float moveSpeed = .2f; //Movement speed for the bacon brick.
	public bool isPlayerOne;

    public GameObject player1sound;
    public GameObject player2sound;

	void Start () {
	
	}
	
    void Update()
    {
		if (Input.GetKey(KeyCode.W) && isPlayerOne)
		{
			gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + Time.timeScale * moveSpeed);
		}
		if (Input.GetKey (KeyCode.S) && isPlayerOne)
		{
			gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - Time.timeScale * moveSpeed);
		}
		if (Input.GetKey (KeyCode.UpArrow) && !isPlayerOne)
		{
			gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + Time.timeScale * moveSpeed);
		}
		if (Input.GetKey (KeyCode.DownArrow) && !isPlayerOne)
		{
			gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - Time.timeScale * moveSpeed);
		}

		if (gameObject.transform.position.y >= 4.5f)
		{
			gameObject.transform.position = new Vector2(gameObject.transform.position.x, 4.5f);
		}
		if (gameObject.transform.position.y <= -4.5f)
		{
			gameObject.transform.position = new Vector2(gameObject.transform.position.x, -4.5f);
		}

    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, mousePosition.y);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "egg")
        {
            if (isPlayerOne)
            {
                player1sound.audio.Play();
            }
            else if (!isPlayerOne)
            {
                player2sound.audio.Play();
            }
            col.gameObject.SendMessage("RefreshSpeed");
        }
    }
}
