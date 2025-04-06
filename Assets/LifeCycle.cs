using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�");
        }

        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("�������� �����߽��ϴ�");
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("�������� �̵��մϴ�");
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("������ �̵��� ������ϴ�");
        }

        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("�̻��� �߻�!");
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("�̻��� ������ ��...");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("���� �̻��� �߻�!");
        }

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("����!");
        }

        if (Input.GetButton("Jump"))
        {
            Debug.Log("���� ������ ��...");
        }

        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("���� ����!!");
        }
    }
}
