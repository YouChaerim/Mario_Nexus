using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RanPresent : MonoBehaviour
{
    public GameObject rangeObject;
    BoxCollider rangeCollider;
    public GameObject present;

    private void Awake(){
        rangeCollider = rangeObject.GetComponent<BoxCollider>();
    }

    Vector3 Return_RandomPosition(){
        Vector3 originPosition = rangeObject.transform.position;
        float range_X = rangeCollider.bounds.size.x;
        float range_Z = rangeCollider.bounds.size.z;

        range_X = Random.Range((range_X / 2) * -1, range_X / 2);
        range_Z = Random.Range((range_Z / 2) * -1, range_Z / 2);
        Vector3 RandomPosition = new Vector3(range_X, 0f, range_Z);

        Vector3 respawnPosition = originPosition + RandomPosition;
        return respawnPosition;
    }

    // Start is called before the first frame update
    private void Start()
    {
        // 한 번만 랜덤 위치에 생성
        Vector3 randomPosition = Return_RandomPosition();
        Instantiate(present, randomPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}