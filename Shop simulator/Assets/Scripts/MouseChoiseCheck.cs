using System;
using UnityEngine;

public class MouseChoiseCheck : MonoBehaviour
{
    public static event Action<int> onClickOnWorker;
    public static event Action<TargetWork> onClickOnWorkTarget;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit, 50))
            {
                if (hit.collider == null) return;

                switch (hit.collider.tag)
                {
                    case "Worker":
                        int workerId = hit.collider.GetComponent<Worker>().id;
                        onClickOnWorker?.Invoke(workerId);
                        break;
                    case "TargetWork":
                        TargetWork targetWork = hit.collider.GetComponent<TargetWork>();
                        onClickOnWorkTarget?.Invoke(targetWork);
                        break;
                }
            }
        }
    }
}
