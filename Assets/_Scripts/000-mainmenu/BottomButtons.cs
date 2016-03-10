/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class BottomButtons : MonoBehaviour
{
    public Button reviewsButton;
    public Button gamecentreButton;
    public Button facebookshareButton;
    public Button twittershareButton;
    public Button emailButton;

    void Start()
    {
        reviewsButton = transform.Find("ReviewsButton").GetComponent<Button>();
        reviewsButton.onClick.AddListener(delegate { ButtonManager.Instance.SendMessage("ReviewsButtonClick"); });

        gamecentreButton = transform.Find("GameCentreButton").GetComponent<Button>();
        gamecentreButton.onClick.AddListener(delegate { ButtonManager.Instance.SendMessage("GameCentreButtonClick"); });

        facebookshareButton = transform.Find("FacebookButton").GetComponent<Button>();
        facebookshareButton.onClick.AddListener(delegate { ButtonManager.Instance.SendMessage("FacebookButtonClick"); });

        twittershareButton = transform.Find("TwitterButton").GetComponent<Button>();
        twittershareButton.onClick.AddListener(delegate { ButtonManager.Instance.SendMessage("TwitterShareButtonClick"); });

        emailButton = transform.Find("EmailButton").GetComponent<Button>();
        emailButton.onClick.AddListener(delegate { ButtonManager.Instance.SendMessage("EmailButtonClick"); });
    }
}