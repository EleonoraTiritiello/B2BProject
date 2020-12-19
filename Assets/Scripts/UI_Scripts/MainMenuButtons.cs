using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;
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

    [SerializeField]
    private GameObject dailiesButtonIconActive;
    [SerializeField]
    private GameObject dailiesButtonIconDeactivated;

    [SerializeField]
    private GameObject milestonesButtonIconActive;
    [SerializeField]
    private GameObject milestonesButtonIconDeactivated;

    [SerializeField]
    private GameObject badgesButtonIconActive;
    [SerializeField]
    private GameObject badgesButtonIconDeactivated;

    [SerializeField]
    private GameObject soundButtonOnIcon;
    [SerializeField]
    private GameObject soundButtonOffIcon;




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
        mainMenu.SetActive(false);

        questsDailiesScreen.SetActive(true);
        dailiesButtonIconActive.SetActive(false);
        dailiesButtonIconDeactivated.SetActive(true);

        milestonesButtonIconActive.SetActive(true);
        milestonesButtonIconDeactivated.SetActive(false);

        badgesButtonIconActive.SetActive(true);
        badgesButtonIconDeactivated.SetActive(false);

    }

    public void ToDailiesScreen()
    {
        questsDailiesScreen.SetActive(true);
        dailiesButtonIconActive.SetActive(false);
        dailiesButtonIconDeactivated.SetActive(true);

        questsMilestonesScreen.SetActive(false);
        milestonesButtonIconActive.SetActive(true);
        milestonesButtonIconDeactivated.SetActive(false);

        badgesScreen.SetActive(false);
        badgesButtonIconActive.SetActive(true);
        badgesButtonIconDeactivated.SetActive(false);
    }

    public void ToMilestonesScreen()
    {
        questsDailiesScreen.SetActive(false);
        dailiesButtonIconActive.SetActive(true);
        dailiesButtonIconDeactivated.SetActive(false);

        questsMilestonesScreen.SetActive(true);
        milestonesButtonIconActive.SetActive(false);
        milestonesButtonIconDeactivated.SetActive(true);

        badgesScreen.SetActive(false);
        badgesButtonIconActive.SetActive(true);
        badgesButtonIconDeactivated.SetActive(false);
    }

    public void ToBadgesScreen()
    {
        questsDailiesScreen.SetActive(false);
        dailiesButtonIconActive.SetActive(true);
        dailiesButtonIconDeactivated.SetActive(false);

        questsMilestonesScreen.SetActive(false);
        milestonesButtonIconActive.SetActive(true);
        milestonesButtonIconDeactivated.SetActive(false);

        badgesScreen.SetActive(true);
        badgesButtonIconActive.SetActive(false);
        badgesButtonIconDeactivated.SetActive(true);
    }
    public void ExitQuestsAndBadgesScreen()
    {
        questsAndBadgesScreen.SetActive(false);
        questsDailiesScreen.SetActive(false);
        questsMilestonesScreen.SetActive(false);
        badgesScreen.SetActive(false);

        dailiesButtonIconActive.SetActive(false);
        dailiesButtonIconDeactivated.SetActive(false);

        milestonesButtonIconActive.SetActive(false);
        milestonesButtonIconDeactivated.SetActive(false);

        badgesButtonIconActive.SetActive(false);
        badgesButtonIconDeactivated.SetActive(false);

        mainMenu.SetActive(true);
    }

    public void ToProfileScreen()
    {
        profileScreen.SetActive(true);
    }
    public void ExitProfileScreen()
    {
        profileScreen.SetActive(false);
    }

    public void DisableSound()
    {
        soundButtonOnIcon.SetActive(false);
        soundButtonOffIcon.SetActive(true);
    }
    public void EnableSound()
    {
        soundButtonOnIcon.SetActive(true);
        soundButtonOffIcon.SetActive(false);
    }

}
