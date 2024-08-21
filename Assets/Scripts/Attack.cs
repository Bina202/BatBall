using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Image;

public class Attack : MonoBehaviour
{
    private int point = 0;
    public Text pointTxt;
    public Text pointEnd;
    private bool isEnter = false;
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointTxt.text=point.ToString();
        pointEnd.text = pointTxt.text;
        if (isEnter && Input.GetMouseButtonDown(1))
        {
            point++;
            Destroy(enemy);
            isEnter = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            isEnter = true;
            enemy = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isEnter = false;
    }
}
