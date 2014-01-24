function Class_Bath_Salts_Monster::AI(%this)
{

if (!isObject(%this)){return;}

//Check if player is close.

if (Vector2Distance(%this.Position,$ScriptObject_Player_Information_This.Player_Sprite_Data.Sprite.Position)
<=Vector2Distance("0 0",%this.Scaled_Resolution))
{

/************************************************************/

%Float_Angle_To_Point=Vector2AngleToPoint(%this.Position,$ScriptObject_Player_Information_This.Player_Sprite_Data.Sprite.Position);

%Float_Angle_To_Point=(%Float_Angle_To_Point+360)%360;

if (%Float_Angle_To_Point>22.5&&%Float_Angle_To_Point<=67.5)//Down-Left
{

%this.Direction="-1 1";

if (%this.Monster_Type==0)//Cerberus
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Cerberus_Run_Up_Right")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Cerberus_Run_Up_Right");

}

}
else if (%this.Monster_Type==1)//Pixel Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Up_Right")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Up_Right");

}

}
else if (%this.Monster_Type==2)//Pseudo Spider
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Up_Right")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Up_Right");

}

}
else if (%this.Monster_Type==3)//Thin Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Up_Right")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Up_Right");

}

}

%this.moveTo($ScriptObject_Player_Information_This.Player_Sprite_Data.Sprite.Position,%this.Current_Speed,true,false);

}
else if (%Float_Angle_To_Point>67.5&&%Float_Angle_To_Point<=112.5)//Down
{

%this.Direction="0 1";

if (%this.Monster_Type==0)//Cerberus
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Cerberus_Run_Up")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Cerberus_Run_Up");

}

}
else if (%this.Monster_Type==1)//Pixel Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Up")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Up");

}

}
else if (%this.Monster_Type==2)//Pseudo Spider
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Up")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Up");

}

}
else if (%this.Monster_Type==3)//Thin Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Up")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Up");

}

}

%this.moveTo($ScriptObject_Player_Information_This.Player_Sprite_Data.Sprite.Position,%this.Current_Speed,true,false);

}
else if (%Float_Angle_To_Point>112.5&&%Float_Angle_To_Point<=157.5)//Down-Right
{

%this.Direction="1 1";

if (%this.Monster_Type==0)//Cerberus
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Cerberus_Run_Up_Left")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Cerberus_Run_Up_Left");

}

}
else if (%this.Monster_Type==1)//Pixel Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Up_Left")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Up_Left");

}

}
else if (%this.Monster_Type==2)//Pseudo Spider
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Up_Left")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Up_Left");

}

}
else if (%this.Monster_Type==3)//Thin Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Up_Left")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Up_Left");

}

}

%this.moveTo($ScriptObject_Player_Information_This.Player_Sprite_Data.Sprite.Position,%this.Current_Speed,true,false);

}
else if (%Float_Angle_To_Point>157.5&&%Float_Angle_To_Point<=202.5)//Right
{

%this.Direction="1 0";

if (%this.Monster_Type==0)//Cerberus
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Cerberus_Run_Left")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Cerberus_Run_Left");

}

}
else if (%this.Monster_Type==1)//Pixel Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Left")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Left");

}

}
else if (%this.Monster_Type==2)//Pseudo Spider
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Left")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Left");

}

}
else if (%this.Monster_Type==3)//Thin Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Left")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Left");

}

}

%this.moveTo($ScriptObject_Player_Information_This.Player_Sprite_Data.Sprite.Position,%this.Current_Speed,true,false);

}
else if (%Float_Angle_To_Point>202.5&&%Float_Angle_To_Point<=247.5)//Up-Right
{

%this.Direction="1 -1";

if (%this.Monster_Type==0)//Cerberus
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Cerberus_Run_Down_Left")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Cerberus_Run_Down_Left");

}

}
else if (%this.Monster_Type==1)//Pixel Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Down_Left")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Down_Left");

}

}
else if (%this.Monster_Type==2)//Pseudo Spider
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Down_Left")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Down_Left");

}

}
else if (%this.Monster_Type==3)//Thin Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Down_Left")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Down_Left");

}

}

%this.moveTo($ScriptObject_Player_Information_This.Player_Sprite_Data.Sprite.Position,%this.Current_Speed,true,false);

}
else if (%Float_Angle_To_Point>247.5&&%Float_Angle_To_Point<=292.5)//Up
{

%this.Direction="0 -1";

if (%this.Monster_Type==0)//Cerberus
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Cerberus_Run_Down")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Cerberus_Run_Down");

}

}
else if (%this.Monster_Type==1)//Pixel Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Down")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Down");

}

}
else if (%this.Monster_Type==2)//Pseudo Spider
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Down")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Down");

}

}
else if (%this.Monster_Type==3)//Thin Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Down")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Down");

}

}

%this.moveTo($ScriptObject_Player_Information_This.Player_Sprite_Data.Sprite.Position,%this.Current_Speed,true,false);

}
else if (%Float_Angle_To_Point>292.5&&%Float_Angle_To_Point<=337.5)//Up-Left
{

%this.Direction="-1 -1";

if (%this.Monster_Type==0)//Cerberus
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Cerberus_Run_Down_Right")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Cerberus_Run_Down_Right");

}

}
else if (%this.Monster_Type==1)//Pixel Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Down_Right")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Down_Right");

}

}
else if (%this.Monster_Type==2)//Pseudo Spider
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Down_Right")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Down_Right");

}

}
else if (%this.Monster_Type==3)//Thin Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Down_Right")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Down_Right");

}

}

%this.moveTo($ScriptObject_Player_Information_This.Player_Sprite_Data.Sprite.Position,%this.Current_Speed,true,false);

}
else if (%Float_Angle_To_Point>337.5&&%Float_Angle_To_Point<=22.5)//Left
{

%this.Direction="-1 0";

if (%this.Monster_Type==0)//Cerberus
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Cerberus_Run_Right")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Cerberus_Run_Right");

}

}
else if (%this.Monster_Type==1)//Pixel Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Right")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pixel_Zombie_Run_Right");

}

}
else if (%this.Monster_Type==2)//Pseudo Spider
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Right")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Pseudo_Spider_Run_Right");

}

}
else if (%this.Monster_Type==3)//Thin Zombie
{

if (%this.Animation!$="Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Right")
{

%this.playAnimation("Module_Map_Bath_Salts:Animation_Thin_Zombie_Run_Right");

}

}

%this.moveTo($ScriptObject_Player_Information_This.Player_Sprite_Data.Sprite.Position,%this.Current_Speed,true,false);

}

/************************************************************/

}

%this.Schedule_Handle_AI=schedule(1000,0,"Class_Bath_Salts_Monster::AI",%this);

}