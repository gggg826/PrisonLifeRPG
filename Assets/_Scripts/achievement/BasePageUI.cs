/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using UnityEngine.UI;

public class BasePageUI : MonoBehaviour
{
    protected int pageNO;
    protected int gotCount;
    protected Text pageNOText;
    protected Text gotCountText;
    protected Button closeButton;
    protected Button goAheadButton;
    protected Button GoBackButton;
    protected Transform Tran_List;
    protected Animation animation;

	protected void Init ()
    {
        try
        {
            goAheadButton = transform.Find("GoAheadButton").GetComponent<Button>();
            GoBackButton = transform.Find("GoBackButton").GetComponent<Button>();
        }
        catch (System.Exception)
        {

        }
        pageNOText = transform.Find("PageNO").GetComponent<Text>();
        pageNOText.text = pageNO + " / 7";
        gotCount = DATAManager.GOTCOUNTACHIEVEMENTS;
        gotCountText = transform.Find("Count").GetComponent<Text>();
        gotCountText.text = gotCount + "/135";
        Tran_List = transform.Find("List").transform;
        closeButton = transform.Find("CloseButton").GetComponent<Button>();
        animation = GetComponent<Animation>();
    }

    protected void ClickButtonEvent()
    {
        closeButton.onClick.AddListener(delegate { AchievementUI.Instance.HidePanel(); });
        goAheadButton.onClick.AddListener(delegate { AchievementUI.Instance.GoAhead(pageNO); });
        GoBackButton.onClick.AddListener(delegate { AchievementUI.Instance.GoBack(pageNO); });
    }

    protected void ListICON(int startID, int endID)
    {
        AchievementsController.Instance.AddAchievementToScreen(startID, endID, Tran_List);
    }

    public void TurnLeft()
    {
        animation.Play("PaperGoLeft");
    }

    public void TurnRighe()
    {
        animation.Play("PaperGoRight");
    }
}