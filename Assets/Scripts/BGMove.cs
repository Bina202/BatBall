using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    private GameObject obj;
    private int moveSpeed = 5;
    private int moveRange = 20;
    private Vector2 oldPos;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        oldPos = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        obj.transform.Translate(new Vector2(-1 * Time.deltaTime * moveSpeed, obj.transform.position.y));
        if (obj.transform.position.x < -(oldPos.x + moveRange))
        {
            obj.transform.position = oldPos;
        }
    }
}
