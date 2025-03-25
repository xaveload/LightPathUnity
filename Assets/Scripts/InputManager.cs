using System;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

 
    [SerializeField] private float mouseSpeed = 8f;
    [SerializeField] private float playerSpeed = 5.5f;

    private bool skillActivated_1;
    private bool skillActivated_2;
 
    
    private float mouseX = 0f;
    private float mouseY = 0f;


    void Start()
    {
        skillActivated_1 = false;
        skillActivated_2 = false;
    }


    void Update()
    {
        CharMovement();
        CharRotation();
        ActiveSkill();
    }

    

    void CharMovement()
    {
        // movement
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * playerSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * playerSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * playerSpeed);
        }

        // Dash
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerSpeed = 11f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed = 5.5f;
        }

        // Levitation
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Translate(Vector3.up*Time.deltaTime*playerSpeed);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Translate(Vector3.down*Time.deltaTime*playerSpeed);
        }
    }


    void CharRotation()
    {
        mouseX += Input.GetAxis("Mouse X");
        mouseY += Input.GetAxis("Mouse Y");
    }


    void ActiveSkill()
    {
        if (Input.GetKeyDown("space"))
        {
            try
            {
                GameObject.Find("Char").transform.Find("MagicCircle").gameObject.SetActive(true);

            }
            catch (NullReferenceException ex)
            {

            }
        }

    }
}
