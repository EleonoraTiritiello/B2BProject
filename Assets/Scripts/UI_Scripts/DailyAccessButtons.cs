using UnityEngine;
using UnityEngine.UI;

public class DailyAccessButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject unanswered1;
    [SerializeField]
    private GameObject unanswered2;
    [SerializeField]
    private GameObject unanswered3;
    [SerializeField]
    private GameObject congratulationsScreen;
    [SerializeField]
    private GameObject unpackingScreen;
    [SerializeField]
    private GameObject unrevealedLeftPainting;
    [SerializeField]
    private GameObject unrevealedRightPainting;
    [SerializeField]
    private GameObject extraPackScreen;
    [SerializeField]
    private Image secondStarImage;
    [SerializeField]
    private GameObject unrevealedThirdPainting;
    [SerializeField]
    private GameObject nextButton1;
    [SerializeField]
    private GameObject nextButton2;
    [SerializeField]
    private GameObject dailyAccessScreen;
    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject clickBarrier;


    private int revealCounter = 0;


    public void FirstAnswer()
    {
        unanswered1.SetActive(false);
        unanswered2.SetActive(false);
        unanswered3.SetActive(false);
        Invoke("ThirdPhase", 2f);
        clickBarrier.SetActive(true);
    }
    public void SecondAnswer()
    {
        unanswered2.SetActive(false);
        Invoke("SecondPhase", 2f);
        clickBarrier.SetActive(true);
    }
    public void ThirdAnswer()
    {
        unanswered1.SetActive(false);
        unanswered2.SetActive(false);
        unanswered3.SetActive(false);
        Invoke("ThirdPhase", 2f);
        clickBarrier.SetActive(true);
    }

    public void SecondPhase()
    {
        congratulationsScreen.SetActive(true);
    }

    public void ContinueButton()
    {
        ThirdPhase();
    }

    public void ThirdPhase()
    {
        unpackingScreen.SetActive(true);
    }

    public void RevealPaintingLeft()
    {
        unrevealedLeftPainting.SetActive(false);
        revealCounter++;
        if (revealCounter == 2)
        {
            nextButton1.SetActive(true);
            var tempColor = secondStarImage.color;
            tempColor.a = 255f;
            secondStarImage.color = tempColor;
        }
    }
    public void RevealPaintingRight()
    {
        unrevealedRightPainting.SetActive(false);
        revealCounter++;
        if (revealCounter == 2)
        {
            nextButton1.SetActive(true);
            var tempColor = secondStarImage.color;
            tempColor.a = 255f;
            secondStarImage.color = tempColor;
        }
    }

    public void ExtraPack()
    {
        extraPackScreen.SetActive(true);
    }

    public void RevealThirdPainting()
    {
        unrevealedThirdPainting.SetActive(false);
        nextButton2.SetActive(true);
    }
    public void NextButton1()
    {
        ExtraPack();
    }
    public void NextButton2()
    {
        dailyAccessScreen.SetActive(false);
        mainMenu.SetActive(true);
    }
}
