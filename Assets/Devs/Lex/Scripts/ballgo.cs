using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Goatspaghetti
{

    public class ballgo : MonoBehaviour
    {
        public float speed = 1;
        Rigidbody2D ball;
        
                
        // Start is called before the first frame update
        void Start()
        {
            ball = GetComponent<Rigidbody2D> ();
        }

        public Vector2 RandomVector2(float angle, float angleMin)
        {
            float random = Random.value * angle + angleMin;
            return new Vector2(Mathf.Cos(random), Mathf.Sin(random));
        }

        // Update is called once per frame
        void Update()
        {
            Vector2 ang = new Vector2(1, 2);
            if(transform.position == Vector3.zero && Input.GetKeyDown(KeyCode.Space))
            {
                ball.AddForce(RandomVector2(Random.Range(1,360),1) * speed,ForceMode2D.Impulse);
            }
        }
    }
}