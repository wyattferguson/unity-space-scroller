using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController instance;

    public Text scoreText;
    public Text endText;

    private void Awake() {
        if(instance == null) {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {
		
	}

}
