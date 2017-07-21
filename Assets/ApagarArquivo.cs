using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ApagarArquivo : MonoBehaviour {

	public string _local;
	
	void Start () {
		_local = Application.dataPath;
		print (_local);
		if (File.Exists (_local + "/arquivo(c#).txt")) {
			File.Delete(_local + "/arquivo(c#).txt");
		} else {
			print("Esse arquivo nao existe.");
		}
	}

	void Update () {}
}
