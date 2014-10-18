using UnityEngine;
using System.Collections;

public class EggScript : MonoBehaviour {

    public GameObject yolkandstuff;

    public float speed;
    public float durability = 100;

    SpriteRenderer eggSprite;

    public Sprite crack1;
    public Sprite crack2;
    public Sprite crack3;

	// Use this for initialization
	void Start () {
        eggSprite = gameObject.GetComponent<SpriteRenderer>();

        speed = Random.Range(2F, 5F);
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
            Instantiate(yolkandstuff, transform.position, transform.rotation);
            Destroy(gameObject, 5);
        }
    }

    void RefreshSpeed()
    {
        Debug.Log("egghit");
        durability -= Random.Range(10F, 15F);
        speed = 5;
    }
}
