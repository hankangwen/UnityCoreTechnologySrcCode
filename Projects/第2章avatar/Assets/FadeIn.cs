using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {

	public float lifeCycle = 2.0f;

	float startTime;
	Material mat = null;

	// Use this for initialization
	void Start () 
	{
		startTime = Time.time;

		MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
		if( !meshRenderer || !meshRenderer.material)
		{
			base.enabled = false;
		}
		else
		{
			mat = meshRenderer.material;
			ReplaceShader();
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		float time = Time.time - startTime;
		if(time > lifeCycle)
		{
			//Destroy self.
			DestroyImmediate(gameObject);
		}
		else
		{
			float remainderTime = lifeCycle - time;
			if( mat )
			{
				Color col = mat.GetColor("_Color");
				col.a = remainderTime;
				mat.SetColor("_Color", col);

				col = mat.GetColor("_OutlineColor");
				col.a = remainderTime;
				mat.SetColor("_OutlineColor", col);
			}
		}
	}

	private void ReplaceShader()
	{
		if(mat.shader.name.Equals( "JiuYinT/Toon/Basic Outline" ))
		{
			mat.shader = Shader.Find("JiuYinT/Toon/Basic Outline Replace");
		}
		else if(mat.shader.name.Equals( "JiuYinT/Toon/Basic" ))
		{
			mat.shader = Shader.Find("JiuYinT/Toon/Basic Replace");
		}
		else 
		{
			Debug.LogError("Can't find target shader");
		}
	}
}
