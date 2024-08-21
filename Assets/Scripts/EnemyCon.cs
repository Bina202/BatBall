using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class WallMove : MonoBehaviour
{
    private float moveSpeed = 5;
    private GameObject obj;
    private Vector2 oldpos;
    private int point;

    // Start is called before the first frame update
    void Start()
    {
        point = 0;
        obj = gameObject;
        oldpos = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(-1 * Time.deltaTime * moveSpeed, 0, 0);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("WallR"))
        {
            Destroy(obj);
        }
    }
}
