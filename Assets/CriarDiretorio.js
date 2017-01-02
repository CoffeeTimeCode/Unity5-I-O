#pragma strict
import System.IO;

public var _local : String;

function Start () {
	_local = Application.dataPath;
	print(_local);
	if(Directory.Exists(_local+"teste(javascript)")){
		print("Esse diretorio ja existe.");
	}else{
		Directory.CreateDirectory(_local + "/teste(javascript)");
	}
}
function Update () {}