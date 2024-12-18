using UnityEngine;
using DG.Tweening;

public class CubeAnimation : MonoBehaviour
{
    [Header("Rotation Animation")]
    [SerializeField] private float rotationDuration = 2f; 
    [SerializeField] private Ease rotationEase = Ease.InOutElastic;

    [Header("Punch Scale Animation")]
    [SerializeField] private float punchDuration = 1f;
    [SerializeField] private Vector3 punchStrength = new Vector3(1f, 1f, 1f); 
    [SerializeField] private Ease punchEase = Ease.InOutBounce;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log($"<color=green>[Key Pressed]</color>: 1, <color=blue>[Action]</color>: Rotate Cube");
            RotateCube();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log($"<color=green>[Key Pressed]</color>: 2, <color=blue>[Action]</color>: Punch Scale");
            PunchScale();
        }
    }

    private void RotateCube()
    {
        transform.DORotate(new Vector3(0, 360, 0), rotationDuration, RotateMode.FastBeyond360)
                .SetEase(rotationEase);
    }

    private void PunchScale()
    {
        transform.DOPunchScale(punchStrength, punchDuration, 10, 1)
                .SetEase(punchEase);
    }
}
