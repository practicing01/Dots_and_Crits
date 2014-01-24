function Module_Card_Vehicle_Orca::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle)
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

if (%Player_Object==0)//New Vehicle_Orca user.
{

%Script_Object_Player_Information=new ScriptObject()
{

Player_Information=%Target_Player;

Sprite_Vehicle_Orca=0;

};

%Vector_2D_Vehicle_Orca_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Vehicle_Orca);

%Script_Object_Player_Information.Sprite_Vehicle_Orca=new Sprite()
{

BodyType="static";
size=%Vector_2D_Vehicle_Orca_Size;
Image="Module_Card_Vehicle_Orca:Image_Vehicle_Orca";
Position="0 0";
Frame=4;

};

%this.Simset_Player_Information.add(%Script_Object_Player_Information);

if (%Target_Player.Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

%this.Player_Information_This=%Script_Object_Player_Information;

}

Scene_Dots_and_Crits.add(%Script_Object_Player_Information.Sprite_Vehicle_Orca);

%Script_Object_Player_Information.Sprite_Vehicle_Orca.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,"0 0",0,true,mDegToRad(180));

%Bool_Already_Registered_For_Dismount=false;

for (%y=0;%y<%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getCount();%y++)
{

%Mounted_Object=%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getObject(%y);

if (%Mounted_Object==%Script_Object_Player_Information.Sprite_Vehicle_Orca)
{

%Bool_Already_Registered_For_Dismount=true;

break;

}

}

if (!%Bool_Already_Registered_For_Dismount)
{

%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.add(%Script_Object_Player_Information.Sprite_Vehicle_Orca);

}

%Target_Player.Player_Sprite_Data.Sprite.setBlendAlpha(0);

%Target_Player.Player_Sprite_Data.Current_Speed+=%Target_Player.Player_Sprite_Data.Base_Speed;

}
else
{

if (%Player_Object.Sprite_Vehicle_Orca.Visible)
{

%Player_Object.Sprite_Vehicle_Orca.Visible=false;

%Player_Object.Player_Information.Player_Sprite_Data.Sprite.setBlendAlpha(1);

%Player_Object.Player_Information.Player_Sprite_Data.Current_Speed-=%Player_Object.Player_Information.Player_Sprite_Data.Base_Speed;

}
else
{

%Player_Object.Sprite_Vehicle_Orca.Visible=true;

%Player_Object.Player_Information.Player_Sprite_Data.Sprite.setBlendAlpha(0);

%Player_Object.Player_Information.Player_Sprite_Data.Current_Speed+=%Player_Object.Player_Information.Player_Sprite_Data.Base_Speed;

}

}

}
