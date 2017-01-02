using UnityEngine;
using System.Collections;
using System.IO;

public class CriarDiretorio : MonoBehaviour {
	public string _local;
	void Start () {
		_local = Application.dataPath;
		print (_local);
		if (Directory.Exists (_local + "/teste(c#)")) {
			print("Esse diretorio ja existe.");
		} else {
			Directory.CreateDirectory(_local + "/teste(c#)");
		}
	}
	void Update () {}
}
