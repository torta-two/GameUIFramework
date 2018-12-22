using UnityEngine;
using UnityEngine.UI;

public class BasePanel : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    private Button btn;

    public void Awake()
    {
        btn = FindCloseButton("CloseButton");
        canvasGroup = GetComponent<CanvasGroup>();

        if (btn != null)
        {
            btn.onClick.AddListener(UIManager.Instance.PopPanel);
        }

        if(canvasGroup == null)
        {
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
        }
    }

    private Button FindCloseButton(string childName)
    {
        Button closeButton = null;
        foreach (var item in GetComponentsInChildren<Button>())
        {
            if (item.name == childName)
                closeButton = item.GetComponent<Button>();
        }
        return closeButton;
    }

    public void OnEnter()
    {
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPause()
    {
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnResume()
    {
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnExit()
    {
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
    }       
}
