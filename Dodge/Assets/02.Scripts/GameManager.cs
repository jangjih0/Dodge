using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI ���� ���̺귯�� 
using UnityEngine.SceneManagement; // �� ���� ���� ���̺귯��
using TMPro; // TextMeshpro ���� ���̺귯��

public class GameManager : MonoBehaviour


{

    public class GameObject gameoverText; // ���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
        public TextMeshProUGUI timeText; //���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public TextMeshProUGUI recordText; // �ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime; // ���� �ð�
    private bool isGameover; // ���ӿ��� ����


    // Start is called before the first frame update
    void Start()
    {
        // ���� �ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0;
        isGameover = false;

    }

    // Update is called once per frame
    void Update()
    {
        //���� ������ �ƴ� ����
        if(!isGameover)
        {
            //���� �ð� ����
            surviveTime += Time.deltaTime;
            //������ ���� �ð���  timeText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
            timeText.text = "Time" + (int)surviveTime;
            // 
        }
        else
        {
            //���ӿ��� ���¿���  RŰ�� �����ٸ�,
            if(Input.GetKeyDown(KeyCode.R))
            {
                //MinScene ���� �ε�
                SceneManager.LoadScene("MainScene");
            }
        }
        {
            public void EndGame()
                //���� ���¸� ���ӿ��� ���·� ��ȯ
                isGameover = true;
            // ���� ���� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ
            gameoverText.SetActive(true);
        }
    }
}
