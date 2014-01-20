function Module_Player_Sprite_Lelur::Player_Sprite_Spawn(%this,%Game_Connection_Handle)
{

%Script_Object_Player_Sprite=new ScriptObject();

/************************************************************************/

%Script_Object_Player_Sprite.Game_Connection_Handle=%Game_Connection_Handle;

%this.Simset_Player_Information.add(%Script_Object_Player_Sprite);

/************************************************************************/

%Script_Object_Player_Sprite.Composite_Sprite=new CompositeSprite()
{

class="Class_Composite_Sprite_Player";
CollisionCallback="true";
SceneGroup=0;//0=players
SceneLayer=15;

Asset_ID_Animation_Emote="";

Schedule_Animation_Reset=0;

Module_ID_Parent=%this;

Script_Object_Parent=%Script_Object_Player_Sprite;

};

%Script_Object_Player_Sprite.Composite_Sprite.CollisionGroups=bit(0)|bit(25)|bit(26)|bit(30);//0=players, 25=npcs, 26=world objects, 30=walls
%Script_Object_Player_Sprite.Composite_Sprite.SetBatchLayout("off");
%Script_Object_Player_Sprite.Composite_Sprite.SetBatchSortMode("z");
%Script_Object_Player_Sprite.Composite_Sprite.SetBatchIsolated(true);

/************************************************************************/

%Script_Object_Player_Sprite.Composite_Sprite.clearSprites();
%Script_Object_Player_Sprite.Sprite_ID=%Script_Object_Player_Sprite.Composite_Sprite.addSprite();
%Script_Object_Player_Sprite.Composite_Sprite.setSpriteLocalPosition(0,0);
%Script_Object_Player_Sprite.Composite_Sprite.setSpriteSize(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Lelur_Stand_Down));
%Script_Object_Player_Sprite.Composite_Sprite.setSpriteImage("Module_Player_Sprite_Lelur:Image_Lelur_Stand_Down",0);
%Script_Object_Player_Sprite.Composite_Sprite.SetSpriteDepth(1);

/************************************************************************/

%Script_Object_Player_Sprite.Composite_Sprite.clearCollisionShapes();

/*Since the sprite is 256*256 but we want a 128*128 collision box, we scale it.*/
/*
%Scaled_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Lelur_Stand_Down);

%Scaled_Size.X/=2;

%Scaled_Size.Y/=2;
*/
%Collision_Shape_Index=%Script_Object_Player_Sprite.Composite_Sprite.createPolygonBoxCollisionShape(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Lelur_Stand_Down));

//%Script_Object_Player_Sprite.Composite_Sprite.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Script_Object_Player_Sprite.Composite_Sprite.setFixedAngle(true);
%Script_Object_Player_Sprite.Composite_Sprite.Position="0 0";
//%Script_Object_Player_Sprite.Composite_Sprite.setUpdateCallback(true);

/************************************************************************/

%Script_Object_Player_Sprite.Vector_2D_Direction="0 -1";//X,Y
%Script_Object_Player_Sprite.Base_Speed=10;
%Script_Object_Player_Sprite.Current_Speed=10;

%Script_Object_Player_Sprite.Linear_Damping=1;
%Script_Object_Player_Sprite.Composite_Sprite.setLinearDamping(%Script_Object_Player_Sprite.Linear_Damping);

%Script_Object_Player_Sprite.Bool_Is_Mobile=false;

/************************************************************************/

%Script_Object_Player_Sprite.Health=100;

/************************************************************************/

%Script_Object_Player_Sprite.Base_Attack=10;

%Script_Object_Player_Sprite.Current_Attack=10;

/************************************************************************/

%Script_Object_Player_Sprite.Composite_Sprite.setUseInputEvents(true);
Window_Dots_and_Crits.addInputListener(%Script_Object_Player_Sprite.Composite_Sprite);

/************************************************************************/

%Script_Object_Player_Sprite.Gui_Menu=%this.Gui_Menu_Create(%Script_Object_Player_Sprite.Composite_Sprite);

/************************************************************************/

%Script_Object_Player_Sprite.Scene_Object_Mount=new SceneObject()
{

BodyType="static";
size=%Script_Object_Player_Sprite.Composite_Sprite.getSpriteSize();
Position="0 0";
Angle="180";

};

%Script_Object_Player_Sprite.Simset_Objects_To_Dismount=new SimSet();

/************************************************************************/

%Script_Object_Player_Sprite.Simset_Animation_Stand_Up=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Up_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Down_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Down=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Down_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Up_Left=new SimSet();

%Script_Object_Player_Sprite.Simset_Animation_Run_Up=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Up_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Down_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Down=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Down_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Up_Left=new SimSet();

%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Up=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Up_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Down_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Down=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Down_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Up_Left=new SimSet();

%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Up=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Up_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Down_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Down=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Down_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Up_Left=new SimSet();

%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Up=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Up_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Down_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Down=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Down_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Up_Left=new SimSet();

%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Up=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Up_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Down_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Down=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Down_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Up_Left=new SimSet();

%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Up=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Up_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Down_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Down=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Down_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Up_Left=new SimSet();

%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Up=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Up_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Down_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Down=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Down_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Up_Left=new SimSet();

%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up_Left=new SimSet();

%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down_Right=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Left=new SimSet();
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up_Left=new SimSet();

/************************************************************************/

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Stand_Up";
String_Animation_Name="Animation_Stand_Up";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Stand_Up_Right";
String_Animation_Name="Animation_Stand_Up_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Stand_Up_Left";
String_Animation_Name="Animation_Stand_Up_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Stand_Down";
String_Animation_Name="Animation_Stand_Down";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Stand_Down_Right";
String_Animation_Name="Animation_Stand_Down_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Stand_Down_Left";
String_Animation_Name="Animation_Stand_Down_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Stand_Left";
String_Animation_Name="Animation_Stand_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Stand_Right";
String_Animation_Name="Animation_Stand_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Run_Up";
String_Animation_Name="Animation_Run_Up";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Run_Up_Right";
String_Animation_Name="Animation_Run_Up_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Run_Up_Left";
String_Animation_Name="Animation_Run_Up_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Run_Down";
String_Animation_Name="Animation_Run_Down";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Run_Down_Right";
String_Animation_Name="Animation_Run_Down_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Run_Down_Left";
String_Animation_Name="Animation_Run_Down_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Run_Left";
String_Animation_Name="Animation_Run_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Run_Right";
String_Animation_Name="Animation_Run_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Right.add(%Script_Object_Animation);


/************************************************************************/

%Script_Object_Player_Sprite.Composite_Sprite.setSpriteAnimation
(
%Script_Object_Player_Sprite.Simset_Animation_Stand_Down.getObject
(
getRandom(0,%Script_Object_Player_Sprite.Simset_Animation_Stand_Down.getCount()-1)
)
.Asset_ID_Animation
);

/************************************************************************/

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up";
String_Animation_Name="Animation_Attack_Up";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up_Right";
String_Animation_Name="Animation_Attack_Up_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up_Left";
String_Animation_Name="Animation_Attack_Up_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down";
String_Animation_Name="Animation_Attack_Down";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down_Right";
String_Animation_Name="Animation_Attack_Down_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down_Left";
String_Animation_Name="Animation_Attack_Down_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Left";
String_Animation_Name="Animation_Attack_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Right";
String_Animation_Name="Animation_Attack_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Self_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up";
String_Animation_Name="Animation_Attack_Up";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up_Right";
String_Animation_Name="Animation_Attack_Up_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up_Left";
String_Animation_Name="Animation_Attack_Up_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down";
String_Animation_Name="Animation_Attack_Down";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down_Right";
String_Animation_Name="Animation_Attack_Down_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down_Left";
String_Animation_Name="Animation_Attack_Down_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Left";
String_Animation_Name="Animation_Attack_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Right";
String_Animation_Name="Animation_Attack_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Self_Right.add(%Script_Object_Animation);


/************************************************************************/

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up";
String_Animation_Name="Animation_Attack_Up";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up_Right";
String_Animation_Name="Animation_Attack_Up_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up_Left";
String_Animation_Name="Animation_Attack_Up_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down";
String_Animation_Name="Animation_Attack_Down";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down_Right";
String_Animation_Name="Animation_Attack_Down_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down_Left";
String_Animation_Name="Animation_Attack_Down_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Left";
String_Animation_Name="Animation_Attack_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Right";
String_Animation_Name="Animation_Attack_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Cast_Target_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up";
String_Animation_Name="Animation_Attack_Up";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up_Right";
String_Animation_Name="Animation_Attack_Up_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up_Left";
String_Animation_Name="Animation_Attack_Up_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down";
String_Animation_Name="Animation_Attack_Down";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down_Right";
String_Animation_Name="Animation_Attack_Down_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down_Left";
String_Animation_Name="Animation_Attack_Down_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Left";
String_Animation_Name="Animation_Attack_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Right";
String_Animation_Name="Animation_Attack_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Cast_Target_Right.add(%Script_Object_Animation);


/************************************************************************/

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up";
String_Animation_Name="Animation_Attack_Up";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up_Right";
String_Animation_Name="Animation_Attack_Up_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up_Left";
String_Animation_Name="Animation_Attack_Up_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down";
String_Animation_Name="Animation_Attack_Down";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down_Right";
String_Animation_Name="Animation_Attack_Down_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down_Left";
String_Animation_Name="Animation_Attack_Down_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Left";
String_Animation_Name="Animation_Attack_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Right";
String_Animation_Name="Animation_Attack_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Melee_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up";
String_Animation_Name="Animation_Attack_Up";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up_Right";
String_Animation_Name="Animation_Attack_Up_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Up_Left";
String_Animation_Name="Animation_Attack_Up_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down";
String_Animation_Name="Animation_Attack_Down";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down_Right";
String_Animation_Name="Animation_Attack_Down_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Down_Left";
String_Animation_Name="Animation_Attack_Down_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Left";
String_Animation_Name="Animation_Attack_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Attack_Right";
String_Animation_Name="Animation_Attack_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Melee_Right.add(%Script_Object_Animation);


/************************************************************************/

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Up";
String_Animation_Name="Animation_Emote_Attack_Up";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Up_Right";
String_Animation_Name="Animation_Emote_Attack_Up_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Up_Left";
String_Animation_Name="Animation_Emote_Attack_Up_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Down";
String_Animation_Name="Animation_Emote_Attack_Down";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Down_Right";
String_Animation_Name="Animation_Emote_Attack_Down_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Down_Left";
String_Animation_Name="Animation_Emote_Attack_Down_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Left";
String_Animation_Name="Animation_Emote_Attack_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Right";
String_Animation_Name="Animation_Emote_Attack_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Up";
String_Animation_Name="Animation_Emote_Attack_Up";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Up_Right";
String_Animation_Name="Animation_Emote_Attack_Up_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Up_Left";
String_Animation_Name="Animation_Emote_Attack_Up_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Down";
String_Animation_Name="Animation_Emote_Attack_Down";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Down_Right";
String_Animation_Name="Animation_Emote_Attack_Down_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down_Right.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Down_Left";
String_Animation_Name="Animation_Emote_Attack_Down_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Left";
String_Animation_Name="Animation_Emote_Attack_Left";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Left.add(%Script_Object_Animation);

%Script_Object_Animation=new ScriptObject()
{

Asset_ID_Animation="Module_Player_Sprite_Lelur:Animation_Emote_Attack_Right";
String_Animation_Name="Animation_Emote_Attack_Right";

};
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Right.add(%Script_Object_Animation);


/************************************************************************/

//Projectile Launch Origins:  Each direction can have multiple origins.

%Script_Object_Player_Sprite.Simset_Projectile_Origin_Direction=new SimSet();

%Simset_Direction_Up=new SimSet();
%Simset_Direction_Up_Right=new SimSet();
%Simset_Direction_Right=new SimSet();
%Simset_Direction_Down_Right=new SimSet();
%Simset_Direction_Down=new SimSet();
%Simset_Direction_Down_Left=new SimSet();
%Simset_Direction_Left=new SimSet();
%Simset_Direction_Up_Left=new SimSet();

%Script_Object_Player_Sprite.Simset_Projectile_Origin_Direction.add(%Simset_Direction_Up);
%Script_Object_Player_Sprite.Simset_Projectile_Origin_Direction.add(%Simset_Direction_Up_Right);
%Script_Object_Player_Sprite.Simset_Projectile_Origin_Direction.add(%Simset_Direction_Right);
%Script_Object_Player_Sprite.Simset_Projectile_Origin_Direction.add(%Simset_Direction_Down_Right);
%Script_Object_Player_Sprite.Simset_Projectile_Origin_Direction.add(%Simset_Direction_Down);
%Script_Object_Player_Sprite.Simset_Projectile_Origin_Direction.add(%Simset_Direction_Down_Left);
%Script_Object_Player_Sprite.Simset_Projectile_Origin_Direction.add(%Simset_Direction_Left);
%Script_Object_Player_Sprite.Simset_Projectile_Origin_Direction.add(%Simset_Direction_Up_Left);

%Sprite_Size=%Script_Object_Player_Sprite.Composite_Sprite.getSpriteSize();

//Up
%Projectile_Origin=new ScriptObject()
{

X=0;
Y=%Sprite_Size.Y/2;

};

%Simset_Direction_Up.add(%Projectile_Origin);

//Down
%Projectile_Origin=new ScriptObject()
{

X=0;
Y=-(%Sprite_Size.Y/2);

};

%Simset_Direction_Down.add(%Projectile_Origin);

//Left
%Projectile_Origin=new ScriptObject()
{

X=-(%Sprite_Size.X/2);
Y=0;

};

%Simset_Direction_Left.add(%Projectile_Origin);

//Right
%Projectile_Origin=new ScriptObject()
{

X=%Sprite_Size.X/2;
Y=0;

};

%Simset_Direction_Right.add(%Projectile_Origin);

//Up Right
%Projectile_Origin=new ScriptObject()
{

X=%Sprite_Size.X/2;
Y=%Sprite_Size.Y/2;

};

%Simset_Direction_Up_Right.add(%Projectile_Origin);

//Up Left
%Projectile_Origin=new ScriptObject()
{

X=-(%Sprite_Size.X/2);
Y=%Sprite_Size.Y/2;

};

%Simset_Direction_Up_Left.add(%Projectile_Origin);

//Down Right
%Projectile_Origin=new ScriptObject()
{

X=%Sprite_Size.X/2;
Y=-(%Sprite_Size.Y/2);

};

%Simset_Direction_Down_Right.add(%Projectile_Origin);

//Down Left
%Projectile_Origin=new ScriptObject()
{

X=-(%Sprite_Size.X/2);
Y=-(%Sprite_Size.Y/2);

};

%Simset_Direction_Down_Left.add(%Projectile_Origin);

return %Script_Object_Player_Sprite;

}
