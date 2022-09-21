using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed  = 8f; //ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody; // �̵��� ����� ������ٵ� ������Ʈ



    // Start is called before the first frame update
    void Start()
    {
        //���ӿ�����Ʈ���� Rigidbody ������Ʈ�� ã��
        //bulletRigidbody�� �Ҵ�
        
        bulletRigidbody = GetComponent<Rigidbody>();
        

        //������ٵ� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        //3�� �ڿ� �浹�� �ı�
        Destroy(gameObject, 3f);
    }

    //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
    private void OnTriggerEnter(Collider other)
    {
        //�浹�� ���� ���� ������Ʈ�� Player �±׸� �����ٸ�,
        if (other.tag == "Player")
        {
            //���� ���� ������Ʈ���� PlayerController ������Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();
                other.GetComponent<PlayerController>();

            //�������κ��� PlayerController ������Ʈ�� �������� �� 
            //�����ߴٸ�
            if(playerController !=null)
            {
                //���� PlayerController ������Ʈ�� Die() �޼��� ����
                playerController.Die();
            }
        }
    }




}