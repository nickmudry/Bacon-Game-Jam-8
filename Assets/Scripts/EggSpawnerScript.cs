using UnityEngine;
using System.Collections;

public class EggSpawnerScript : MonoBehaviour {
	float timer;
	public float timeToSpawn;
	public bool spawnOnTimer;
	public bool gameOver;

	public GameObject objectToSpawn;
	public Vector3 spawnLocation;
	public Quaternion spawnQuaternion;

	// Use this for initialization
	void Start () {
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= timeToSpawn)
		{
			Spawn();
			timer = 0f;
		}
	}

	public void Spawn () {
		if (!gameOver)
		{
			GameObject spawnedObject = (GameObject)Instantiate(objectToSpawn, spawnLocation, spawnQuaternion);
		}
	}

	void GameOver (bool gameOverSend) {
		gameOver = gameOverSend;
	}
}
