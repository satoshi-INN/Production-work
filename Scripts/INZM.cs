using UnityEngine;

public class INZM : MonoBehaviour
{
    public AudioClip yourAudioClip; // インスペクターで設定

    void Start()
    {
        // AudioSourceコンポーネントを取得または追加
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = yourAudioClip;
        audioSource.Play(); // オーディオを再生

        Destroy(gameObject, 3f);
    }
    
}
