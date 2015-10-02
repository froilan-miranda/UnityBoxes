using UnityEngine;
using System.Collections;

public class SceneLogic : MonoBehaviour {

	private GameObject tQuad;
	private Mesh tMesh;
	// Use this for initialization
	void Start () {
		Debug.Log("we're back");


		tQuad = GameObject.Find("testMesh");
		tMesh = tQuad.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = tMesh.vertices;
		int i = 0;
		while(i<vertices.Length){
			vertices[i] += Vector3.up * Time.deltaTime;
			i++;
		}
		tMesh.vertices = vertices;
		tMesh.RecalculateBounds();

		foreach(Vector3 vert in vertices){
			Debug.Log(transform.TransformPoint(vert));
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
