using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreElementBall : ScoreElement
{
    [SerializeField] private TextMeshProUGUI _textOnBall;
    [SerializeField] private RawImage _ballImage;
    [SerializeField] private BallSettings _ballSettings;
    public override void Setup(Task task)
    {
        base.Setup(task);
        Level = task.Level;
        int number = (int)Mathf.Pow(2, task.Level + 1);
        _textOnBall.text = number.ToString();
        _ballImage.color = _ballSettings.BallMaterials[task.Level].color;
    }
}
