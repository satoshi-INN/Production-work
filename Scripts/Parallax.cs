using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Parallax : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    public float parallaxEffect;
    void Start()
    {
        // �w�i�摜��x���W
        startpos = transform.position.x;
        // �w�i�摜��x�������̕�
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    private void FixedUpdate()
    {
        // �����X�N���[���Ɏg�p����p�����[�^�[
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        // �w�i�̎������ʂɎg�p����p�����[�^�[
        float dist = (cam.transform.position.x * parallaxEffect);
        // �������ʂ�^���鏈��
        // �w�i�摜��x���W��dist�̕��ړ�������
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
        // �����X�N���[��
        // ��ʊO�ɂȂ�����w�i�摜���ړ�������
        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;
    }
}
