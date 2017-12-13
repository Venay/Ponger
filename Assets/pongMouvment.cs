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

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ponger")
        {
            score = score + 1;
            if (score >= 10 && score < 100)
            {
                scoreUI.fontSize = 160;
            }
            scoreUI.text = score.ToString();
            speed = speed * 1.1f;
            Debug.Log(transform.position);
        }
        

    }
}
