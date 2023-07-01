using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public List<Sprite> diceImages;

    public RawImage diceRawImage;
    void Start()
    {
        diceRawImage.GetComponent<Button>().onClick.AddListener(RollDice);
    }

    public void OnMouseDown()
    {
        RollDice();
    }

    void RollDice()
    {
        if (diceImages.Count > 0)
        {
            int randomNumber = Random.Range(1, 7);

            int imageIndex = randomNumber - 1;
            Sprite diceSprite = diceImages[imageIndex];

            diceRawImage.texture = diceSprite.texture;
        }
    }
}
