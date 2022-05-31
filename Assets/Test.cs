using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;   // �̗�
    private int power = 25; // �U����
    private int mp = 53; // ����

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

    // ���@�U���p�̊֐�
    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp);
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);

        // ---�ۑ�---
        int[] array = { 1, 100, 39, 810, 777 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("�z��" + i + "�̒l�F" + array[i]);
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log("�z��" + i + "�̒l�F" + array[i]);
        }

        // ���W�ۑ�
        lastboss.Magic();
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
