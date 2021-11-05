using UnityEngine;

[RequireComponent(typeof(ClickBear), typeof(Bear))]
public class BearController : MonoBehaviour
{
    private ClickBear _clickBear;
    private Bear _bear;

    private void Awake()
    {
        _clickBear = GetComponent<ClickBear>();
        _bear = GetComponent<Bear>();
    }

    private void OnEnable()
    {
        _clickBear.BearClick += _bear.Movement;
    }

    private void OnDisable()
    {
        _clickBear.BearClick -= _bear.Movement;
    }
}
