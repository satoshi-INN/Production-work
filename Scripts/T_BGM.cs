using UnityEngine;

public class T_BGM : MonoBehaviour
{
    private AudioSource audioSource;

    // Start�́A�ŏ��̃t���[���̑O�Ɉ�x�����Ăяo����܂�
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("���̃Q�[���I�u�W�F�N�g��AudioSource�R���|�[�l���g������܂���B");
        }
    }

    // Update�́A���t���[���Ăяo����܂�
    void Update()
    {
        if (audioSource != null)
        {
            audioSource.loop = !audioSource.loop;
        }
    }
}