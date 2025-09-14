using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] AudioClip yourAudioClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // AudioSource�R���|�[�l���g���擾�܂��͒ǉ�
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = yourAudioClip;
        audioSource.Play(); // �I�[�f�B�I���Đ�

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

    }
}
