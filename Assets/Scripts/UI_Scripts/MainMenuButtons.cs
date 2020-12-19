using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject exitConfirm;
    [SerializeField]
    private GameObject externalSiteDialog;
    [SerializeField]
    private GameObject questsAndBadgesScreen;
    [SerializeField]
    private GameObject questsDailiesScreen;
    [SerializeField]
    private GameObject questsMilestonesScreen;
    [SerializeField]
    private GameObject badgesScreen;
    [SerializeField]
    private GameObject profileScreen;

    public void ExitButton()
    {
        exitConfirm.SetActive(true);
    }

    public void ExitConfirmButton()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void ExitCancelButton()
    {
        exitConfirm.SetActive(false);
    }

    public void ToExternalSiteButton()
    {
        externalSiteDialog.SetActive(true);
    }
    public void ExternalSiteConfirmButton()
    {
        Debug.Log("ToExternalSite");
    }

    public void ExternalSiteCancelButton()
    {
        externalSiteDialog.SetActive(false);
    }

    public void ToQuestsAndBadgesScreen()
    {
        questsAndBadgesScreen.SetActive(true);
        questsDailiesScreen.SetActive(true);
    }

    public void ToDailiesScreen()
    {
        questsDailiesScreen.SetActive(true);
        questsMilestonesScreen.SetActive(false);
        badgesScreen.SetActive(false);
    }

    public void ToMilestonesScreen()
    {
        questsDailiesScreen.SetActive(false);
        questsMilestonesScreen.SetActive(true);
        badgesScreen.SetActive(false);
    }

    public void ToBadgesScreen()
    {
        questsDailiesScreen.SetActive(false);
        questsMilestonesScreen.SetActive(false);
        badgesScreen.SetActive(true);
    }
    public void ExitQuestsAndBadgesScreen()
    {
        questsAndBadgesScreen.SetActive(false);
        questsDailiesScreen.SetActive(false);
        questsMilestonesScreen.SetActive(false);
        badgesScreen.SetActive(false);
    }

    public void ToProfileScreen()
    {
        profileScreen.SetActive(true);
    }
    public void ExitProfileScreen()
    {
        profileScreen.SetActive(false);
    }

}
