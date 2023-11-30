using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1.0f;
    [SerializeField]
    private Rigidbody _rigidBody;
    void Start()
    {

    }
    void Update()
    {
        // 左右移動
        float inputX = Input.GetAxis("Horizontal");
        _rigidBody.velocity = new Vector2(inputX * _speed, _rigidBody.velocity.y);
    }
}