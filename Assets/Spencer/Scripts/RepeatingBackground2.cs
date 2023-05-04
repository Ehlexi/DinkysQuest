using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground2 : MonoBehaviour
{
    private SpriteRenderer sr;
    
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
       
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * 5);
        if (transform.position.x < -sr.bounds.size.x/2);
        {
            transform.position = new Vector3(sr.bounds.size.x, transform.position.y, transform.position.z);
        }
    }
}