
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class Gsv_DangNhap : MonoBehaviour
{
    public static PlayGamesPlatform platform;
    public static Gsv_DangNhap instanceDN;
    private void Awake()
    {
        if (instanceDN == null)
        {
            instanceDN = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        if (platform == null)
        {
            PlayGamesClientConfiguration clientConfiguration = new PlayGamesClientConfiguration.Builder().Build();
            PlayGamesPlatform.InitializeInstance(clientConfiguration);
            PlayGamesPlatform.DebugLogEnabled = true;
            platform = PlayGamesPlatform.Activate();
        }


        Social.Active.localUser.Authenticate(success =>
        {
            if (success)
            {
                Debug.Log("DNAG NHAP THANH CONG");
            }
            else
            {
                Debug.Log("DANG NHAP THAT BAI");
            }
        });
    }

}
