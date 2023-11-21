using UnityEngine;
using UnityEngine.UI;

public class CheckSaves : MonoBehaviour
{
    private Color[] StarColors =
   {
        Color.white,
        Color.green,
        Color.red,
        new Color(1, 0.4901961f, 0, 1),
        new Color(0.627451f, 1, 0)
    };

    private Color[] spikeColors =
    {
         new Color(0.8862745f,0.8862745f,0.8862745f),
         new Color(0.5019608f,0.2745098f,0),
         new Color(0.3960784f,0,0),
         new Color(1,0.8705882f,0),
         new Color(0,0.9803922f,1),
         new Color(0.7137255f,1,0)
    };

    private Color[] playerColors =
    {
        Color.red,
        Color.blue,
        new Color(0.495283f,0.9430465f,1),
        new Color(0, 0.04989147f, 1),
        new Color(0.5221004f, 0, 1)
    };

    private int currentStarSkinIndex;
    [SerializeField] private Image[] starsUI;
    [SerializeField] private Sprite multiStar;
    [SerializeField] private Sprite star;

    private int currentSpikeSkinIndex;
    [SerializeField] private Image[] spikeUI;

    private int currentPlayerSkinIndex;
    [SerializeField] private Image playerUI;
    [SerializeField] private Sprite chessSkin;
    [SerializeField] private Sprite defaultSkin;
    void Start()
    {

       
        currentStarSkinIndex = PlayerPrefs.GetInt("CurrentStar");
        currentSpikeSkinIndex = PlayerPrefs.GetInt("CurrentSpike");
        currentPlayerSkinIndex = PlayerPrefs.GetInt("CurrentPlayerSkin");

        if (currentStarSkinIndex == 5) //Laod star skin
        {
            for (int i = 0; i < starsUI.Length; i++)
            {
                starsUI[i].sprite = multiStar;
                starsUI[i].color = Color.white;
            }
        }
        else if (currentStarSkinIndex >= 0 && currentStarSkinIndex < StarColors.Length)
        {
            for (int i = 0; i < starsUI.Length; i++)
            {
                starsUI[i].sprite = star;
                starsUI[i].color = StarColors[currentStarSkinIndex];
            }
        }

        if(currentSpikeSkinIndex >= 0 && currentStarSkinIndex < spikeColors.Length) //Load spike skin
        {
            for (int i = 0; i < spikeUI.Length; i++)
            {
                spikeUI[i].color = spikeColors[currentSpikeSkinIndex];
            }
        }
   
        if (currentPlayerSkinIndex == 5) // Load player skin
        {
            playerUI.sprite = chessSkin;
            playerUI.color = Color.white;
        }
       else if (currentPlayerSkinIndex >= 0 && currentPlayerSkinIndex < playerColors.Length)
        { 
            playerUI.sprite = defaultSkin;
            playerUI.color = playerColors[currentPlayerSkinIndex];
        }
    }

   
}
