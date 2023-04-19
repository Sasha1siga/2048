using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreElement : MonoBehaviour
{
    public ItemType ItemType;
    [field: SerializeField] public int CurrentScore { get; private set; }
    [field: SerializeField] public int Level { get; set; }
    [SerializeField] private TextMeshProUGUI _text;
    [field: SerializeField] public Transform IconTransform { get; private set; }
    [field: SerializeField] public GameObject FlyingIconPrefab { get; private set; }
    [SerializeField] private AnimationCurve _scaleCurve;

    [ContextMenu(nameof(AddOne))]
    public void AddOne()
    {
        CurrentScore--;
        if (CurrentScore < 0)
            CurrentScore = 0;
        _text.text = CurrentScore.ToString();
        StartCoroutine(AddAnimation());
        //ScoreManager.Instance.CheckWin();
    }
    public virtual void Setup(Task task)
    {
        CurrentScore = task.Number;
        _text.text = task.Number.ToString();
    }
    private IEnumerator AddAnimation()
    {
        for (float t = 0; t < 1f; t+=Time.deltaTime * 1.8f)
        {
            float scale = _scaleCurve.Evaluate(t);
            IconTransform.localScale = Vector3.one * scale;
            yield return null;
        }
        IconTransform.localScale = Vector3.one;
    }
}
