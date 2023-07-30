using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Azure { 
public class Movement : MonoBehaviour
{

        public float speed = 1;
        public Transform player1, player2;
        public float top = 3.1f, bottom = -5f;

    // Update is called once per frame
    void Update()
    {
            //Player 1 Controls
            if (Input.GetKey(KeyCode.W))
            {

                player1.position = player1.position + new Vector3(0, speed, 0);

            }
            if (Input.GetKey(KeyCode.S))
            {

                player1.position = player1.position - new Vector3(0, speed, 0);

            }

            player1.position = new Vector3(player1.position.x, Mathf.Clamp(player1.position.y, bottom, top), 0);
            //Player 2 Controls

            if (Input.GetKey(KeyCode.I))
            {

                player2.position = player2.position + new Vector3(0, speed, 0);

            }
            if (Input.GetKey(KeyCode.K))
            {

                player2.position = player2.position - new Vector3(0, speed, 0);

            }
            player2.position = new Vector3(player2.position.x, Mathf.Clamp(player2.position.y, bottom, top), 0);

        }
}

}