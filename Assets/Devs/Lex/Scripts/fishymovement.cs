using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Goatspaghetti
{
    public class fishymovement : MonoBehaviour
    {
        public float spd;
        public Transform player1, player2;

        // Update is called once per frame
        void Update()
        {
            //player 1 movement
            if(Input.GetKey(KeyCode.W))
            {
                player1.position = player1.position + new Vector3(0, spd, 0);
            }
            if(Input.GetKey(KeyCode.S))
            {
                player1.position = player1.position - new Vector3(0, spd, 0);
            }

            //clamping player1 to screen
            player1.position = new Vector3(player1.position.x, Mathf.Clamp(player1.position.y, -5, 3.1f), player1.position.z);
            
            //player 2 movement
            if(Input.GetKey(KeyCode.I))
            {
                player2.position = player2.position + new Vector3(0, spd, 0);
            }

            if(Input.GetKey(KeyCode.K))
            {
                player2.position = player2.position - new Vector3(0, spd, 0);
            }

            //clamping player2 to screen
            player2.position = new Vector3(player2.position.x, Mathf.Clamp(player2.position.y, -5, 3.1f), player2.position.z);
        }
    }

}
