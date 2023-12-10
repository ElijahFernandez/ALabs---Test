using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    public float speed = 10f; // Adjust the speed as needed
    public string value;
    [SerializeField] private TMP_Text boxText;
    public bool hasStarted = false;
    private void Start()
    {
        boxText.text = value;
    }
    void Update()
    {
        if (hasStarted)
        {
            // Move the object to the right based on the speed and deltaTime
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        
    }

    
}
