using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
  [SerializeField] protected string _label;
  [SerializeField] protected int _price;
  [SerializeField] protected Sprite _icon;
  [SerializeField] protected bool _isBuyed = false;

  [SerializeField] protected FireBall _fireBall;

  public abstract void Shoot(Transform shootPoint);
}
