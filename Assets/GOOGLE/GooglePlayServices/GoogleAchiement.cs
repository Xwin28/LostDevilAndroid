using UnityEngine;
using GooglePlayGames;

public class GoogleAchiement : MonoBehaviour
{
    public int indexachieve;// so nay phai tuong ung trong GPRSID
    private string _achiCode;
    public void OpenAchiementUI()
    {
        Social.ShowAchievementsUI();

    }

    /*
     * goi ham : UnlochAchiment(GPGSIds.achievement_first_archive) -->///ten cua Archiment
     */
    public void UnlockAchiement()
    {
        switch (indexachieve)
        {
            case 0: _achiCode = GPGSIds.achievement_explorer; break;
            case 1: _achiCode = GPGSIds.achievement_revival; break;
            case 2: _achiCode = GPGSIds.achievement_hunter; break;
            case 3: _achiCode = GPGSIds.achievement_easy_game; break;
            case 4: _achiCode = GPGSIds.achievement_baka; break;
            case 5: _achiCode = GPGSIds.achievement_treasures_tracker; break;
            case 6: _achiCode = GPGSIds.achievement_dark_soul_hunter; break;



        }

        Social.ReportProgress(_achiCode, 100f, null);

    }


    public void UnlockAchiement(int i)
    {
        switch (i)
        {
            case 0: _achiCode = GPGSIds.achievement_explorer; break;
            case 1: _achiCode = GPGSIds.achievement_revival; break;
            case 2: _achiCode = GPGSIds.achievement_hunter; break;
            case 3: _achiCode = GPGSIds.achievement_easy_game; break;
            case 4: _achiCode = GPGSIds.achievement_baka; break;
            case 5: _achiCode = GPGSIds.achievement_treasures_tracker; break;
            case 6: _achiCode = GPGSIds.achievement_dark_soul_hunter; break;



        }

        Social.ReportProgress(_achiCode, 100f, null);

    }
}
