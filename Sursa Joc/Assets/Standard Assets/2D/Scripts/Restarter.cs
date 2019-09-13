using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {

        public Animator player;
        public SpriteRenderer sprite;
        public GameObject playerObject;
        public PlatformerCharacter2D playerPlatformer;

        private void Start()
        {
            playerObject = GameObject.Find("CharacterRobotBoy");
            player = playerObject.GetComponent<Animator>();
            playerPlatformer = playerObject.GetComponent<PlatformerCharacter2D>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                if (!player.GetBool("Dead"))
                {
                    sprite.enabled = false;
                    player.SetBool("Dead", true);

                }


                playerPlatformer.dead = true;

         
            
                

                Application.LoadLevel("final");
            }
            
        }

    }
}
    

