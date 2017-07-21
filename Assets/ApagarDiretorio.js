#pragma strict
import System.IO;

public var _local : String;

function Start () {
	_local = Application.dataPath;
	print(_local);
	if(Directory.Exists(_local+"/teste(javascript)")){
		Directory.Delete(_local + "/teste(javascript)");		
	}else{
		print("Esse diretorio nao existe.");
	}
}

function Update () {}
