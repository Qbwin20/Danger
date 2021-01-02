using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D Player) {
        if(Player.gameObject.GetComponent<PlayerMover>()!=null)
        {
            //Player.gameObject.SetActive(false);
            Player.transform.position=new Vector2(0f,-4f);
            gameObject.SetActive(false);
        }
    }
}
