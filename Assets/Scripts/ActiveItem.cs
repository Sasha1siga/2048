using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActiveItem : Item
{
    public bool IsDead { get; private set; }
    public Rigidbody Rigidbody { get; private set;}
    public float Radius { get; protected set; }
    [field: SerializeField] public Projection Projection { get; private set; }
    [SerializeField] private int _level;
    [SerializeField] protected TextMeshProUGUI _levelText;

    
    [SerializeField] protected SphereCollider _collider;
    [SerializeField] protected SphereCollider _trigger;
    [SerializeField] protected Animator _animator;

    void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>(); 
    }
    protected virtual void Start()
    {
        Projection.Hide();
    }

    [ContextMenu(nameof(IncreaseLevel))]
    public void IncreaseLevel()
    {
        _level++;
        SetLevel(_level);
        _trigger.enabled = false;
        Invoke(nameof(EnableTrigger), 0.08f);
        _animator.SetTrigger("IncreaseLevel");
    }

    public virtual void SetLevel(int level)
    {
        _level = level;

        _levelText.text = Mathf.Pow(2, level + 1).ToString();

        

        
    }
    void EnableTrigger()
    {
        _trigger.enabled = true;
    }

    public void SetupToTube()
    {
        _trigger.enabled = false;
        _collider.enabled = false;
        Rigidbody.isKinematic = true;
        Rigidbody.interpolation = RigidbodyInterpolation.None;
    }

    public void Drop()
    {
        _trigger.enabled = true;
        _collider.enabled = true;
        Rigidbody.isKinematic = false;
        Rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
        transform.parent = null;
        Rigidbody.velocity = Vector3.down * 0.8f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsDead) return;

        if (other.attachedRigidbody)
        {
            ActiveItem otherItem = other.attachedRigidbody.GetComponent<ActiveItem>();
            if (otherItem)
            {
                if (!otherItem.IsDead && _level == otherItem._level)
                {
                    CollapseManager.Instance.Collapse(this, otherItem);
                }
            }
        }
    }

    public void Disable()
    {
        _trigger.enabled = false;
        _collider.enabled = false;
        Rigidbody.isKinematic = true;
        IsDead = true;
    }
    public void Die()
    {
        Destroy(gameObject);
    }

    public virtual void DoEffect()
    {

    }
}
