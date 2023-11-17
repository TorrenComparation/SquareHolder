using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    [SerializeField] private Image picture;
    [SerializeField] private Sprite[] winPictures;
    [SerializeField] private Sprite[] loosePictures;
    [SerializeField] private Text text;
    [SerializeField] private string[] winSentences;
    [SerializeField] private string[] looseSentences;
    private int generatedNumberForText;
    private int minGeneratedNumberForText = 0;
    private int maxGeneratedNumberForText;
    private int generatedNumberForImage;
    private int minGeneratedNumberForImage = 0;
    private int maxGeneratedNumberForImage;

    private void Start()
    {
        picture.color = new Color(255, 255, 255, 0);

        maxGeneratedNumberForText = winSentences.Length - 1;
        maxGeneratedNumberForImage = winPictures.Length - 1;
        generatedNumberForText = Random.Range(minGeneratedNumberForText, maxGeneratedNumberForText);
        generatedNumberForImage = Random.Range(minGeneratedNumberForImage, maxGeneratedNumberForImage);

        maxGeneratedNumberForText = looseSentences.Length - 1;
        maxGeneratedNumberForImage = loosePictures.Length - 1;
        generatedNumberForText = Random.Range(minGeneratedNumberForText, maxGeneratedNumberForText);
        generatedNumberForImage = Random.Range(minGeneratedNumberForImage, maxGeneratedNumberForImage);
    }
    public void Wins()

    {

        picture.color = new Color(255, 255, 255, 255);
        text.color = Color.green;
        text.text = winSentences[generatedNumberForText];
        picture.sprite = winPictures[generatedNumberForImage];
    }

    public void Loose()
    {

        picture.color = new Color(255, 255, 255, 255);
        text.color = Color.red;
        text.text = looseSentences[generatedNumberForText];
        picture.sprite = loosePictures[generatedNumberForImage];

    }

}
