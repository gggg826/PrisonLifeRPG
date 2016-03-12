/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class BasePlayerInfoSingleUI : MonoBehaviour
{
    public PlayerInfoPanelUI playerInfoPanel;
    protected int pageNO;
    protected Text pageNOText;
    public Button closeButton;
    public Button goAheadButton;
    public Button GoBackButton;
    public Animation anima;

    protected void Init()
    {
        try
        {
            goAheadButton = transform.Find("Left").GetComponent<Button>();
            GoBackButton = transform.Find("Right").GetComponent<Button>();
        }
        catch (System.Exception)
        {

        }
        playerInfoPanel = transform.parent.GetComponent<PlayerInfoPanelUI>();
        pageNOText = transform.Find("Text_paperNO").GetComponent<Text>();
        pageNOText.text = pageNO + " / 10";
        closeButton = transform.Find("Close").GetComponent<Button>();
        anima = GetComponent<Animation>();
    }
    protected void ClickButtonEvent()
    {
        closeButton.onClick.AddListener(delegate { playerInfoPanel.HidePanel(); });
        goAheadButton.onClick.AddListener(delegate { playerInfoPanel.GoAhead(pageNO); });
        GoBackButton.onClick.AddListener(delegate { playerInfoPanel.GoBack(pageNO); });
    }

    public void TurnLeft()
    {
        anima.Play("PaperGoLeft");
    }

    public void TurnRighe()
    {
        anima.Play("PaperGoRight");
    }
}