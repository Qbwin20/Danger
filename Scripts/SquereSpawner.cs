using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquereSpawner : MonoBehaviour
{
    
    [SerializeField] private GameObject[] _squersWhite;
    [SerializeField] private GameObject[] _squersOrange;
    [SerializeField] private Vector3 _spawnPosition;
    [SerializeField] private float _startSpawnRange;
    [SerializeField] private float _endSpawnRange;
    [SerializeField] private GameObject _squereWhite;
    [SerializeField] private GameObject _squereOrange;


    private void Awake() {
        ArrayMaker(_squersWhite,_squereWhite);
        ArrayMaker(_squersOrange,_squereOrange);
    }
    private void ArrayMaker(GameObject[] Squeres,GameObject Squere)
    {
        for(int i=0; i<Squeres.Length;i++)
        {
            GameObject TempObject = (GameObject)Instantiate(Squere);
            TempObject.SetActive(false);
            Squeres[i]=TempObject;
        }
    }
    private Vector3 SelectSpawnPoint(float StartSpawnRange, float EndSpawnRange)
    {
        return(new Vector3(-4f,Random.Range(StartSpawnRange,EndSpawnRange)));
    }
    private void RandomChose()
    {
        int TempRandom = Random.Range(0,100);
        if(TempRandom<30)
        {
            SqueresActive(_squersOrange);
        }
        else
        {
            SqueresActive(_squersWhite);
        }
    }
    private void SqueresActive(GameObject[] Squeres)
    {
        for(int i=0; i<Squeres.Length;i++)
        {
            if(!Squeres[i].activeInHierarchy)
            {
                Squeres[i].transform.position=SelectSpawnPoint(_startSpawnRange,_endSpawnRange);
                Squeres[i].SetActive(true);
                break;
            }
        }
        CancelInvoke();
    }
    private void Update() 
    {
        InvokeRepeating(nameof(RandomChose),1,0);
    }
 
}
