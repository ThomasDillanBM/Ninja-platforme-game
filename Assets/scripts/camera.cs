using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    public Transform player;
    //Tecnical adjust for the camera position
    public float adjustX;
    public float adjustY;
    public float adjustTime;

    public int life;
    public int key;
    public SpriteRenderer cor1, cor2, cor3, cor4, cor5, nubmer1, number2;

    public Sprite full, med, empty, n0, n1, n2, n3, n4, n5, n6, n7, n8, n9;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        life = 10;
        key = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {

        lifeController();
        ticketController();
        checkPlayerLive();
        Vector3 newPosition = new Vector3(player.position.x + adjustX, player.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime + adjustTime);
        if(life <= 0)   Application.LoadLevel(Application.loadedLevel);
        
    }

    void checkPlayerLive()
    {
        if(player == null)
        {
            updatePlayer();
        }
    }

    public void gainTicket()
    {    
      this.key += 1;
    }

    public void updatePlayer()
    {
        GameObject obje = GameObject.FindGameObjectWithTag("Player");
        if (obje == null)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        player = obje.GetComponent<Transform>();
       
    
    }

    public void takeDam()
    {
        life -= 1;
    }

    public void gainlife()
    {
        life += 1;
    }

    void ticketController()
    {
        if (key == 0)
        {
            nubmer1.gameObject.SetActive(false);
            number2.sprite = n0;
        }else if (key == 1)
        {
            nubmer1.gameObject.SetActive(false);
            number2.sprite = n1;
        }
        else if (key == 2)
        {
            nubmer1.gameObject.SetActive(false);
            number2.sprite = n2;
        }
        else if (key == 3)
        {
            nubmer1.gameObject.SetActive(false);
            number2.sprite = n3;
        }
        else if (key == 4)
        {
            nubmer1.gameObject.SetActive(false);
            number2.sprite = n4;
        }
        else if (key == 5)
        {
            nubmer1.gameObject.SetActive(false);
            number2.sprite = n5;
        }
        else if (key == 6)
        {
            nubmer1.gameObject.SetActive(false);
            number2.sprite = n6;
        }
        else if (key == 7)
        {
            nubmer1.gameObject.SetActive(false);
            number2.sprite = n7;
        }
        else if (key == 8)
        {
            nubmer1.gameObject.SetActive(false);
            number2.sprite = n8;
        }
        else if (key == 9)
        {
            nubmer1.gameObject.SetActive(false);
            number2.sprite = n9;
        }
        else if (key == 10)
        {
            nubmer1.gameObject.SetActive(true);
            number2.sprite = n0;
        }
    }

    void lifeController()
    {
        if (life == 10)
        {
            cor1.sprite = full;
            cor2.sprite = full;
            cor3.sprite = full;
            cor4.sprite = full;
            cor5.sprite = full;
        }
        else if (life == 9)
        {
            cor1.sprite = full;
            cor2.sprite = full;
            cor3.sprite = full;
            cor4.sprite = full;
            cor5.sprite = med;
        }
        else if (life == 8)
        {
            cor1.sprite = full;
            cor2.sprite = full;
            cor3.sprite = full;
            cor4.sprite = full;
            cor5.sprite = empty;
        }
        else if (life == 7)
        {
            cor1.sprite = full;
            cor2.sprite = full;
            cor3.sprite = full;
            cor4.sprite = med;
            cor5.sprite = empty;
        }
        else if (life == 6)
        {
            cor1.sprite = full;
            cor2.sprite = full;
            cor3.sprite = full;
            cor4.sprite = empty;
            cor5.sprite = empty;
        }
        else if (life == 5)
        {
            cor1.sprite = full;
            cor2.sprite = full;
            cor3.sprite = med;
            cor4.sprite = empty;
            cor5.sprite = empty;
        }
        else if (life == 4)
        {
            cor1.sprite = full;
            cor2.sprite = full;
            cor3.sprite = empty;
            cor4.sprite = empty;
            cor5.sprite = empty;
        }
        else if (life == 3)
        {
            cor1.sprite = full;
            cor2.sprite = med;
            cor3.sprite = empty;
            cor4.sprite = empty;
            cor5.sprite = empty;
        }
        else if (life == 2)
        {
            cor1.sprite = full;
            cor2.sprite = empty;
            cor3.sprite = empty;
            cor4.sprite = empty;
            cor5.sprite = empty;
        }
        else if (life == 1)
        {
            cor1.sprite = med;
            cor2.sprite = empty;
            cor3.sprite = empty;
            cor4.sprite = empty;
            cor5.sprite = empty;
        }
        else if (life == 0)
        {
            cor1.sprite = empty;
            cor2.sprite = empty;
            cor3.sprite = empty;
            cor4.sprite = empty;
            cor5.sprite = empty;

        }
    }

}
