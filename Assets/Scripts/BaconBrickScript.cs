using UnityEngine;
using System.Collections;

public class BaconBrickScript : MonoBehaviour {

	void Start () {
	
	}
	
    void Update()
    {

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
            col.gameObject.SendMessage("RefreshSpeed");
        }
    }
}
