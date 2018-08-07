﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroids : MonoBehaviour {

    public GameObject astroidPrefab;

    private GameObject[] astroids;

    private int maxAstroids = 15;
    private float spawnRate = 3f;
    private float spawnDelay = 0f;
    private float minSpawnY = -3.65f;
    private float maxSpawnY = 3.65f;
    private float spawnX = 12.0f;
    private int recentAstroid = 0;

    private float scaleMin = 0.10f;
    private float scaleMax = 1.0f;

	// Use this for initialization
	void Start () {
        Vector2 startPos = new Vector2(20, 20);
        astroids = new GameObject[maxAstroids];
        for (int i = 0; i < maxAstroids; i++) {
            astroids[i] = (GameObject)Instantiate(astroidPrefab, startPos, Quaternion.identity);
        }
        
    }
	
	// Update is called once per frame
	void Update () {
        spawnDelay += Time.deltaTime;
        if (spawnDelay >= spawnRate) {
            spawnDelay = 0;
            float spawnY = Random.Range(minSpawnY, maxSpawnY);
            float adjScale = Random.Range(scaleMin, scaleMax);
            astroids[recentAstroid].transform.position = new Vector2(spawnX, spawnY);
            astroids[recentAstroid].transform.localScale = new Vector3(adjScale, adjScale, 1);

            recentAstroid++;

            if (recentAstroid >= maxAstroids) {
                recentAstroid = 0;
            }
        }
    }
}
