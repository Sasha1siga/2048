using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Stone : PassiveItem
{

    [Range(0, 2)]
    [SerializeField] private int _level;
    [SerializeField] private GameObject _dieEffectPrefab;
    [SerializeField] private Stone _stonePrefab;
    [SerializeField] private Transform _visualTransform;

    public override void OnAffect()
    {
        base.OnAffect();
        if(_level > 0)
            for (int i = 0; i < 2; i++)
            {
                CreateChildRock(_level - 1);
            }
        else
            ScoreManager.Instance.AddScore(ItemType, transform.position);
        Die();
    }

    private void CreateChildRock(int level)
    {
        Stone newRock = Instantiate(_stonePrefab, transform.position, Quaternion.identity);
        newRock.SetLevel(level);
    }
    private void SetLevel(int level)
    {
        _level = level;
        float scale = 1f;
        if (level == 2)
        {
            scale = 1f;
        }else if (level == 1)
        {
            scale = 0.7f;
        }else if (level == 0)
        {
            scale = 0.45f;
        }
        _visualTransform.localScale = Vector3.one * scale;
    }
    private void Die()
    {
        Instantiate(_dieEffectPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
