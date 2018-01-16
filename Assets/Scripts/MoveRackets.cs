using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRackets : MonoBehaviour {
    public float Speed = 30;
    public string Axis = "Vertical";

    void FixedUpdate()
    {
        float velocity = Input.GetAxisRaw(Axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, velocity * Speed);
    }
}
