using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{    
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
