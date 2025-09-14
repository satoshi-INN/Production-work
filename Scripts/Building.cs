using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] AudioClip yourAudioClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // AudioSourceコンポーネントを取得または追加
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = yourAudioClip;
        audioSource.Play(); // オーディオを再生

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
