using UnityEngine;

public class INZM : MonoBehaviour
{
    public AudioClip yourAudioClip; // �C���X�y�N�^�[�Őݒ�

    void Start()
    {
        // AudioSource�R���|�[�l���g���擾�܂��͒ǉ�
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = yourAudioClip;
        audioSource.Play(); // �I�[�f�B�I���Đ�

        Destroy(gameObject, 3f);
    }
    
}
