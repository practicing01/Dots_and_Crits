function Module_Map_Kana_Study::Load_Dictionary(%this)
{

%this.Simset_Dictionary=new SimSet();

%FileObject_File=new FileStreamObject();

%Bool_Open_Result=%FileObject_File.open("./Kana_Dictionary.txt","Read");

/***********************************************/

%ScriptObject_Char=new ScriptObject()
{

String_Kanji_Or_Kana="";

String_Definition="";

String_Kana="";

};

/************************************************/

while (1)
{

%String_Line=%FileObject_File.readLine();

%ScriptObject_Char.String_Kana=%String_Line;

//echo("readLine():" SPC %String_Line);

%String_Line=%FileObject_File.readLine();

%ScriptObject_Char.String_Definition=%String_Line;

//echo("readLine():" SPC %String_Line);

%this.Simset_Dictionary.add(%ScriptObject_Char);

if (%FileObject_File.isEOF()){break;}

%ScriptObject_Char=new ScriptObject()
{

String_Kanji_Or_Kana="";

String_Definition="";

String_Kana="";

};

}

/************************************************/

%FileObject_File.close();

}
