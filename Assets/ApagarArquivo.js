#pragma strict
import System.IO;

public var _local : String;
function Start () {
	_local = Application.dataPath;
	print(_local);
	if (File.Exists (_local + "/arquivo(js).txt")) {
		File.Delete(_local + "/arquivo(js).txt");
	} else {
		print("Esse arquivo nao existe.");
	}
}

function Update () {}
