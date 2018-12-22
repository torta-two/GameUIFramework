public class MainMenuPanel : BasePanel
{
    public void OnClickSystemSettingButton()
    {
        UIManager.Instance.PushPanel(UIPanelType.SystemSettingPanel);
    }

    public void OnClickStoreButton()
    {
        UIManager.Instance.PushPanel(UIPanelType.StorePanel);
    }

    public void OnClickPauseButton()
    {
        UIManager.Instance.PushPanel(UIPanelType.PausePanel);
    }
}
