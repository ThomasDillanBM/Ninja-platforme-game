using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bau : MonoBehaviour {
    public GameObject tick;
    public int ticks;
    private int obtain;
	// Use this for initialization
	void Start () {
        
        obtain = 0;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && obtain < ticks)
        {
           
            obtain += 1;
            GetComponent<Animator>().SetTrigger("open");
            Instantiate(tick, transform.position, transform.rotation);
        }
    }


}
