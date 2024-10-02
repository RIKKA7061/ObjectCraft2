using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float x = 0;
    public TMP_Text showUI;
    void Start()
    {
        //코루틴 시작
        StartCoroutine(sec());
    }

    private IEnumerator sec()
    {
        while (true)
        {
            //딜레이
            yield return new WaitForSeconds(1f);

            //실행할 함수
            Function();
        }
    }

    private void Update()
    {
        x += Time.deltaTime;
        showUI.text = x.ToString("F0");
    }

    private void Function()
    {
        Debug.Log((int)x);
    }
}
