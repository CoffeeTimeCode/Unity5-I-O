#pragma strict
import System.IO;

public var _local : String;
function Start () {
	_local = Application.dataPath;
	print(_local);
	if(File.Exists(_local + "/" + "arquivo(js).txt")){
		print("Esse arquivo ja existe.");
	}else{
		var _arquivo = File.CreateText(_local+"/"+"arquivo(js).txt");
		_arquivo.WriteLine ("CoffeeTimeCode");
		_arquivo.Close ();
	}
}

function Update () {}
