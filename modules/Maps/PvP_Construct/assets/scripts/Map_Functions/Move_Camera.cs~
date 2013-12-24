function Module_Map_Deus_Ex_Telum::Move_Camera(%this)
{

if (%this.Camera_Move_Schedule.Direction$="Center")
{

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

Window_Dots_and_Crits.mount(%Player_Object.Player_Sprite_Data.Composite_Sprite,"0 0",0,1,false);

return;

}

}

}

if (Window_Dots_and_Crits.getIsCameraMounted())
{

Window_Dots_and_Crits.dismount();

}

%Camera_Position=Window_Dots_and_Crits.getCameraPosition();

if (%this.Camera_Move_Schedule.Direction$="Up")
{

%Camera_Position.Y++;

}
else if (%this.Camera_Move_Schedule.Direction$="Down")
{

%Camera_Position.Y--;

}
else if (%this.Camera_Move_Schedule.Direction$="Left")
{

%Camera_Position.X--;

}
else if (%this.Camera_Move_Schedule.Direction$="Right")
{

%Camera_Position.X++;

}

Window_Dots_and_Crits.setCameraPosition(%Camera_Position);


%this.Camera_Move_Schedule.Schedule_Handle=schedule(25,0,"Module_Map_Deus_Ex_Telum::Move_Camera",%this);

}
