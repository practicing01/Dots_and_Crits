function Module_Card_Vector_Plant::Action_Grow(%this,%Player_Information,%Object_Game_Connection_Handle,%Unit_Object_Index,%String_Parameters,%String_Vectors,%Bool_Is_Root,%Object_Index)
{

%Script_Object_Player=%Player_Information.Player_Sprite_Data.Sprite.Script_Object_Parent;

%Plant_Parent=-1;

for (%x=0;%x<%this.Simset_Objects.getCount();%x++)
{

%Object=%this.Simset_Objects.getObject(%x);

if (%Object.Object_Index==%Unit_Object_Index&&%Object.Game_Connection_Handle==%Object_Game_Connection_Handle)
{

%Plant_Parent=%Object;

break;

}

}

//if (!isObject(%Plant_Parent)){return;}

if (%Plant_Parent!=-1)
{

if (%Plant_Parent.Int_Branch_Count>%Plant_Parent.Int_Max_Shape_Branches){return;}

%Plant_Parent.Increment_Branch_Counter();

}

/*********************************************************************/

%Target_Player=0;

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Game_Connection_Handle==%Object_Game_Connection_Handle)
{

%Target_Player=%Player_Object;

break;

}

}

if (%Target_Player==0){return;}

/*********************************************************************/

%ShapeVector_Size=0;
%Int_Max_Shape_Branches=0;
%Int_Max_Shape_Leaves=0;
%Int_Shape_Vector_Count=0;
%DefaultRestitution=0;
%DefaultDensity=0;
%Color_Line=0;
%Color_Fill=0;
%Fill_Mode=0;

if (%Bool_Is_Root&&%Object_Index==-1)
{

//Extract parameters
%Parameter_Count=0;

%ShapeVector_Size=getWord(%String_Parameters,%Parameter_Count) SPC getWord(%String_Parameters,%Parameter_Count+1);

%Parameter_Count+=2;

%Int_Max_Shape_Branches=getWord(%String_Parameters,%Parameter_Count);

%Parameter_Count++;

%Int_Max_Shape_Leaves=getWord(%String_Parameters,%Parameter_Count);

%Parameter_Count++;

%Int_Shape_Vector_Count=getWord(%String_Parameters,%Parameter_Count);

%Parameter_Count++;

%DefaultRestitution=getWord(%String_Parameters,%Parameter_Count);

%Parameter_Count++;

%DefaultDensity=getWord(%String_Parameters,%Parameter_Count);

%Parameter_Count++;

%Color_Line=getWord(%String_Parameters,%Parameter_Count) SPC getWord(%String_Parameters,%Parameter_Count+1) SPC getWord(%String_Parameters,%Parameter_Count+2);

%Parameter_Count+=3;

%Color_Fill=getWord(%String_Parameters,%Parameter_Count) SPC getWord(%String_Parameters,%Parameter_Count+1) SPC getWord(%String_Parameters,%Parameter_Count+2);

%Parameter_Count+=3;

%Fill_Mode=getWord(%String_Parameters,%Parameter_Count);

}
else
{

%ShapeVector_Size=%Plant_Parent.Size;
%Int_Max_Shape_Branches=%Plant_Parent.Int_Max_Shape_Branches;
%Int_Max_Shape_Leaves=%Plant_Parent.Int_Max_Shape_Leaves;
%Int_Shape_Vector_Count=%Plant_Parent.Int_Shape_Vector_Count;
%DefaultRestitution=%Plant_Parent.DefaultRestitution;
%DefaultDensity=%Plant_Parent.DefaultDensity;
%Color_Line=%Plant_Parent.Color_Line;
%Color_Fill=%Plant_Parent.Color_Fill;
%Fill_Mode=%Plant_Parent.Fill_Mode;

%String_Vectors=%Plant_Parent.getPoly();

}
/*********************************************************************/

//Grow based on parameters.

%Shape_Vector_Plant=new ShapeVector()
{

Size=%ShapeVector_Size;
class="Class_Vector_Plant";
CollisionCallback="true";
SceneLayer=16;
DefaultRestitution=%DefaultRestitution;
DefaultDensity=%DefaultDensity;
BodyType="dynamic";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=%Object_Game_Connection_Handle;

Object_Index=%Object_Index;

Health=100;

Schedule_AI=0;

Int_Shape_Vector_Count=%Int_Shape_Vector_Count;

Int_Max_Shape_Branches=%Int_Max_Shape_Branches;

Int_Max_Shape_Leaves=%Int_Max_Shape_Leaves;

Plant_Parent=%Plant_Parent;

Int_Branch_Count=0;

Int_Leaf_Count=0;

Color_Line=%Color_Line;

Color_Fill=%Color_Fill;

Fill_Mode=%Fill_Mode;

};

%Shape_Vector_Plant.setPolyCustom(%Int_Shape_Vector_Count,%String_Vectors);

%Shape_Vector_Plant.setLineColor(%Color_Line);

%Shape_Vector_Plant.setFillColor(%Color_Fill);

%Shape_Vector_Plant.setFillMode(%Fill_Mode);

%Shape_Vector_Plant.setCollisionGroups(0,25,26,30);

%Collision_Shape_Index=%Shape_Vector_Plant.createPolygonBoxCollisionShape(%Shape_Vector_Plant.Size);

if (%Object_Index==-1)
{

%Shape_Vector_Plant.Object_Index=%Unit_Object_Index;

%Vector_2D_Target_Player_Sprite_Size=0;

%Shape_Vector_Plant.Position=%Target_Player.Player_Sprite_Data.Sprite.Position;

%Vector_2D_Target_Player_Sprite_Size=%Target_Player.Player_Sprite_Data.Sprite.getSize();

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Target_Player_Sprite_Size.Y/2)+(%ShapeVector_Size.Y/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Target_Player_Sprite_Size;

%Vector_2D_Rotated_Square_Offset.Y=%Vector_2D_Rotated_Square_Offset.Y/3;

%Vector_2D_Mount_Offset.Y+=%Vector_2D_Rotated_Square_Offset.Y;

Scene_Dots_and_Crits.add(%Shape_Vector_Plant);

%Shape_Vector_Plant.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(0));

%Shape_Vector_Plant.dismount();

%Shape_Vector_Plant.Position=%Shape_Vector_Plant.Position;

}
else if (%Plant_Parent!=-1)
{

%Shape_Vector_Plant.Int_Branch_Count=%Plant_Parent.Int_Branch_Count;

%Vector_2D_Mount_Offset=Vector2Direction(getRandom(0,360),(%ShapeVector_Size.Y)+(%Plant_Parent.Size.Y));

%Shape_Vector_Plant.Position=Vector2Add(%Plant_Parent.Position,%Vector_2D_Mount_Offset);

Scene_Dots_and_Crits.add(%Shape_Vector_Plant);

Scene_Dots_and_Crits.createDistanceJoint(%Plant_Parent,%Shape_Vector_Plant,
Vector2Distance(%Plant_Parent.Position,%Shape_Vector_Plant.Position),"0 0","0 0",0,1,false);

//Scene_Dots_and_Crits.createRopeJoint(%Plant_Parent,%Shape_Vector_Plant,
//"0 0","0 0",Vector2Distance(%Plant_Parent.Position,%Shape_Vector_Plant.Position),false);

//Scene_Dots_and_Crits.createWeldJoint(%Plant_Parent,%Shape_Vector_Plant,
//%Plant_Parent.getLocalVector(%Shape_Vector_Plant.Position),%Shape_Vector_Plant.getLocalVector(%Plant_Parent.Position),0,1,false);

}

%this.Simset_Objects.add(%Shape_Vector_Plant);

%Shape_Vector_Plant.Schedule_AI=schedule(500,0,"Class_Vector_Plant::Schedule_AI",%Shape_Vector_Plant);

}
