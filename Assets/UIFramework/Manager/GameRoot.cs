using UnityEngine;

public class GameRoot : MonoBehaviour
{
	void Start ()
    {
        UIManager.Instance.PushPanel(UIPanelType.MainMenuPanel);
	}
}
