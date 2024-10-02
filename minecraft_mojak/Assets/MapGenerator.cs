using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [Header("[Block]")]
    public GameObject B_DiamondPrefab;
    public GameObject B_GoldPrefab;
    public GameObject B_SoilPrefab;
	public GameObject B_SandPrefab;
    public GameObject B_GrassPrefab;

	[Header("[Map_Info]")]
	public int x_Length = 0;
	public int z_Length = 0;
	public float yLow = 0;//���� 
	public float yHigh = 0;//���� //���� �ִ� ����

	private List<GameObject> B_List = new List<GameObject>();
	private void Start()
	{
		for(int x = 0; x < x_Length; x++)
		{
			for(int z = 0; z < z_Length; z++)
			{
				//����( ������, ��ǥ��ġ, ȸ����(Rotation) )
				B_List.Add ((GameObject) Instantiate(B_SoilPrefab, new Vector3(x, 0, z), Quaternion.identity));

			}

		}

		for(int i = 0; i< B_List.Count; i++)
		{
			float xLine = (B_List[i].transform.position.x) / yLow;//����
			float yLine = (B_List[i].transform.position.z) / yLow;
			int y = (int)(Mathf.PerlinNoise(xLine, yLine) * yHigh);//����
			B_List[i].transform.position = new Vector3(B_List[i].transform.position.x,y,B_List[i].transform.position.z);
		}

	}

	#region �׽�Ʈ��
	public bool IsTest = false;
	void Update()
	{
		if (IsTest)
		{
			for(int i = 0;i< B_List.Count; i++)
			{
				float xLine = (B_List[i].transform.position.x) / yLow;//����
				float yLine = (B_List[i].transform.position.z) / yLow;
				int y = (int)(Mathf.PerlinNoise(xLine, yLine) * yHigh);//����
				B_List[i].transform.position = new Vector3(B_List[i].transform.position.x, y, B_List[i].transform.position.z);
			}
		}
	}
	#endregion
}
