function Module_Map_Deus_Ex_Telum::Radar_Rotate(%this)
{

if (!isObject(%this.Gui_Radar)){return;}

%Distance_X=mAbs(%this.Scene_Object_Goal.Position.X-$ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Position.X);
%Distance_Y=mAbs(%this.Scene_Object_Goal.Position.Y-$ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Position.Y);

if (%Distance_X>%Distance_Y)
{

if (%this.Scene_Object_Goal.Position.X<$ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Position.X)
{

%this.Gui_Radar.Frame=1;

}
else
{

%this.Gui_Radar.Frame=0;

}

}
else
{

if (%this.Scene_Object_Goal.Position.Y<$ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Position.Y)
{

%this.Gui_Radar.Frame=2;

}
else
{

%this.Gui_Radar.Frame=3;

}

}

schedule(5000,0,"Module_Map_Deus_Ex_Telum::Radar_Rotate",%this);


}
