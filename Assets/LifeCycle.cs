using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Awake()
    {
        //���� ������Ʈ�� ��� �ȿ� ������ �� ���ʷ� ���� ��
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    private void OnEnable()
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�");
    }

    private void Start()
    {
        //������Ʈ ���� ���� ���� 1ȸ
        Debug.Log("��� ��� ì����ϴ�.");
    }

    private void FixedUpdate()
    {
        //���� ������ �ʿ��� ��� ���
        //�����Ӱ� ������� ������ �ð� �������� ȣ���
        Debug.Log("�̵�~");
    }

    private void Update()
    {
        Debug.Log("���� ���!!");
    }

    private void LateUpdate()
    {
        //������Ʈ�� ���� �� ȣ���
        //ī�޶��� ��ġ�� ������Ʈ �� �� ���
        Debug.Log("����ġ ȹ��");
    }

    private void OnDisable()
    {
        //���� ������Ʈ�� ��Ȱ��ȭ �� �� ȣ���
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�");
    }

    private void OnDestroy()
    {
        //���� ������Ʈ�� �ı��� �� ȣ���
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�");
    }

}
