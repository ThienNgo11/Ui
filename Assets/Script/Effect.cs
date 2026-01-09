using System.Collections;
using UnityEngine;

public class PulseScale : MonoBehaviour
{
    public float scaleUp = 1.15f;    
    public float duration = 0.2f;     
    public float delay = 2f;          

    Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
        StartCoroutine(Pulse());
    }

    IEnumerator Pulse()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);

            yield return ScaleTo(originalScale * scaleUp);

            yield return ScaleTo(originalScale);
        }
    }

    IEnumerator ScaleTo(Vector3 target)
    {
        Vector3 start = transform.localScale;
        float time = 0f;

        while (time < duration)
        {
            time += Time.deltaTime;
            transform.localScale = Vector3.Lerp(start, target, time / duration);
            yield return null;
        }

        transform.localScale = target;
    }
}
