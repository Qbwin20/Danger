using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquereMover : MonoBehaviour
{
    public float RotationSpead => _rotationSpead;
    public Vector3 EndPosition => _endPosition;
    [SerializeField] private float _startDiePosition;
    [SerializeField] private float _endDiePosition;
    [SerializeField] private Vector2 _endPosition;
    [SerializeField] private float _moveSpead;
    [SerializeField] private float _startRotationSpead;
    [SerializeField] private float _endRotationSpead;
    [SerializeField] private float _rotationSpead;
    private void Start() {
        _endPosition=SelectDiePoint(_startDiePosition,_endDiePosition);
        ChoseRotatinSpead();
    }
    private void ChoseRotatinSpead()
    {
        _rotationSpead=Random.Range(_startRotationSpead,_endRotationSpead);
    }
    private Vector2 SelectDiePoint(float StartDiePosition, float EndDiePosition)
    {
        return(new Vector2(4f,Random.Range(StartDiePosition,EndDiePosition)));
    }
    private void Move(Vector2 EndPosition)
    {
        transform.position= Vector2.MoveTowards(transform.position,EndPosition,_moveSpead/100);
    }
    private void Update() {
        Move(_endPosition);
    }
}
