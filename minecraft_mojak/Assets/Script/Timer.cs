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
        //�ڷ�ƾ ����
        StartCoroutine(sec());
    }

    private IEnumerator sec()
    {
        while (true)
        {
            //������
            yield return new WaitForSeconds(1f);

            //������ �Լ�
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
