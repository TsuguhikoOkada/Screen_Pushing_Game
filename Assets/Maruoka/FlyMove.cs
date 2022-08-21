using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> ƒnƒG‚ÌˆÚ“® </summary>
public class FlyMove : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    [SerializeField] float _moveSpeed;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float rad = UnityEngine.Random.Range(0f, Mathf.PI * 2f);
        float moveX = Mathf.Sin(rad);
        float moveY = Mathf.Cos(rad);
        //ˆÚ“®
        _rigidbody2D.velocity = new Vector2(moveX, moveY).normalized * _moveSpeed;
    }
}
