using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MarcusJunk
{
    public class fish_mov : MonoBehaviour
    {
        public int speed; //speed, the integer that we're using for the movement.
        public Transform player1, player2; //transform function, translates/transforms objects.

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.W)) //when user presses w
            {
                player1.position = player1.position + new Vector3(0, speed * 0.01f, 0); //change p1 position upwards at a modified speed
            }
            if (Input.GetKey(KeyCode.S)) //when user presses s
            {
                player1.position = player1.position - new Vector3(0, speed * 0.01f, 0); //change p1 position downwards at a modified speed
            }

            if (Input.GetKey(KeyCode.I)) //when user presses i
            {
                player2.position = player2.position + new Vector3(0, speed*0.01f, 0); //change p2 position upwards at a modified speed
            }
            if (Input.GetKey(KeyCode.K)) //when user presses k
            {
                player2.position = player2.position - new Vector3(0, speed*0.01f, 0); //change p2 position downwards at a modified speed
            }
        }

    
    }

}
