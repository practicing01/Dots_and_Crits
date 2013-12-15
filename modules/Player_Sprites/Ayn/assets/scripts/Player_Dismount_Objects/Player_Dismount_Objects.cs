function Module_Player_Sprite_Ayn::Player_Dismount_Objects(%this,%Player_Information)
{

for (%x=0;%x<%Player_Information.Simset_Objects_To_Dismount.getCount();%x++)
{

%Object_To_Dismount=%Player_Information.Simset_Objects_To_Dismount.getObject(%x);

if (isObject(%Object_To_Dismount))
{

%Object_To_Dismount.dismount();

}

}

}
