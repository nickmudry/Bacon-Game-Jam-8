using UnityEngine;
using System.Collections;

public class EggScript : MonoBehaviour {

    public GameObject yolkandstuff;
    public GameObject sm;

    public float speed = 10;
    public float durability = 100;

    SpriteRenderer eggSprite;

    public Sprite crack1;
    public Sprite crack2;
    public Sprite crack3;

	// Use this for initialization
	void Start () {
        eggSprite = gameObject.GetComponent<SpriteRenderer>();
        rigidbody2D.velocity = Vector2.one.normalized * speed;
	}

    void Update()
    {
        if (durability < 75)
        {
            eggSprite.sprite = crack1;
        }
        if (durability < 50)
        {
            eggSprite.sprite = crack2;
        }
        if (durability < 25)
        {
            eggSprite.sprite = crack3;
        }
        if (durability <= 0)
        {
            GameObject clone;
            clone = (GameObject)Instantiate(yolkandstuff, transform.position, transform.rotation);
            clone.transform.Rotate(new Vector3(0, 0, Random.Range(-360F, 360F)));
            clone.rigidbody2D.AddForce(new Vector2(Random.Range(-5F, 5F), Random.Range(-5F, 5F) * speed));
            Destroy(clone.gameObject, 1F);
            Destroy(gameObject, 2F);
        }
    }

    void RefreshSpeed()
    {
        Debug.Log("egghit");
        durability -= Random.Range(10F, 15F);
        speed = 10;
    }

    void OnTriggerEnter(Collider trg)
    {
        if (trg.collider.tag == "player2scores")
        {
            sm.SendMessage("P2Increase");
        }
        if (trg.collider.tag == "player1scores")
        {
            sm.SendMessage("P1Increase");
        }
    }
}
