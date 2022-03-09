using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findeJeu : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            text.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
}
