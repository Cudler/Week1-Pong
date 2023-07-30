using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarcusJunk {
    public class ball_mov : MonoBehaviour
    {
        Rigidbody2D ball; //creating rigidbody for ball
        public float ballSpeed = 180;

        public Vector2 RandomVector2(float angle, float angleMin)
        {
            float random = Random.value * angle + angleMin;
            return new Vector2(Mathf.Cos(random), Mathf.Sin(random));
        }


        // Start is called before the first frame update
        void Start()
        {
            ball = GetComponent<Rigidbody2D>(); //setting components for rigidbody at update
        }

        // Update is called once per frame
        void Update()
        {

            if (transform.position == Vector3.zero && Input.GetKeyDown(KeyCode.Space))
            {
                ball.AddForce(RandomVector2(Random.Range(1, 360), 1) * ballSpeed);
            }
        }
    }
}


