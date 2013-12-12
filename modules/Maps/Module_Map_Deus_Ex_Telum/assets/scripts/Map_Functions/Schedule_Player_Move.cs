function Module_Map_Deus_Ex_Telum::Schedule_Player_Move(%this,%Direction)
{

if (%this.Player_Move_Schedule.Direction$=%Direction&&%this.Player_Move_Schedule.Schedule_Handle!=0)
{

cancel(%this.Player_Move_Schedule.Schedule_Handle);

%this.Player_Move_Schedule.Schedule_Handle=0;

commandToServer('Relay_Module_Function',$ScriptObject_Player_Information_This.Module_ID_Player_Sprite,"Action_Cancel_Move");

}
else
{

cancel(%this.Player_Move_Schedule.Schedule_Handle);

%this.Player_Move_Schedule.Direction=%Direction;

%this.Player_Move_Schedule.Schedule_Handle=schedule(0,0,"Module_Map_Deus_Ex_Telum::Move_Player",%this);

}

}
