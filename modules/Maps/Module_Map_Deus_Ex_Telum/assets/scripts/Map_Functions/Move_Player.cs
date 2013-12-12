function Module_Map_Deus_Ex_Telum::Move_Player(%this)
{

if (%this.Player_Move_Schedule.Direction$="Center")
{

commandToServer('Relay_Module_Function',$ScriptObject_Player_Information_This.Module_ID_Player_Sprite,"Action_Cancel_Move");

return;

}

%Vector_2D_Direction="0 0";

if (%this.Player_Move_Schedule.Direction$="Up")
{

%Vector_2D_Direction.Y++;

}
else if (%this.Player_Move_Schedule.Direction$="Down")
{

%Vector_2D_Direction.Y--;

}
else if (%this.Player_Move_Schedule.Direction$="Left")
{

%Vector_2D_Direction.X--;

}
else if (%this.Player_Move_Schedule.Direction$="Right")
{

%Vector_2D_Direction.X++;

}

%Vector_2D_Direction=Vector2Mult(%Vector_2D_Direction,"1000 1000");

%Vector_2D_World_Point=Vector2Add($ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Position,%Vector_2D_Direction);

commandToServer('Relay_Module_Function',$ScriptObject_Player_Information_This.Module_ID_Player_Sprite,"Action_Move",%Vector_2D_World_Point);

//%this.Player_Move_Schedule.Schedule_Handle=schedule(1000,0,"Module_Map_Deus_Ex_Telum::Move_Player",%this);

}
