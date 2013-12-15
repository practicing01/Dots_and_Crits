function Module_Card_Grab::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,
%Second_Target_Module_ID_Parent,%Second_Target_Game_Connection_Handle,%Second_Target_Object_Index)
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

/*Find object to grab*/
%Scene_Object_Second_Target=0;

for (%x=0;%x<%Second_Target_Module_ID_Parent.Simset_Objects.getCount();%x++)
{

%Object=%Second_Target_Module_ID_Parent.Simset_Objects.getObject(%x);

if ((%Object.Game_Connection_Handle==%Second_Target_Game_Connection_Handle)&&(%Object.Object_Index==%Second_Target_Object_Index))
{

%Scene_Object_Second_Target=%Object;

break;

}

}

if (%Scene_Object_Second_Target==0){return;}

if (%Player_Object==0)//New Grab user.
{

%Script_Object_Player_Information=new ScriptObject()
{

Player_Information=%Target_Player;

Sprite_Grab=%Scene_Object_Second_Target;

};

%this.Simset_Player_Information.add(%Script_Object_Player_Information);

%Player_Object=%Script_Object_Player_Information;

}
else
{

if (isObject(%Player_Object.Sprite_Grab))
{

%Player_Object.Sprite_Grab.dismount();

%Player_Object.Sprite_Grab.Position=%Player_Object.Sprite_Grab.Position;

for (%y=0;%y<%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getCount();%y++)
{

%Mounted_Object=%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getObject(%y);

if (%Mounted_Object==%Player_Object.Sprite_Grab)
{

%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.remove(%Mounted_Object);

break;

}

}

if (%Player_Object.Sprite_Grab==%Scene_Object_Second_Target)
{

%Player_Object.Sprite_Grab=0;

return;

}

}

%Player_Object.Sprite_Grab=%Scene_Object_Second_Target;

}

%Vector_2D_Grab_Size=%Player_Object.Sprite_Grab.Size;

%Vector_2D_Player_Size=%Target_Player.Player_Sprite_Data.Composite_Sprite.getSpriteSize();

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Player_Size.Y/2)+(%Vector_2D_Grab_Size.Y/2);

%Vector_2D_Rotated_Square_Offset=%Vector_2D_Player_Size;

%Vector_2D_Rotated_Square_Offset.Y=%Vector_2D_Rotated_Square_Offset.Y/3;

%Vector_2D_Mount_Offset.Y+=%Vector_2D_Rotated_Square_Offset.Y;

%Player_Object.Sprite_Grab.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,%Scene_Object_Second_Target.Angle);

%Player_Object.Sprite_Grab.setPosition(%Player_Object.Sprite_Grab.Position);

%Bool_Already_Registered_For_Dismount=false;

for (%y=0;%y<%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getCount();%y++)
{

%Mounted_Object=%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getObject(%y);

if (%Mounted_Object==%Player_Object.Sprite_Grab)
{

%Bool_Already_Registered_For_Dismount=true;

break;

}

}

if (!%Bool_Already_Registered_For_Dismount)
{

%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.add(%Player_Object.Sprite_Grab);

}

}
