using UnityEngine;

public class T_BGM : MonoBehaviour
{
    private AudioSource audioSource;

    // Startは、最初のフレームの前に一度だけ呼び出されます
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("このゲームオブジェクトにAudioSourceコンポーネントがありません。");
        }
    }

    // Updateは、毎フレーム呼び出されます
    void Update()
    {
        if (audioSource != null)
        {
            audioSource.loop = !audioSource.loop;
        }
    }
}