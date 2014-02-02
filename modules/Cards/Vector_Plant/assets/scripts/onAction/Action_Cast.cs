function Module_Card_Vector_Plant::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
{

%Target_Player=0;

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Game_Connection_Handle==%Player_Sprite_Target_Game_Connection_Handle)
{

%Target_Player=%Player_Object;

break;

}

}

if (%Target_Player==0){return;}

//Use player info to play animations.

/*********************************************************************/

%Int_Max_Size="3 3";

%Int_Max_Size_Half=%Int_Max_Size.X/2 SPC %Int_Max_Size.Y/2;

%Int_Min_Size="1 1";

%Int_Min_Size_Half=%Int_Min_Size.X/2 SPC %Int_Min_Size.Y/2;

%ShapeVector_Size="0.1" SPC mFloatLength(getRandomF(0.2,%Int_Max_Size.Y),2);

%String_Vectors="";

%Int_Max_Shape_Branches=getRandom(0,mPow(4,2));

%Int_Max_Shape_Leaves=getRandom(0,4);

%Int_Shape_Vector_Count=4;

%DefaultRestitution=mFloatLength(getRandomF(0,1),2);

%DefaultDensity=mFloatLength(getRandomF(0,1),2);

if (0)//!getRandom(0,4))//Thin Rectangle Stem
{

%String_Vectors=
"-1" SPC %Int_Max_Size_Half.Y
SPC "1" SPC %Int_Max_Size_Half.Y
SPC "1" SPC mFloatLength(-%Int_Max_Size_Half.Y,2)
SPC "-1" SPC mFloatLength(-%Int_Max_Size_Half.Y,2);

}
else//Leaf
{

%ShapeVector_Size.X=mFloatLength(getRandomF(%Int_Min_Size.X,%Int_Max_Size.X),2);

%ShapeVector_Size.Y=mFloatLength(getRandomF(%Int_Min_Size.Y,%Int_Max_Size.Y),2);

%Int_Shape_Vector_Count=getRandom(3,20);

%Angle_Step=360/%Int_Shape_Vector_Count;

for (%x=0;%x<%Int_Shape_Vector_Count;%x++)
{

%Angle=getRandom(%x*%Angle_Step,(%x+1)*%Angle_Step);

%Vector_2D_Projected=Vector2Direction(%Angle,getRandomF(%Int_Min_Size.Y,%Int_Max_Size_Half.Y));

%Vector_2D_Projected=mFloatLength(%Vector_2D_Projected.X,2) SPC mFloatLength(%Vector_2D_Projected.Y,2);

%String_Vectors=%String_Vectors SPC %Vector_2D_Projected;

}

}

%Color_Line=(mFloatLength(getRandomF(0,1),2) SPC mFloatLength(getRandomF(0,1),2) SPC mFloatLength(getRandomF(0,1),2));

%Color_Fill=%Color_Line;

if (getRandom(0,1))
{

%Color_Fill=(mFloatLength(getRandomF(0,1),2) SPC mFloatLength(getRandomF(0,1),2) SPC mFloatLength(getRandomF(0,1),2));

}

%Fill_Mode=1;//getRandom(0,1);

%String_Parameters=%ShapeVector_Size SPC
%Int_Max_Shape_Branches SPC
%Int_Max_Shape_Leaves SPC
%Int_Shape_Vector_Count SPC
%DefaultRestitution SPC
%DefaultDensity SPC
%Color_Line SPC
%Color_Fill SPC
%Fill_Mode;

%this.Vector_Plant_Count++;

commandToServer('Relay_Module_Function',Module_Card_Vector_Plant,"Action_Grow",
%Player_Sprite_Target_Game_Connection_Handle,%this.Vector_Plant_Count,%String_Parameters,%String_Vectors,1,-1);

}
