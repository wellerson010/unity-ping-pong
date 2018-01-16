using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float Speed = 30;

	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * Speed;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string name = collision.gameObject.name;
        if (name == "RacketLeft" || name == "RacketRight")
        {
            float factor = HitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);

            Vector2 direction = new Vector2((name == "RacketLeft") ? 1 : -1, factor).normalized;

            GetComponent<Rigidbody2D>().velocity = direction * Speed;
        }
    }

    private float HitFactor(Vector2 ballPosition, Vector2 racketPosition, float racketHeight)
    {
        return (ballPosition.y - racketPosition.y) / racketHeight;
    }
}
