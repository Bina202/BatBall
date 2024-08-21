using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator myAnim;
    private float maxHealth = 100;
    private float health;
    public Image healBar;
    public GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetMouseButtonDown(1))
        {
            myAnim.Play("AttAnim");
        }
        healBar.fillAmount = health/100;
        if (health <=0)
        {
            gameController.GetComponent<GameController>().EndGame();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Enemy"))
        {
            health -= 20;
        }
        if(collision.gameObject.tag.Equals("PowerUp"))
        {
            health += 10;
            if (health >100)
            {
                health = maxHealth;
            }
            Destroy(collision.gameObject);
        }
    }
}
