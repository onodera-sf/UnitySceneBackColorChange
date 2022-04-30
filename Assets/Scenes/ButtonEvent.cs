using System.Linq;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
  public void OnClick()
  {
    // カメラコンポーネントを取得
    var cameraObject = gameObject.scene.GetRootGameObjects().FirstOrDefault(obj => obj.GetComponent<Camera>() != null);
    var camera = cameraObject.GetComponent<Camera>();

    // 背景色を変更
    camera.backgroundColor = new Color(0.3f, 0.0f, 0.1f);
  }
}
