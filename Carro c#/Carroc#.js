#pragma strict

function Start () {

		var cube : GameObject  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.transform.position = Vector3(0.1851258, 1.212802, -2.374351);
		cube.transform.Rotate(0f,0f,0f);
		cube.transform.localScale=Vector3(1.59038,0.5006871,2.594095);
		cube.AddComponent("BoxCollider");
		cube.AddComponent("MeshRenderer");
		var cube2 : GameObject  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube2.transform.position = Vector3(0.1851258, 1.341494, -0.5406924);
		cube2.transform.Rotate(0f,0f,0f);
		cube2.transform.localScale=Vector3(1.59038,0.5006871,-1.219515);
		cube2.AddComponent("BoxCollider");
		cube2.AddComponent("MeshRenderer");
		var cube3 : GameObject  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube3.transform.position = Vector3(0.1851258, 1.1578, -0.7438473);
		cube3.transform.Rotate(90f,0f,0f);
		cube3.transform.localScale=Vector3(1.59038,0.5006871,-0.4055409);
		cube3.AddComponent("BoxCollider");
		cube3.AddComponent("MeshRenderer");
		var cube4 : GameObject  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube4.transform.position = Vector3(0.1851258, 2.302082, -0.6670475);
		cube4.transform.Rotate(0f,0f,0f);
		cube4.transform.localScale=Vector3(1.59038,0.5006871,-0.9767075);
		cube4.AddComponent("BoxCollider");
		cube4.AddComponent("MeshRenderer");
		var cube5 : GameObject  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube5.transform.position = Vector3(0.862036,1.413467,-2.371165);
		cube5.transform.Rotate(0f,0f,0f);
		cube5.transform.localScale=Vector3(0.2406305,0.5006871,2.594095);
		cube5.AddComponent("BoxCollider");
		cube5.AddComponent("MeshRenderer");
		var cube6 : GameObject  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube6.transform.position = Vector3(0.1851258,0.8510752,-0.6853967);
		cube6.transform.Rotate(0f,0f,0f);
		cube6.transform.localScale=Vector3(1.59038,0.5006871,3.349324);
		cube6.AddComponent("BoxCollider");
		cube6.AddComponent("MeshRenderer");
		var cube7 : GameObject  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube7.transform.position = Vector3(0.1851258,1.341675,0.5007968);
		cube7.transform.Rotate(12.13944f,0f,0f);
		cube7.transform.localScale=Vector3(1.59038,0.5006871,-0.9767075);
		cube7.AddComponent("BoxCollider");
		cube7.AddComponent("MeshRenderer");
		var cube8 : GameObject  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube8.transform.position = Vector3(0.1851258,0.8510752,-1.995752);
		cube8.transform.Rotate(0f,0f,0f);
		cube8.transform.localScale=Vector3(1.59038,0.5006871,3.349324);
		cube8.AddComponent("BoxCollider");
		cube8.AddComponent("MeshRenderer");
		var cube9 : GameObject  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube9.transform.position = Vector3(0.1851258,2.009713,-0.2253701);
		cube9.transform.Rotate(70.31223f,0f,0f);
		cube9.transform.localScale=Vector3(1.59038,0.5006871,-0.9767076);
		cube9.AddComponent("BoxCollider");
		cube9.AddComponent("MeshRenderer");
		var cube10 : GameObject  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube10.transform.position = Vector3(0.1851258,1.841046,-0.6670475);
		cube10.transform.Rotate(0f,0f,0f);
		cube10.transform.localScale=Vector3(1.59038,0.5006871,-0.9767075);
		cube10.AddComponent("BoxCollider");
		cube10.AddComponent("MeshRenderer");
		var cube11 : GameObject  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube11.transform.position = Vector3(0.1699725,1.413467,-3.546809);
		cube11.transform.Rotate(0f,90f,0f);
		cube11.transform.localScale=Vector3(0.2406305,0.5006871,1.326656);
		cube11.AddComponent("BoxCollider");
		cube11.AddComponent("MeshRenderer");
		var cube12 : GameObject  = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube12.transform.position = Vector3(-0.5009881,1.413467,-2.374882);
		cube12.transform.Rotate(0f,0f,0f);
		cube12.transform.localScale=Vector3(0.2406305,0.5006871,2.594095);
		cube12.AddComponent("BoxCollider");
		cube12.AddComponent("MeshRenderer");
		var cylinder : GameObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder.transform.position = Vector3(1.081525,0.8510752,0.2259815);
		cylinder.transform.Rotate(90f,270f,0f);
		cylinder.transform.localScale= Vector3(1.225088,0.09770568,1.225088);
		cylinder.AddComponent("CapsuleCollider");
		cylinder.AddComponent("MeshRenderer");
		var cylinder2 : GameObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder2.transform.position = Vector3(-0.7125183,0.8510752,-2.906469);
		cylinder2.transform.Rotate(90f,270f,0f);
		cylinder2.transform.localScale= Vector3(1.225088,0.09770568,1.225088);
		cylinder2.AddComponent("CapsuleCollider");
		cylinder2.AddComponent("MeshRenderer");
		var cylinder3 : GameObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder3.transform.position = Vector3(1.081525,0.8510752,-2.906469);
		cylinder3.transform.Rotate(90f,270f,0f);
		cylinder3.transform.localScale= Vector3(1.225088,0.09770568,1.225088);
		cylinder3.AddComponent("CapsuleCollider");
		cylinder3.AddComponent("MeshRenderer");
		var cylinder4 : GameObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder4.transform.position = Vector3(-0.7125183,0.8510752,0.2259815);
		cylinder4.transform.Rotate(90f,270f,0f);
		cylinder4.transform.localScale= Vector3(1.225088,0.09770568,1.225088);
		cylinder4.AddComponent("CapsuleCollider");
		cylinder4.AddComponent("MeshRenderer");
		
}

function Update () {

}