using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    [field: SerializeField] public int id { get; private set; }
    [field: SerializeField] public bool isChoiced { get; private set; }

    void OnChoice(int id)
    {
        isChoiced = (id == this.id);
    }
    void OnChoiceWorkTarget(TargetWork workInfo)
    {
        if (isChoiced == false) return;
    }

    private void OnEnable()
    {
        MouseChoiseCheck.onClickOnWorker += OnChoice;
        MouseChoiseCheck.onClickOnWorkTarget += OnChoiceWorkTarget;
    }
    private void OnDisable()
    {
        MouseChoiseCheck.onClickOnWorker -= OnChoice;
        MouseChoiseCheck.onClickOnWorkTarget -= OnChoiceWorkTarget;
    }
}
