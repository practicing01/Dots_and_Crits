function Module_Map_Kana_Study::Load_Characters(%this)
{

//Load Hiragana.

/*%this.Image_Asset_Object_Hiragana=new ImageAsset()
{

ExplicitMode=true;

};

%this.Image_Asset_Object_Hiragana.setImageFile("./../../images/Kana/Hiragana_0.png");

%this.Image_Asset_ID_Hiragana=AssetDatabase.addPrivateAsset(%this.Image_Asset_Object_Hiragana);
*/
/***************************************************************************/

%this.Simset_Map_Hiragana=new SimSet();

%FileObject_File=new FileObject();

//echo("Hiragana.fnt openForRead():" SPC %FileObject_File.openForRead("./Hiragana.fnt"));
%FileObject_File.openForRead("./Hiragana.fnt");

//Get past first 4 lines.
for (%x=0;%x<4;%x++)
{

%String_Line=%FileObject_File.readLine();

}

%Int_Frame_Counter=0;

while (1)
{

%String_Line=%FileObject_File.readLine();

%ScriptObject_Char=new ScriptObject()
{

ID_Unicode=0;

Vector_2D_Texture_Position="0 0";

Vector_2D_Size="0 0";

Image_Asset=0;

Frame=0;

};

%Int_Counter=1;

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"id=");

%ScriptObject_Char.ID_Unicode=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"x=");

%ScriptObject_Char.Vector_2D_Texture_Position.X=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"y=");

%ScriptObject_Char.Vector_2D_Texture_Position.Y=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"width=");

%ScriptObject_Char.Vector_2D_Size.X=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"height=");

%ScriptObject_Char.Vector_2D_Size.Y=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%ScriptObject_Char.Image_Asset="Module_Map_Kana_Study:Image_Hiragana_0";//%this.Image_Asset_ID_Hiragana;

//%this.Image_Asset_Object_Hiragana.addExplicitCell
/*%this.Image_Asset_ID_Hiragana.addExplicitCell
(
%ScriptObject_Char.Vector_2D_Texture_Position.X,
%ScriptObject_Char.Vector_2D_Texture_Position.Y,
%ScriptObject_Char.Vector_2D_Size.X,
%ScriptObject_Char.Vector_2D_Size.Y,
""
);*/

%ScriptObject_Char.Frame=%Int_Frame_Counter;

%Int_Frame_Counter++;

/***********************************************/

%this.Simset_Map_Hiragana.add(%ScriptObject_Char);

/***********************************************/

if (%FileObject_File.isEOF()){break;}

}

%FileObject_File.close();

/*****************************************************************/

//Load Katakana.

/*%this.Image_Asset_Object_Katakana=new ImageAsset()
{

ExplicitMode=true;

};

%this.Image_Asset_Object_Katakana.setImageFile("./../../images/Kana/Katakana_0.png");

%this.Image_Asset_ID_Katakana=AssetDatabase.addPrivateAsset(%this.Image_Asset_Object_Katakana);
*/
/*****************************************************************/

%this.Simset_Map_Katakana=new SimSet();

%FileObject_File=new FileObject();

//echo("Katakana.fnt openForRead():" SPC %FileObject_File.openForRead("./Katakana.fnt"));
%FileObject_File.openForRead("./Katakana.fnt");

//Get past first 4 lines.
for (%x=0;%x<4;%x++)
{

%String_Line=%FileObject_File.readLine();

}

%Int_Frame_Counter=0;

while (1)
{

%String_Line=%FileObject_File.readLine();

%ScriptObject_Char=new ScriptObject()
{

ID_Unicode=0;

Vector_2D_Texture_Position="0 0";

Vector_2D_Size="0 0";

Frame=0;

};

%Int_Counter=1;

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"id=");

%ScriptObject_Char.ID_Unicode=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"x=");

%ScriptObject_Char.Vector_2D_Texture_Position.X=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"y=");

%ScriptObject_Char.Vector_2D_Texture_Position.Y=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"width=");

%ScriptObject_Char.Vector_2D_Size.X=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"height=");

%ScriptObject_Char.Vector_2D_Size.Y=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%ScriptObject_Char.Image_Asset="Module_Map_Kana_Study:Image_Katakana_0";//%this.Image_Asset_ID_Katakana;


//%this.Image_Asset_Object_Katakana.addExplicitCell
/*%this.Image_Asset_ID_Katakana.addExplicitCell
(
%ScriptObject_Char.Vector_2D_Texture_Position.X,
%ScriptObject_Char.Vector_2D_Texture_Position.Y,
%ScriptObject_Char.Vector_2D_Size.X,
%ScriptObject_Char.Vector_2D_Size.Y,
""
);*/

%ScriptObject_Char.Frame=%Int_Frame_Counter;

%Int_Frame_Counter++;

/***********************************************/

%this.Simset_Map_Katakana.add(%ScriptObject_Char);

/***********************************************/

if (%FileObject_File.isEOF()){break;}

}

%FileObject_File.close();

/*********************************************************************/

%FileObject_File=new FileObject();

//echo("Hiragana_Uni.txt openForRead():" SPC %FileObject_File.openForRead("./Hiragana_Uni.txt"));
%FileObject_File.openForRead("./Hiragana_Uni.txt");

%Int_Index=0;

while (1)
{

%String_Line=%FileObject_File.readLine();

%ScriptObject_Char=%this.Simset_Map_Hiragana.getObject(%Int_Index);

//Naughty to not declare Unicode_Character :>.
%ScriptObject_Char.Unicode_Character=%String_Line;

%Int_Index++;

if (%FileObject_File.isEOF()){break;}

}

%FileObject_File.close();

/*******************************************************/

%FileObject_File=new FileObject();

//echo("Katakana_Uni.txt openForRead():" SPC %FileObject_File.openForRead("./Katakana_Uni.txt"));
%FileObject_File.openForRead("./Katakana_Uni.txt");

%Int_Index=0;

while (1)
{

%String_Line=%FileObject_File.readLine();

%ScriptObject_Char=%this.Simset_Map_Katakana.getObject(%Int_Index);

//Naughty to not declare Unicode_Character :>.
%ScriptObject_Char.Unicode_Character=%String_Line;

%Int_Index++;

if (%FileObject_File.isEOF()){break;}

}

%FileObject_File.close();

/*******************************************************/

}
