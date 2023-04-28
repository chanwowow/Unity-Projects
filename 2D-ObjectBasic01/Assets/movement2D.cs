
using UnityEngine;

public class movement2D : MonoBehaviour
{
    // Awake는 최초 1회 실행된다.
    private void Awake(){
        // 새 위치 = 현재위치 + (방향 * 속도)
        transform.position = transform.position + new Vector3 (1,0,0) * 1;
        // transform : 내가 소속되어 있는 게임 object의 Transform 컴포넌트

        
    }

    private Vector3 moveDirection = Vector3.zero;
    private float moveSpeed = 2.0f;

    // game 실행 동안 계속 실행됨 (fps 에 따른 호출)
    private void Update(){
        // device 사양에 따른 Update 호출횟수가 달라지므로 Time.deltaTime을 사용하여 일정한 이동 만듦
        //transform.position += Vector3.right * 1 * Time.deltaTime;

        // Horizontal 방향키 좌우 : 좌 -1 / none 0 / 우 +1
        // Vertical 방향키 상하 : 하 -1 / none 0 / 상 +1
        float x = Input.GetAxisRaw("Horizontal"); // 좌우이동
        float y = Input.GetAxisRaw("Vertical"); // 상하이동

        // 이동방향 설정
        moveDirection = new Vector3(x,y,0);

        // 새 위치
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
