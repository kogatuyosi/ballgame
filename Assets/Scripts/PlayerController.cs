using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	private void FixedUpdate()
	{
		float x = Input.GetAxis ("Horizontal"); //Horizontalは水平方向
		float z = Input.GetAxis ("Vertical");  //Vertivalは垂直方向
		// Player が持つRigidbody コンポーネントを取得
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		// rigidbody のx軸（横）とz軸（奥）に力を加える
		rigidbody.AddForce(x,0,z);
	}
}
