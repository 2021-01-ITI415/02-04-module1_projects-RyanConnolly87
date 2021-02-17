using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 0;
    public GameObject loseTextObject;
    public GameObject player;


    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        loseTextObject.SetActive(false);
        player.SetActive(true);
    }
    
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        if (count == 1)
        {
            loseTextObject.SetActive(true);
            player.SetActive(false);
        }
    }


    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
    
            SetCountText();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
