using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pongMouvment : MonoBehaviour {

    public float speed = 10f;
    public Rigidbody2D rb;
    public Text scoreUI;

    int score = 0;

	// Use this for initialization
	void Start () {
        rb.AddForce(Vector2.up*speed);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        score = score + 1;
        scoreUI.text = score.ToString();

    }
}
