function Module_Card_Summon_Unit::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position,%Object_Index)
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

%Sprite_Summon_Unit=new Sprite()
{

class="Class_Summon_Unit";
//CollisionCallback="true";
SceneGroup=25;//25=npcs
SceneLayer=16;

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index;

Health=100;

Bool_Waiting_For_Move=false;

Bool_Waiting_For_Attack=false;

};

%Sprite_Summon_Unit.setCollisionGroups(0,25,26,30);

%Sprite_Summon_Unit.setSize(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Summon_Unit_Stand_Down));

%Sprite_Summon_Unit.setImage("Module_Card_Summon_Unit:Image_Summon_Unit_Stand_Down",0);

%Collision_Shape_Index=%Sprite_Summon_Unit.createPolygonBoxCollisionShape(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Summon_Unit_Stand_Down));

//%Sprite_Summon_Unit.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Sprite_Summon_Unit.setFixedAngle(true);

%Sprite_Summon_Unit.Position=%Vector_2D_Position;

%Sprite_Summon_Unit.Vector_2D_Direction="0 -1";//X,Y

%Sprite_Summon_Unit.Base_Speed=10;

%Sprite_Summon_Unit.Current_Speed=10;

%Sprite_Summon_Unit.Linear_Damping=1;

%Sprite_Summon_Unit.setLinearDamping(%Sprite_Summon_Unit.Linear_Damping);

%Sprite_Summon_Unit.Bool_Is_Mobile=false;

%Sprite_Summon_Unit.Base_Attack=10;

%Sprite_Summon_Unit.Current_Attack=10;

Scene_Dots_and_Crits.add(%Sprite_Summon_Unit);

%Sprite_Summon_Unit.setUseInputEvents(true);

Window_Dots_and_Crits.addInputListener(%Sprite_Summon_Unit);

%Sprite_Summon_Unit.Gui_Menu=%this.Gui_Menu_Create(%Sprite_Summon_Unit);

%this.Simset_Objects.add(%Sprite_Summon_Unit);

/************************************************************************/

%Sprite_Summon_Unit.Simset_Animation_Stand_Up=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Up_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Down_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Down=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Down_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Up_Left=new SimSet();

%Sprite_Summon_Unit.Simset_Animation_Run_Up=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Up_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Down_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Down=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Down_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Up_Left=new SimSet();

%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Up=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Up_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Down_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Down=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Down_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Up_Left=new SimSet();

%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Up=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Up_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Down_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Down=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Down_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Up_Left=new SimSet();

%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Up=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Up_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Down_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Down=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Down_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Up_Left=new SimSet();

%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Up=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Up_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Down_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Down=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Down_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Up_Left=new SimSet();

%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Up=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Up_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Down_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Down=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Down_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Up_Left=new SimSet();

%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Up=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Up_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Down_Right=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Down=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Down_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Left=new SimSet();
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Up_Left=new SimSet();

/************************************************************************/

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Stand_Up";
String_Animation_Name="Animation_Stand_Up";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Stand_Up_Right";
String_Animation_Name="Animation_Stand_Up_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Stand_Up_Left";
String_Animation_Name="Animation_Stand_Up_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Stand_Down";
String_Animation_Name="Animation_Stand_Down";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Stand_Down_Right";
String_Animation_Name="Animation_Stand_Down_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Stand_Down_Left";
String_Animation_Name="Animation_Stand_Down_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Stand_Left";
String_Animation_Name="Animation_Stand_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Stand_Right";
String_Animation_Name="Animation_Stand_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Run_Up";
String_Animation_Name="Animation_Run_Up";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Run_Up_Right";
String_Animation_Name="Animation_Run_Up_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Run_Up_Left";
String_Animation_Name="Animation_Run_Up_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Run_Down";
String_Animation_Name="Animation_Run_Down";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Run_Down_Right";
String_Animation_Name="Animation_Run_Down_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Run_Down_Left";
String_Animation_Name="Animation_Run_Down_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Run_Left";
String_Animation_Name="Animation_Run_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Run_Right";
String_Animation_Name="Animation_Run_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Right.add(%Script_Object_Animation);


/************************************************************************/

%Sprite_Summon_Unit.playAnimation
(
%Sprite_Summon_Unit.Simset_Animation_Stand_Down.getObject
(
getRandom(0,%Sprite_Summon_Unit.Simset_Animation_Stand_Down.getCount()-1)
)
.Asset_ID_Animation
);

/************************************************************************/

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up";
String_Animation_Name="Animation_Attack_Up";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up_Right";
String_Animation_Name="Animation_Attack_Up_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up_Left";
String_Animation_Name="Animation_Attack_Up_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down";
String_Animation_Name="Animation_Attack_Down";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down_Right";
String_Animation_Name="Animation_Attack_Down_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down_Left";
String_Animation_Name="Animation_Attack_Down_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Left";
String_Animation_Name="Animation_Attack_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Right";
String_Animation_Name="Animation_Attack_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Self_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up";
String_Animation_Name="Animation_Attack_Up";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up_Right";
String_Animation_Name="Animation_Attack_Up_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up_Left";
String_Animation_Name="Animation_Attack_Up_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down";
String_Animation_Name="Animation_Attack_Down";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down_Right";
String_Animation_Name="Animation_Attack_Down_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down_Left";
String_Animation_Name="Animation_Attack_Down_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Left";
String_Animation_Name="Animation_Attack_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Right";
String_Animation_Name="Animation_Attack_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Self_Right.add(%Script_Object_Animation);


/************************************************************************/

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up";
String_Animation_Name="Animation_Attack_Up";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up_Right";
String_Animation_Name="Animation_Attack_Up_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up_Left";
String_Animation_Name="Animation_Attack_Up_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down";
String_Animation_Name="Animation_Attack_Down";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down_Right";
String_Animation_Name="Animation_Attack_Down_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down_Left";
String_Animation_Name="Animation_Attack_Down_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Left";
String_Animation_Name="Animation_Attack_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Right";
String_Animation_Name="Animation_Attack_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Cast_Target_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up";
String_Animation_Name="Animation_Attack_Up";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up_Right";
String_Animation_Name="Animation_Attack_Up_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up_Left";
String_Animation_Name="Animation_Attack_Up_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down";
String_Animation_Name="Animation_Attack_Down";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down_Right";
String_Animation_Name="Animation_Attack_Down_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down_Left";
String_Animation_Name="Animation_Attack_Down_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Left";
String_Animation_Name="Animation_Attack_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Right";
String_Animation_Name="Animation_Attack_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Cast_Target_Right.add(%Script_Object_Animation);


/************************************************************************/

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up";
String_Animation_Name="Animation_Attack_Up";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up_Right";
String_Animation_Name="Animation_Attack_Up_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up_Left";
String_Animation_Name="Animation_Attack_Up_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down";
String_Animation_Name="Animation_Attack_Down";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down_Right";
String_Animation_Name="Animation_Attack_Down_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down_Left";
String_Animation_Name="Animation_Attack_Down_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Left";
String_Animation_Name="Animation_Attack_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Right";
String_Animation_Name="Animation_Attack_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Stand_Melee_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up";
String_Animation_Name="Animation_Attack_Up";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up_Right";
String_Animation_Name="Animation_Attack_Up_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Up_Left";
String_Animation_Name="Animation_Attack_Up_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down";
String_Animation_Name="Animation_Attack_Down";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down_Right";
String_Animation_Name="Animation_Attack_Down_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Down_Left";
String_Animation_Name="Animation_Attack_Down_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Left";
String_Animation_Name="Animation_Attack_Left";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Card_Summon_Unit:Animation_Attack_Right";
String_Animation_Name="Animation_Attack_Right";

};
%Sprite_Summon_Unit.Simset_Animation_Run_Melee_Right.add(%Script_Object_Animation);

/************************************************************************/

}
