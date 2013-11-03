function Module_Card_M4_Rifle::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle)
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

//This skill only allows for the client who cast to have the mounted sprite.
//Targeting itself will toggle the sprite, any other target will be attacked.

%Player_Object=0;

for (%x=0;%x<%this.Simset_Player_Information.getCount();%x++)
{

%Player_Object=%this.Simset_Player_Information.getObject(%x);

if (%Player_Object.Player_Information.Game_Connection_Handle==%Player_Information.Game_Connection_Handle)
{

break;

}
else
{

%Player_Object=0;

}

}

if (%Player_Object==0)//New M4_Rifle user.
{

%Script_Object_Player_Information=new ScriptObject()
{

Player_Information=%Player_Information;

Sprite_M4_Rifle=0;

};

%Vector_2D_M4_Rifle_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_M4_Rifle);

%Script_Object_Player_Information.Sprite_M4_Rifle=new Sprite()
{

BodyType="static";
size=%Vector_2D_M4_Rifle_Size;
Image="Module_Card_M4_Rifle:Image_M4_Rifle";
Position="0 0";

};

%this.Simset_Player_Information.add(%Script_Object_Player_Information);

Scene_Dots_and_Crits.add(%Script_Object_Player_Information.Sprite_M4_Rifle);

%Vector_2D_Player_Size=%Player_Information.Player_Sprite_Data.Composite_Sprite.getSpriteSize();

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Player_Size.Y/2)+(%Vector_2D_M4_Rifle_Size.Y/2);

%Script_Object_Player_Information.Sprite_M4_Rifle.mount(%Player_Information.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(0));

%Bool_Already_Registered_For_Dismount=false;

for (%y=0;%y<%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getCount();%y++)
{

%Mounted_Object=%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getObject(%y);

if (%Mounted_Object==%Script_Object_Player_Information.Sprite_M4_Rifle)
{

%Bool_Already_Registered_For_Dismount=true;

break;

}

}

if (!%Bool_Already_Registered_For_Dismount)
{

%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.add(%Script_Object_Player_Information.Sprite_M4_Rifle);

}

if (%Target_Player.Game_Connection_Handle!=%Player_Information.Game_Connection_Handle)
{

%Target_Player.Module_ID_Player_Sprite.Action_Update_Health(%Target_Player.Player_Sprite_Data,%Target_Player.Game_Connection_Handle,1,100);

}

}
else
{

if (%Player_Object.Sprite_M4_Rifle.Visible)
{

if (%Target_Player.Game_Connection_Handle==%Player_Information.Game_Connection_Handle)
{

%Player_Object.Sprite_M4_Rifle.Visible=false;

}
else
{

%Target_Player.Module_ID_Player_Sprite.Action_Update_Health(%Target_Player.Player_Sprite_Data,%Target_Player.Game_Connection_Handle,1,100);

}

}
else
{

%Player_Object.Sprite_M4_Rifle.Visible=true;

if (%Target_Player.Game_Connection_Handle!=%Player_Information.Game_Connection_Handle)
{

%Target_Player.Module_ID_Player_Sprite.Action_Update_Health(%Target_Player.Player_Sprite_Data,%Target_Player.Game_Connection_Handle,1,100);

}

}

}

}
