using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //�Q�[���̏�ԊǗ�(�Q�[���I�[�o�[�Ȃ�)
    //�Q�[���I�[�o�[�ɂȂ����ꍇ�A�G���^�[�L�[�Ń��g���C�ł���悤�ɂ���
    //���[�U�[�̃L�[�{�[�h���͂��󂯕t����
    //�Q�[���I�[�o�[�ɂȂ������ǂ����̓t���O�Ŕ��f����

    [SerializeField] GameObject gameOverPanel;
    bool isGameOver = false;


    private void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.Return))
        {
            //���v���C=�����V�[����ǂݍ���
            string thisScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(thisScene);

        }

        if (isGameOver && Input.GetKeyDown(KeyCode.RightShift))
        {
            //�^�C�g����ʂɖ߂�
            SceneManager.LoadScene("title");
        }

        if (isGameOver && Input.GetKeyDown(KeyCode.LeftShift))
        {
            //�^�C�g����ʂɖ߂�
            SceneManager.LoadScene("title");
        }
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        isGameOver = true;
    }
}
