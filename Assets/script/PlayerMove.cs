using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector2 direction = Vector2.zero;
    public List<string> sInput;
    public float speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(sInput[0]))
            direction = Vector2.up;
        if (Input.GetKeyDown(sInput[1]))
            direction = Vector2.down;
        if (Input.GetKeyDown(sInput[2]))
            direction = Vector2.left;
        if (Input.GetKeyDown(sInput[3]))
            direction = Vector2.right;
    }

    private void FixedUpdate()
    {
        this.transform.position = new Vector3(
            this.transform.position.x + direction.x * speed * Time.deltaTime,
            this.transform.position.y + direction.y * speed * Time.deltaTime,
            0.0f
            );
    }
}
