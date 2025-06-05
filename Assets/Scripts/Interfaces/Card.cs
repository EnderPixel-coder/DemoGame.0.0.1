using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI typeText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI defenseText;
    public Image artImage;
    public Image background;

    public void SetCardData(CardData data)
    {
        nameText.text = data.cardName;
        costText.text = data.cost.ToString();
        typeText.text = data.cardType;
        descriptionText.text = data.description;
        attackText.text = data.attack.ToString();
        defenseText.text = data.defense.ToString();
        artImage.sprite = data.art;
        background.sprite = data.background;
    }
}
