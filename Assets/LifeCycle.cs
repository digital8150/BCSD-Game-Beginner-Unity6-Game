using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Awake()
    {
        //게임 오브젝트가 장면 안에 생성될 때 최초로 실행 됨
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    private void OnEnable()
    {
        Debug.Log("플레이어가 로그인했습니다");
    }

    private void Start()
    {
        //업데이트 시작 직전 최초 1회
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    private void FixedUpdate()
    {
        //물리 연산이 필요한 경우 사용
        //프레임과 관계없이 일정한 시간 간격으로 호출됨
        Debug.Log("이동~");
    }

    private void Update()
    {
        Debug.Log("몬스터 사냥!!");
    }

    private void LateUpdate()
    {
        //업데이트가 끝난 후 호출됨
        //카메라의 위치를 업데이트 할 때 사용
        Debug.Log("경험치 획득");
    }

    private void OnDisable()
    {
        //게임 오브젝트가 비활성화 될 때 호출됨
        Debug.Log("플레이어가 로그아웃했습니다");
    }

    private void OnDestroy()
    {
        //게임 오브젝트가 파괴될 때 호출됨
        Debug.Log("플레이어 데이터를 해제하였습니다");
    }

}
