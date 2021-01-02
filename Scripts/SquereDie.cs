using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquereDie : MonoBehaviour
{
    [SerializeField] private SquereMover _squreMover;
    private bool FinishCheck()
    {
        return(transform.position==_squreMover.EndPosition);
    }
    private void Update() {
        if(FinishCheck())
        {
            gameObject.SetActive(false);
        }
    }
}
