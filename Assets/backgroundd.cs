using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundd : MonoBehaviour {
    public GameObject player;
    public float step;
	// Use this for initialization
	void Start ()
    {
        

    }
	
	// Update is called once per frame
	void Update ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player.GetComponent<ninja>().movingLeft)
        {
            transform.Translate(Vector2.right * step);
        }else if (player.GetComponent<ninja>().movingRight)
        {
            transform.Translate(Vector2.left * step);
        }

    }
}
