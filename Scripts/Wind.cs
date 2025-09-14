using UnityEngine;
using System.Collections;

public class Wind : MonoBehaviour
{
    [SerializeField] float moveSpeed;   //âEÇ©ÇÁç∂Ç…ìÆÇ©Ç∑

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.right * moveSpeed * Time.deltaTime;
    }
}