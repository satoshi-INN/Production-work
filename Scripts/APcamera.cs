using UnityEngine;

public class APcamera : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    public GameObject cam;

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.left  * moveSpeed * Time.deltaTime;
    }
}
