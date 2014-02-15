function Module_Map_Kana_Study::Schedule_Camera_Move(%this,%Direction)
{

if (%this.Camera_Move_Schedule.Direction$=%Direction&&%this.Camera_Move_Schedule.Schedule_Handle!=0)
{

cancel(%this.Camera_Move_Schedule.Schedule_Handle);

%this.Camera_Move_Schedule.Schedule_Handle=0;

if (Window_Dots_and_Crits.getIsCameraMounted())
{

Window_Dots_and_Crits.dismount();

}

}
else
{

cancel(%this.Camera_Move_Schedule.Schedule_Handle);

%this.Camera_Move_Schedule.Direction=%Direction;

%this.Camera_Move_Schedule.Schedule_Handle=schedule(25,0,"Module_Map_Kana_Study::Move_Camera",%this);

}

}
