using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class EnemyControl : MonoBehaviour
{
    public float speed;
    public Transform start;
    public Transform end;

    Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = end.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = MoveEnemy();
    }
    Vector3 MoveEnemy()
    {
        float distance = Vector3.Distance(transform.position, target);
        float step = speed * Time.deltaTime;
        if (distance < 0.1)
        {
            if (target == end.position)
            {
                target = start.position;
            }
            else if (target == start.position)
            {
                target = end.position;
            }



        }
        return Vector3.MoveTowards(transform.position, target, step);
    }
}

