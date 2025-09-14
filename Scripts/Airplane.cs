using UnityEngine;

public class Airplane : MonoBehaviour
{
    [SerializeField] Score score;
    [SerializeField] float upSpeed;
    [SerializeField] GameManager gameManeger;

    //Space�L�[�ŏ㏸
    /// <summary>
    //�ERigidBody2D���擾���ď�����̑��x��ݒ肵�Ă�����

    Rigidbody2D rb2D;
    bool isDead;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    /// </summary>
    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            //return = 関数の処理を終了する
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.linearVelocity = Vector3.up * upSpeed;
            GetComponent<AudioSource>().Play();
        }

        if (transform.position.y < -5.65 || transform.position.y > 5.65)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameManeger.GameOver();
        isDead = true;
    }

    //当たり判定:Windにぶつかったらログを出す(ゲームオーバー)
    //Colliderを設定する
    //Rigidbodyの設定をする
    //コードからぶつかったら自動で実行される関数を利用する

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead)
        {
            //return = 関数の処理を終了する
            return;
        }

        GameOver();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isDead)
        {
            //return = 関数の処理を終了する
            return;
        }
        score.AddScore(1);
    }

    //ゲームオーバーの実装
    //どのタイミングに、何をするか？
    //風にぶつかったタイミングで、UIを表示する
}

