using UnityEngine;
using System.Collections;

public class carroc : MonoBehaviour {

	void Start () {
		
		GameObject cube1  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube1.transform.position = new Vector3(0.1851258f, 1.212802f, -2.374351f);
		cube1.transform.Rotate(0f,0f,0f);
		cube1.transform.localScale= new Vector3(1.59038f,0.5006871f,2.594095f);
		cube1.AddComponent("BoxCollider");
		cube1.AddComponent("MeshRenderer");
		GameObject cube2  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube2.transform.position = new Vector3(0.1851258f, 1.341494f, -0.5406924f);
		cube2.transform.Rotate(0f,0f,0f);
		cube2.transform.localScale= new Vector3(1.59038f,0.5006871f,-1.219515f);
		cube2.AddComponent("BoxCollider");
		cube2.AddComponent("MeshRenderer");
		GameObject cube3  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube3.transform.position = new Vector3(0.1851258f, 1.1578f, -0.7438473f);
		cube3.transform.Rotate(90f,0f,0f);
		cube3.transform.localScale= new Vector3(1.59038f,0.5006871f,-0.4055409f);
		cube3.AddComponent("BoxCollider");
		cube3.AddComponent("MeshRenderer");
		GameObject cube4  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube4.transform.position = new Vector3(0.1851258f, 2.302082f, -0.6670475f);
		cube4.transform.Rotate(0f,0f,0f);
		cube4.transform.localScale= new Vector3(1.59038f,0.5006871f,-0.9767075f);
		cube4.AddComponent("BoxCollider");
		cube4.AddComponent("MeshRenderer");
		GameObject cube5  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube5.transform.position = new Vector3(0.862036f,1.413467f,-2.371165f);
		cube5.transform.Rotate(0f,0f,0f);
		cube5.transform.localScale= new Vector3(0.2406305f,0.5006871f,2.594095f);
		cube5.AddComponent("BoxCollider");
		cube5.AddComponent("MeshRenderer");
		GameObject cube6  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube6.transform.position = new Vector3(0.1851258f,0.8510752f,-0.6853967f);
		cube6.transform.Rotate(0f,0f,0f);
		cube6.transform.localScale= new Vector3(1.59038f,0.5006871f,3.349324f);
		cube6.AddComponent("BoxCollider");
		cube6.AddComponent("MeshRenderer");
		GameObject cube7  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube7.transform.position = new Vector3(0.1851258f,1.341675f,0.5007968f);
		cube7.transform.Rotate(12.13944f,0f,0f);
		cube7.transform.localScale= new Vector3(1.59038f,0.5006871f,-0.9767075f);
		cube7.AddComponent("BoxCollider");
		cube7.AddComponent("MeshRenderer");
		GameObject cube8  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube8.transform.position = new Vector3(0.1851258f,0.8510752f,-1.995752f);
		cube8.transform.Rotate(0f,0f,0f);
		cube8.transform.localScale= new Vector3(1.59038f,0.5006871f,3.349324f);
		cube8.AddComponent("BoxCollider");
		cube8.AddComponent("MeshRenderer");
		GameObject cube9 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube9.transform.position = new Vector3(0.1851258f,2.009713f,-0.2253701f);
		cube9.transform.Rotate(70.31223f,0f,0f);
		cube9.transform.localScale= new Vector3(1.59038f,0.5006871f,-0.9767076f);
		cube9.AddComponent("BoxCollider");
		cube9.AddComponent("MeshRenderer");
		GameObject cube10  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube10.transform.position = new Vector3(0.1851258f,1.841046f,-0.6670475f);
		cube10.transform.Rotate(0f,0f,0f);
		cube10.transform.localScale= new Vector3(1.59038f,0.5006871f,-0.9767075f);
		cube10.AddComponent("BoxCollider");
		cube10.AddComponent("MeshRenderer");
		GameObject cube11  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube11.transform.position = new Vector3(0.1699725f,1.413467f,-3.546809f);
		cube11.transform.Rotate(0f,90f,0f);
		cube11.transform.localScale= new Vector3(0.2406305f,0.5006871f,1.326656f);
		cube11.AddComponent("BoxCollider");
		cube11.AddComponent("MeshRenderer");
		GameObject cube12  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube12.transform.position = new Vector3(-0.5009881f,1.413467f,-2.374882f);
		cube12.transform.Rotate(0f,0f,0f);
		cube12.transform.localScale= new Vector3(0.2406305f,0.5006871f,2.594095f);
		cube12.AddComponent("BoxCollider");
		cube12.AddComponent("MeshRenderer");
		GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder.transform.position = new Vector3(1.081525f,0.8510752f,0.2259815f);
		cylinder.transform.Rotate(90f,270f,0f);
		cylinder.transform.localScale= new Vector3(1.225088f,0.09770568f,1.225088f);
		cylinder.AddComponent("CapsuleCollider");
		cylinder.AddComponent("MeshRenderer");
		GameObject cylinder2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder2.transform.position = new Vector3(-0.7125183f,0.8510752f,-2.906469f);
		cylinder2.transform.Rotate(90f,270f,0f);
		cylinder2.transform.localScale= new Vector3(1.225088f,0.09770568f,1.225088f);
		cylinder2.AddComponent("CapsuleCollider");
		cylinder2.AddComponent("MeshRenderer");
		GameObject cylinder3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder3.transform.position = new Vector3(1.081525f,0.8510752f,-2.906469f);
		cylinder3.transform.Rotate(90f,270f,0f);
		cylinder3.transform.localScale= new Vector3(1.225088f,0.09770568f,1.225088f);
		cylinder3.AddComponent("CapsuleCollider");
		cylinder3.AddComponent("MeshRenderer");
		GameObject cylinder4 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder4.transform.position = new Vector3(-0.7125183f,0.8510752f,0.2259815f);
		cylinder4.transform.Rotate(90f,270f,0f);
		cylinder4.transform.localScale= new Vector3(1.225088f,0.09770568f,1.225088f);
		cylinder4.AddComponent("CapsuleCollider");
		cylinder4.AddComponent("MeshRenderer");
		
	}
	
	void Update () {
		
	}
}
