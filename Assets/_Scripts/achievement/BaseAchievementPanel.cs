/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using UnityEngine.UI;

public class BaseAchievementPanel : MonoBehaviour
{
    protected int pageNO;
    protected Text pageNOText;
    protected Button closeButton;
    protected Button goAheadButton;
    protected Button GoBackButton;
    protected Animation anima;
    protected int gotCount;
    protected Text gotCountText;
    public Transform Tran_List;

    protected void InitBaseAchievementPanel ()
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
        closeButton = transform.Find("CloseButton").GetComponent<Button>();
        anima = GetComponent<Animation>();
        gotCount = DATAManager.GOTCOUNTACHIEVEMENTS;
        gotCountText = transform.Find("Count").GetComponent<Text>();
        gotCountText.text = gotCount + "/135";
        Tran_List = transform.Find("List").transform;
    }
    protected void ClickButtonEvent()
    {
        closeButton.onClick.AddListener(delegate { AchievementUI.Instance.HidePanel(); });
        goAheadButton.onClick.AddListener(delegate { AchievementUI.Instance.GoAhead(pageNO); });
        GoBackButton.onClick.AddListener(delegate { AchievementUI.Instance.GoBack(pageNO); });
    }

    public void TurnLeft()
    {
        anima.Play("PaperGoLeft");
    }

    public void TurnRighe()
    {
        anima.Play("PaperGoRight");
    }

    protected void ListICON(int startID, int endID)
    {
        AchievementsController.Instance.AddAchievementToScreen(startID, endID, Tran_List);
    }
}