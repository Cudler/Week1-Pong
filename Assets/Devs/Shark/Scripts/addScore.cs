using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class addScore : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;
    int score;
    BoxCollider2D killBox;
    void Start()
    {
       killBox = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        collision.gameObject.transform.position = Vector3.zero;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
