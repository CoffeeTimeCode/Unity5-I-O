using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CriarArquivo : MonoBehaviour {
	public string _local;

	void Start () {
		_local = Application.dataPath;
		print (_local);
		if (File.Exists (_local + "/" + "arquivo(c#).txt")) {
			print("Esse arquivo ja existe.");
		} else {
			var _arquivo = File.CreateText(_local+"/"+"arquivo(c#).txt");
			_arquivo.WriteLine ("CoffeeTimeCode");
			_arquivo.Close ();	
		}
	}

	void Update () {}
}
