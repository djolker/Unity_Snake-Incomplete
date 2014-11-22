﻿using UnityEngine;
using System.Collections;

public class GMController : MonoBehaviour {

    public GameObject enemy;
    public Object currentEnemy;
    public Object player;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (currentEnemy == null)
        {
            //currentEnemy = Instantiate(enemy, JumpToNewPosition(), this.transform.rotation);
        }

        if (player == null)
        {
            GameOver();
        }
	}

    /// <summary>
    /// Jumps to new position.
    /// </summary>
    Vector3 JumpToNewPosition()
    {
        System.Random rand = new System.Random ();
        float x = float.Parse(rand.Next (-3, 13).ToString());
        float z = float.Parse(rand.Next (-3, 13).ToString());
        
        Vector3 vec = new Vector3 ();
        vec.x = x;
        vec.z = z;
        vec.y = .98f;

        return vec;
    }

    void GameOver()
    {
        //GUIText gameOver = new GUIText();
        //gameOver.text = "Game Over!";
        //gameOver.enabled = true;
        Application.Quit();
    }
}
