using UnityEngine;
using UnityEngine.UI;

public class ShowNotEnoughtMoney : MonoBehaviour
{
    [SerializeField] private Text errorText;
    private string text;
    public int starPowderCount;

    private void Start()
    {
        errorText.color = Color.red;
    }

    private void Update()
    {
        text = $"������������ {starPowderCount} ����� ��� �������";
        errorText.text = text;
    }
}
