using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour 
{
	// UIController を参照する
	public UIController UIController;

	// Trigger との接触時に呼ばれる Callback
	private void OnTriggerEnter (Collider hit)
	{
		// 接触対象は Playerタグかどうか
		if (hit.CompareTag ("Player")) 
		{
			// Rigidbody を停止させる
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

			// ゲームクリアを表示する
			UIController.ShowGameOverLabel();
			UIController.ShowRetryButton();
		}
	}
}
