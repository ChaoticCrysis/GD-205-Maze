using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerControl : MonoBehaviour
{
    int health = 10;
    public TMP_Text healthText;


    public float speed = 5f;
    

    

    // Start is called before the first frame update
    void Start()
    {
       

        healthText.text = health.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;



        if (Input.GetKey(KeyCode.W))
        {  currentPos.z = currentPos.z + speed * Time.deltaTime; }  


        if (Input.GetKey(KeyCode.A))
        {  currentPos.x = currentPos.x - speed * Time.deltaTime; }  

        if (Input.GetKey(KeyCode.S))
        { currentPos.z = currentPos.z - speed * Time.deltaTime; }   

        if (Input.GetKey(KeyCode.D))
        { currentPos.x = currentPos.x + speed * Time.deltaTime; }

        transform.position = currentPos;




    }

    void OnCollisionEnter(Collision otherThing)
    { 
        Debug.Log(otherThing.gameObject.name);
        if(otherThing.gameObject.name == "Enemy" )
        {
            health--;
            healthText.text = health.ToString();
            }
    }

}

