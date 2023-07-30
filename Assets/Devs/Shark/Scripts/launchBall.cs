using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Azure
{
    public class launchBall : MonoBehaviour
    {
        // Start is called before the first frame update
        Rigidbody2D ball;
        public float ballSpeed = 20;

        private void Start()
        {
            ball = GetComponent<Rigidbody2D>();
        }
        public Vector2 RandomVector2(float angle, float angleMin)
        {
            float random = Random.value * angle + angleMin;
            return new Vector2(Mathf.Cos(random), Mathf.Sin(random));
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