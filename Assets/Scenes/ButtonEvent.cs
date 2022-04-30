using System.Linq;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
  public void OnClick()
  {
    // �J�����R���|�[�l���g���擾
    var cameraObject = gameObject.scene.GetRootGameObjects().FirstOrDefault(obj => obj.GetComponent<Camera>() != null);
    var camera = cameraObject.GetComponent<Camera>();

    // �w�i�F��ύX
    camera.backgroundColor = new Color(0.3f, 0.0f, 0.1f);
  }
}
