using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController instance;
    public bool isDead = false;

    private int spawnRate = 3;
    private float scoreRate = 0.5f;
    private float scoreBuffer = 0;
    private int score = 0;

    public Text scoreText;
    public Text endText;

    private void Awake() {
        if(instance == null) {
            instance = this;
        }
    }

    public void PlayerCrash() {
        this.isDead = true;
        endText.gameObject.SetActive(true);
    }

    private void Update() {
        if (this.isDead == false) {
            if(this.scoreBuffer > this.scoreRate) {
                this.score += 1;
                this.scoreBuffer = 0;
                scoreText.text = "Score: " + this.score;
            }
            this.scoreBuffer += Time.deltaTime;
            Debug.Log(this.scoreBuffer + " " + this.score);
        }
    }

}
