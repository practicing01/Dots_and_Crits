function Module_Player_Class::Player_Data_Remove(%this,%Player)
{

for (%x=0;%x<%this.Simset_Player_Data.getCount();%x++)
{

%Player_Data=%this.Simset_Player_Data.getObject(%x);

if (%Player.Game_Connection_Handle==%Player_Data.Game_Connection_Handle)
{

%Player_Data.Player_Sprite_Data.Composite_Sprite.Module_ID_Parent.Player_Sprite_Data_Remove(%Player_Data.Player_Sprite_Data);

/*Delete animation simsets.*/
for (%y=0;%y<%Player_Data.Player_Sprite_Data.getDynamicFieldCount();%y++)
{

%Dynamic_Field=%Player_Data.Player_Sprite_Data.getFieldValue(%Player_Data.Player_Sprite_Data.getDynamicField(%y));

if (!isObject(%Dynamic_Field))
{

continue;

}

if (%Dynamic_Field.getClassName()$="Simset")
{

%Dynamic_Field.deleteObjects();
%Dynamic_Field.delete();

%y=-1;

}

}

%this.Simset_Player_Data.remove(%Player_Data);

%Player_Data.Player_Sprite_Data.Scene_Object_Mount.safeDelete();

%Player_Data.Player_Sprite_Data.Composite_Sprite.safeDelete();

%Player_Data.Player_Sprite_Data.delete();

%Player_Data.delete();

break;

}

}
 
}
