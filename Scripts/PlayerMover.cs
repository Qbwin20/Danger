using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private PlayerControl _playerControl;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _moveSpead=0f;
    [SerializeField] private Vector2 _moveDirection;

    private void Update() 
    {
        Move(_moveSpead,_rigidbody,_moveDirection);
    }

    private void Move(float MoveSpead, Rigidbody2D Rigidbody, Vector2 MoveDirection)
    {
        if(_playerControl.KeyDown)
        {
            _moveDirection=new Vector2(MoveDirection.x*-1,_moveDirection.y);
        }
        Rigidbody.velocity=MoveDirection*MoveSpead;
    }
    private void OnCollisionEnter2D(Collision2D Border) 
    {
        switch(Border.gameObject.layer)
        {
            case 3:
            _moveDirection=new Vector2(_moveDirection.x,_moveDirection.y*-1);
            break;
            case 6:
            _moveDirection=new Vector2(_moveDirection.x*-1,_moveDirection.y);
            break;
        }
    }
}