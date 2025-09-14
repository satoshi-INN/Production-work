using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //ゲームの状態管理(ゲームオーバーなど)
    //ゲームオーバーになった場合、エンターキーでリトライできるようにする
    //ユーザーのキーボード入力を受け付ける
    //ゲームオーバーになったかどうかはフラグで判断する

    [SerializeField] GameObject gameOverPanel;
    bool isGameOver = false;


    private void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.Return))
        {
            //リプレイ=同じシーンを読み込み
            string thisScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(thisScene);

        }

        if (isGameOver && Input.GetKeyDown(KeyCode.RightShift))
        {
            //タイトル画面に戻る
            SceneManager.LoadScene("title");
        }

        if (isGameOver && Input.GetKeyDown(KeyCode.LeftShift))
        {
            //タイトル画面に戻る
            SceneManager.LoadScene("title");
        }
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        isGameOver = true;
    }
}
