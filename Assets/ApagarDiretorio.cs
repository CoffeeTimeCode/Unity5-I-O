using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ApagarDiretorio : MonoBehaviour {
	public string _local;
	
	void Start () {
		_local = Application.dataPath;
		print (_local);
		if (Directory.Exists (_local + "/teste(c#)")) {
			Directory.Delete(_local + "/teste(c#)");
		} else {
			print("Esse diretorio nao existe.");
		}
	}

	void Update () {}
}
