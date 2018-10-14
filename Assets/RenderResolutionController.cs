using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class RenderResolutionController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		XRSettings.eyeTextureResolutionScale = 1.5f;
	}

}
