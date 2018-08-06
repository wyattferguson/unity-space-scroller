using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
 
    private float speed = 12f;

    private Vector2 screenTop;
    private Vector2 screenBottom;

    private float shipHeight;

	// Use this for initialization
	void Start () {
        this.screenBottom = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        this.screenTop = Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height));
        this.shipHeight = transform.localScale.y / 2;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Vertical")) {
            float move = Input.GetAxis("Vertical") * Time.deltaTime * this.speed;
            float shipY = transform.position.y;

            if (shipY > this.screenTop.y - this.shipHeight && move > 0) {
                move = 0;
            }

            if (shipY < this.screenBottom.y + this.shipHeight && move < 0) {
                move = 0;
            }

            transform.Translate(move * Vector2.up);

            Debug.Log(shipY + " " + this.screenTop.y + " " + this.screenBottom.y);
        }
	}
}
