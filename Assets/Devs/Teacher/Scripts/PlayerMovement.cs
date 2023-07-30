using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BearCode
{
    public class PlayerMovement : MonoBehaviour
    {
        public float spd;
        public Transform player1, player2;

        void Update()
        {
            //Input to move player 1
            if(Input.GetKey(KeyCode.W))
            {
                player1.position = player1.position + new Vector3(0, .01f * spd, 0);
            }
            if(Input.GetKey(KeyCode.S))
            {
                player1.position = player1.position - new Vector3(0, .01f * spd, 0);
            }
            //Clamping the player1 to the screen
            player1.position = new Vector3(player1.position.x, Mathf.Clamp(player1.position.y, -5, 3.1f), player1.position.z);

            //Input to move player 2 
            if(Input.GetKey(KeyCode.I))
            {
                player2.position = player2.position + new Vector3( 0, .01f * spd, 0);
            }
            if(Input.GetKey(KeyCode.K))
            {
                player2.position = player2.position - new Vector3(0, .01f * spd, 0);
            }
            //Clamping the player2 to the screen
            player2.position = new Vector3(player2.position.x, Mathf.Clamp(player2.position.y, -5, 3.1f), player2.position.z);


        }
    }
}
