using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour 
{
	// プレイヤーの　Transform
	public Transform Player;
	// 相対座標
	private Vector3 offset;

	private void Start ()
	{
		// MainCamera と Player の相対距離を求める
		offset = GetComponent<Transform>().position - Player.position;
	}

	private void Update ()
	{
		// Cameraの座標に　Payer の座標と offset 加算した値を代入する
		GetComponent<Transform>().position = Player.position + offset;
	}
}
