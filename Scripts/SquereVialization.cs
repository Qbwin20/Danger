using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquereVialization : MonoBehaviour
{
    [SerializeField] private SquereMover _squereMover;
    private void squereRotation()
    {
        gameObject.transform.Rotate(0f,0f,_squereMover.RotationSpead);
    }
    private void Update() {
        squereRotation();
    }
}
