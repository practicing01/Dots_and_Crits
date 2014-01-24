function Module_Card_Sword::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Object_Index)
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

%Player_Object=0;

for (%x=0;%x<%this.Simset_Player_Information.getCount();%x++)
{

%Player_Object=%this.Simset_Player_Information.getObject(%x);

if (%Player_Object.Player_Information.Game_Connection_Handle==%Target_Player.Game_Connection_Handle)
{

break;

}
else
{

%Player_Object=0;

}

}

if (%Player_Object==0)//New Sword user.
{

%Script_Object_Player_Information=new ScriptObject()
{

Player_Information=%Target_Player;

Scene_Object_Anchor=0;

Sprite_Sword=0;

};

%Script_Object_Player_Information.Scene_Object_Anchor=new SceneObject()
{

BodyType="dynamic";
size="1 1";
Position=%Target_Player.Player_Sprite_Data.Sprite.Position;

Joint_ID=0;

};

Scene_Dots_and_Crits.add(%Script_Object_Player_Information.Scene_Object_Anchor);

%Script_Object_Player_Information.Scene_Object_Anchor.Joint_ID=Scene_Dots_and_Crits.createRopeJoint
(
%Target_Player.Player_Sprite_Data.Sprite,
%Script_Object_Player_Information.Scene_Object_Anchor,
"0 0","0 0",5.0,false
);

%Vector_2D_Sword_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Sword);

%Script_Object_Player_Information.Sprite_Sword=new Sprite()
{

BodyType="dynamic";
size=%Vector_2D_Sword_Size;
Image="Module_Card_Sword:Image_Sword";
Position=%Target_Player.Player_Sprite_Data.Sprite.Position;
class="Class_Sword";
CollisionCallback="true";
SceneLayer=16;
SceneGroup=26;

DefaultDensity=0;
DefaultRestitution=0;

Module_ID_Parent=%this;

Game_Connection_Handle=%Player_Sprite_Target_Game_Connection_Handle;

Object_Index=%Object_Index;

Health=100;

Joint_ID=0;

Bullet=true;

};

%Script_Object_Player_Information.Sprite_Sword.setCollisionGroups(0,25,26,30);

%Collision_Shape_Index=%Script_Object_Player_Information.Sprite_Sword.createPolygonBoxCollisionShape(%Vector_2D_Sword_Size);

%Script_Object_Player_Information.Sprite_Sword.setCollisionShapeIsSensor(%Collision_Shape_Index,true);

%Script_Object_Player_Information.Sprite_Sword.Position.Y+=(%Target_Player.Player_Sprite_Data.Sprite.Size.Y/2)+(%Vector_2D_Sword_Size.Y/2);

Scene_Dots_and_Crits.add(%Script_Object_Player_Information.Sprite_Sword);

%Script_Object_Player_Information.Sprite_Sword.Joint_ID=Scene_Dots_and_Crits.createRopeJoint
(
%Script_Object_Player_Information.Scene_Object_Anchor,
%Script_Object_Player_Information.Sprite_Sword,
"0 0",0 SPC -%Script_Object_Player_Information.Sprite_Sword.Size.Y,5.0,false
);

%this.Simset_Player_Information.add(%Script_Object_Player_Information);

if (%Target_Player.Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

%this.Player_Information_This=%Script_Object_Player_Information;

}

}
else
{

if (%Player_Object.Sprite_Sword.Visible)
{

%Player_Object.Sprite_Sword.Visible=false;

%Player_Object.Sprite_Sword.setEnabled(false);

%Player_Object.Scene_Object_Anchor.setEnabled(false);

}
else
{

%Player_Object.Sprite_Sword.Visible=true;

%Player_Object.Sprite_Sword.setEnabled(true);

%Player_Object.Scene_Object_Anchor.setEnabled(true);

}

}

}
