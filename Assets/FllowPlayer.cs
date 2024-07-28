using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(0, 3, -4);

    // Update is called once per frame
    private void LateUpdate()
    {
        // 플레이어의 로컬 좌표계를 기준으로 오프셋을 적용
        Vector3 desiredPosition = Player.transform.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * 2);

        // 플레이어를 바라보도록 회전
        transform.LookAt(Player.transform.position);
    }
}
