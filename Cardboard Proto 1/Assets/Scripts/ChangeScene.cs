using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ChangeScene : MonoBehaviour {
    public Text UIText;

    public void ToTheFlash()
    {
        SceneManager.LoadScene("Scene 1");
    }

    public void OverlayText(bool b)
    {
        UIText.enabled = b;
    }
}
