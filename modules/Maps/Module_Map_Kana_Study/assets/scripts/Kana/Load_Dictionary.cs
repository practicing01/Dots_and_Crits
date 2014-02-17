function Module_Map_Kana_Study::Load_Dictionary(%this)
{

%this.Simset_Dictionary=new SimSet();

%FileObject_File=new FileStreamObject();

%Bool_Open_Result=%FileObject_File.open("./Kana_Dictionary.txt","Read");

%Int_Random_Position=getRandom(0,%FileObject_File.getStreamSize()-1);

%FileObject_File.setPosition(%Int_Random_Position);

%String_Line=%FileObject_File.readLine();//Get line so the next one is complete.

/***********************************************/

%ScriptObject_Char=new ScriptObject()
{

String_Kanji_Or_Kana="";

String_Definition="";

String_Kana="";

};

/************************************************/

//Search for entry first.

%String_Line=%FileObject_File.readLine();

%Int_Counter=0;

while (1)
{

%Word=getWord(%String_Line,%Int_Counter);

if (strstr(%Word,"<entry>")!=-1)
{

%String_Line=strreplace(%String_Line,"<entry>","");

%String_Line=trim(%String_Line);

%ScriptObject_Char.String_Kana=%String_Line;

%String_Line=%FileObject_File.readLine();

%ScriptObject_Char.String_Definition=%String_Line;

%this.Simset_Dictionary.add(%ScriptObject_Char);

//break;

%FileObject_File.close();

return;//Get just one.

}

%Int_Counter++;

if (%Int_Counter>=strlen(%String_Line))
{

%String_Line=%FileObject_File.readLine();

%Int_Counter=0;

}

if (%FileObject_File.isEOF())
{

%FileObject_File.close();

return;

}

}

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

strreplace(%String_Line,"<entry>","");

trim(%String_Line);

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
