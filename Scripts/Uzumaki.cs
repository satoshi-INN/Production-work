using UnityEngine;
using System.Collections;

public class Uzumaki : MonoBehaviour
{
    //���̊֐���ݒ�
    private AudioSource audioSource_U1;
    private AudioSource audioSource_U2;
    private AudioSource audioSource_U3;

    [SerializeField] float moveSpeed;   //�E���獶�ɓ�����

    //���̎擾
    void Start()
    {
        // AudioSource�R���|�[�l���g���擾
        audioSource_U1 = GetComponents<AudioSource>()[0];
        audioSource_U2 = GetComponents<AudioSource>()[1];
        audioSource_U3 = GetComponents<AudioSource>()[2];

        PlayAudio_U1();
        PlayAudio_U2();
        PlayAudio_U3();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.right * moveSpeed * Time.deltaTime;

        Vector3 cameraPos = Camera.main.transform.position;

        if (transform.position.x <= cameraPos.x - 50f)
        {
            Destroy(gameObject);
        }
        else if (IsInRange(cameraPos.y - 10f, cameraPos.y - 1.5f))
        {
            PlayAudio_U1();
        }
        else if (IsInRange(cameraPos.y + 1.5f, cameraPos.y + 10f))
        {
            PlayAudio_U2();
        }
        else
        {
            PlayAudio_U3();
        }
    }

    //�͈̓`�F�b�N���\�b�h
    bool IsInRange(float min, float max)
    {
        return transform.position.y >= min && transform.position.y <= max;
    }

    //���Ɏw��
    void PlayAudio_U1()
    {
        audioSource_U1.Play();
    }
    void PlayAudio_U2()
    {
        audioSource_U2.Play();
    }
    void PlayAudio_U3()
    {
        audioSource_U3.Play();
    }
}